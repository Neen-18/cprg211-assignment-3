using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3
{
    public class SerializationTests
    {
        private List<User> users = new List<User>();
        private LinkedListADT linkedlistUsers;
        private readonly string testFileName = "test_users.bin";

        [SetUp]
        public void Setup()
        {
            users.Append(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.Append(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.Append(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Append(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));

            linkedlistUsers = new SLL();
            foreach (User user in users)
            {
                linkedlistUsers.Append(user);
            }
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        //Tests the object was serialized.
        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers((SLL)linkedlistUsers, testFileName);
            Assert.IsTrue(File.Exists(testFileName));
        }

        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers((SLL)linkedlistUsers, testFileName);
            SLL deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            Assert.AreEqual(linkedlistUsers.Size(), deserializedUsers.Size());
            for (int i = 0; i < linkedlistUsers.Size(); i++)
            {
                User user = (User)linkedlistUsers.Retrieve(i);
                User deserializedUser = (User)deserializedUsers.Retrieve(i);
                Assert.AreEqual(user.Id, deserializedUser.Id);
                Assert.AreEqual(user.Name, deserializedUser.Name);
                Assert.AreEqual(user.Email, deserializedUser.Email);
                Assert.AreEqual(user.Password, deserializedUser.Password);
            }
        }
    }
}