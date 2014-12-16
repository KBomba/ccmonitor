using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;
using Newtonsoft.Json;

namespace ccMonitor.Api
{
    public static class JsonControl
    {
        public static T DownloadSerializedApi<T>(Stream rawStream) where T : new()
        {
            using (JsonReader reader = new JsonTextReader(
                    new StreamReader(new BufferedStream(
                            rawStream))))
            {
                JsonSerializer serializer = new JsonSerializer {NullValueHandling = NullValueHandling.Ignore};
                return serializer.Deserialize<T>(reader);
            }
        }


        public static T GetSerializedGzipFile<T>(string location) where T : new()
        {
            try
            {
                using (JsonReader reader =
                    new JsonTextReader(new StreamReader(
                        new GZipStream(new BufferedStream(
                            File.Open(location, FileMode.Open)), CompressionMode.Decompress))))
                {
                    return new JsonSerializer().Deserialize<T>(reader);
                }
            }
            catch
            {
                return new T();
            }
        }

        public static void WriteSerializedGzipFile(string location, object o)
        {
            using (StreamWriter streamWriter =
                new StreamWriter(new GZipStream(
                    File.Create(location), CompressionLevel.Optimal)))
            {
                streamWriter.Write(JsonConvert.SerializeObject(o, Formatting.None));
            }
        }

        public static T DeepCopyTrick<T>(T obj)
        {
            // Workaround for deepcopying 
            // Won't apply to items out of scope and can be slow
            string s = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(s);
        }
    }
}