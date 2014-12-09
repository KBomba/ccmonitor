using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace ccMonitor.Api
{
    internal static class PruvotApi
    {
        // Converts the results from Pruvots api to an array of dictionaries to get more JSON like results
        public static Dictionary<string, string>[] ConvertPruvotToDictArray(string apiResult)
        {
            if(apiResult == null) return null;

            // Will return a Dict per GPU
            string[] splitGroups = apiResult.Split('|');

            Dictionary<string, string>[] totalDict = new Dictionary<string, string>[splitGroups.Length - 1];
            
            for (int index = 0; index < splitGroups.Length - 1; index++)
            {
                Dictionary<string, string> separateDict = new Dictionary<string, string>();
                string[] keyValues = splitGroups[index].Split(';');
                for (int i = 0; i < keyValues.Length; i++)
                {
                    string[] elements = keyValues[i].Split('=');
                    separateDict.Add(elements[0], elements[1]);
                }
                totalDict[index] = separateDict;
            }

            return totalDict;
        }

        public static T GetDictValue<T>(Dictionary<string, string> dictionary, string key)
        {
            string value;

            if (dictionary.TryGetValue(key, out value))
            {
                return (T) Convert.ChangeType(value, typeof (T), CultureInfo.InvariantCulture);
            }
            return (T) Convert.ChangeType(-1, typeof (T), CultureInfo.InvariantCulture);
        }

        // Overload that just returns the string without type conversion
        public static string GetDictValue(Dictionary<string, string> dictionary, string key)
        {
            string value;

            if (dictionary.TryGetValue(key, out value))
            {
                return value;
            }

            return "-1";
        }

        public static Dictionary<string, string>[] GetSummary(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "summary");
        }

        public static Dictionary<string, string>[] GetHwInfo(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "hwinfo");
        }

        public static Dictionary<string, string>[] GetMemInfo(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "meminfo");
        }

        public static Dictionary<string, string>[] GetThreads(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "threads");
        }

        public static Dictionary<string, string>[] GetHistory(string ip = "127.0.0.1", int port = 4068, int minerMap = -1)
        {
            return minerMap == -1 ? Request(ip, port, "histo") : Request(ip, port, "histo|" + minerMap);
        }

        public static Dictionary<string, string>[] GetPoolInfo(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "pool");
        }

        public static Dictionary<string, string>[] GetScanLog(string ip = "127.0.0.1", int port = 4068)
        {
            return Request(ip, port, "scanlog");
        }


        private static Dictionary<string, string>[] Request(string ip, int port, string message)
        {
            string responseData;

            try
            {
                using (TcpClient client = new TcpClient(ip, port))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    data = new Byte[4096];

                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.ASCII.GetString(data, 0, bytes);
                }
            }
            catch (Exception)
            {
                return null;
            }
            

            return ConvertPruvotToDictArray(responseData);
        }
    }
}
