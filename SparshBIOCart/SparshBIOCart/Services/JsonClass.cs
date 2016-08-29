using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    class JsonClass
    {
        public static string JSONSerialize<T>(T obj) // serialize json for sending to php
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                return ms.ToArray().ToString();
//                return System.Text.Encoding.GetString(ms.ToArray());
            }
        }

        public static T JSONDeserialise<T>(string json) // deserialize json for getting data
        {
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                return obj;
            }
        }
    }
}
