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
        public static void SerializeUsers(SLL users, string fileName)
        {
            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            List<User> userList = new List<User>();
            using (FileStream stream = File.Create(fileName))
            {
                for(Node current = users.Head; current != null; current = current.Succesor)
                {
                    userList.Add((User)current.Element);
                }
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, userList);
                //serializer.WriteObject(stream, users);
            }
        }

        public static SLL DeserializeUsers(string fileName)
        {
            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.OpenRead(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<User> userList = (List<User>)formatter.Deserialize(stream);
                SLL users = new SLL();
                foreach (User user in userList)
                {
                    users.Append(user);
                }
                return users;
            }
        }
      
    }
}
