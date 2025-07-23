using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public static class SerializationHelper
    {
        public static void SerializeUsers(LinkedListADT users, string fileName)
        {
            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.Create(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, users);
                //serializer.WriteObject(stream, users);
            }
        }

        public static LinkedListADT DeserializeUsers(string fileName)
        {
            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.OpenRead(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (LinkedListADT)formatter.Deserialize(stream);
                //return (List<User>)serializer.ReadObject(stream);
            }
        }
      
    }
}
