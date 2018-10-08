using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi20181008.Models
{
    public class ContactRepository : IContactRepository
    {
        IMongoClient client = null;
        IMongoDatabase database = null;
        IMongoCollection<Contact> contacts = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public ContactRepository(string connection)
        {
            if (!string.IsNullOrWhiteSpace(connection))
            {
                client = new MongoClient(connection);
            }
            else
            {
                client = new MongoClient();
            }
            database = client.GetDatabase("TestDb");
            contacts = database.GetCollection<Contact>("foo");
        }
        public Contact AddContact(Contact item)
        {
            item.Id = ObjectId.GenerateNewId().ToString();
            item.LastModified = DateTime.Now;
            contacts.InsertOne(item);
            return item;
        }

        public IEnumerable GetAllContacts()
        {
            return contacts.Find(null).ToList();
        }

        public Contact GetContact(string id)
        {
            return contacts.Find(e => e.Id == id).FirstOrDefault();
;        }

        public bool RemoveContact(string id)
        {
            long deletedcount=contacts.DeleteOne(e=>e.Id==id).DeletedCount;
            return deletedcount == 1;
        }

        public bool UpdateContact(string id, Contact item)
        {
            var updateBuilder = Builders<Contact>.Update.Set("Name", item.Name).Set("Phone", item.Phone).Set("LastModified", item.LastModified);
            long modifiedCount=contacts.UpdateOne(e => e.Id == id, updateBuilder).ModifiedCount;
            return modifiedCount == 1;
        }
    }
}