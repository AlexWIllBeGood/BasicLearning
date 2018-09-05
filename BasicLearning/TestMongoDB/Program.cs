using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMongoDB
{
    class Program
    {
        static IMongoClient client = null;
        static IMongoDatabase dataBase = null;
        static IMongoCollection<Contact> contacts = null;
        static void Main(string[] args)
        {
            InitDb("");
            //for (int index = 1; index < 5; index++)
            //{
            //    Contact contact = new Contact
            //    {
            //        Email = string.Format("test{0}@example.com", index),
            //        Name = string.Format("test{0}", index),
            //        Phone = string.Format("{0}{0}{0} {0}{0}{0} {0}{0}{0}{0}", index)
            //    };
            //    Insert(contact);
            //}
            //删除
            //Delete("5b5ac1d291cbf80c7025dd83");
            var contact = GetContactById("5b5ac1d691cbf80c7025dd84");
            Console.WriteLine(string.Format("Name:{0} Phone:{1} Email:{2} LastModified:{3}",contact.Name,contact.Phone,contact.Email,contact.LastModified));
            Contact c = new Contact() {Id= "5b5ac1d691cbf80c7025dd84", Name="Alex",Email="AlexWillBeGood@163.com",Phone="18520723220",LastModified=DateTime.UtcNow};
            Update(c);
            Console.ReadLine();

        }
        /// <summary>
        /// 初始化DB
        /// </summary>
        /// <returns></returns>
        public static bool InitDb(string connection)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(connection))
                {
                    client = new MongoClient(connection);
                }
                else
                {
                    client = new MongoClient();
                }
                dataBase = client.GetDatabase("TestDb");
                contacts = dataBase.GetCollection<Contact>("foo");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        public static bool Insert(Contact c)
        {
            try
            {
                //生成GUID
                //c.Id = Guid.NewGuid().ToString("N");
                //类似于GUID，但是只有24位
                c.Id = ObjectId.GenerateNewId().ToString();
                c.LastModified = DateTime.UtcNow;
                contacts.InsertOne(c);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                contacts.DeleteOne(e => e.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <returns></returns>
        public static bool Update(Contact contact)
        {
            try
            {
                //是否有方法能够不去一一定义？
                var updateBuilder=Builders<Contact>.Update.Set("Name", contact.Name).Set("Email", contact.Email).Set("Phone", contact.Phone).Set("LastModified", contact.LastModified);
                contacts.UpdateOne(e => e.Id == contact.Id, updateBuilder);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public static Contact GetContactById(string id)
        {
            Contact c = contacts.Find(e => e.Id==id).ToList().FirstOrDefault();
            return c;
        }
    }
}
