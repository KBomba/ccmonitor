using System.IO;
using System.IO.Compression;
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
                using (JsonReader reader =new JsonTextReader(new StreamReader(
                        new GZipStream(new BufferedStream(File.Open(location, FileMode.Open), 
                            (int) new FileInfo(location).Length), CompressionMode.Decompress))))
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
            using (JsonWriter jw = new JsonTextWriter(new StreamWriter(
                new GZipStream(File.Open(location, FileMode.Create), CompressionLevel.Fastest))))
            {
                jw.Formatting = Formatting.None;
                
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jw, o);
            }
        }


        public static T DeepCopyTrick<T>(T obj)
        {
            // Workaround for deepcopying 
            // Won't apply to items out of scope and can be slow
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }
    }
}