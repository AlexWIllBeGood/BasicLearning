using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicLearning.Models
{
    public class ContactRepository : IContactRepository
    {
        IMongoClient client = null;
        IMongoDatabase dataBase = null;
        IMongoCollection<Contact> contacts=null;
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
            dataBase = client.GetDatabase("TestDb");
            contacts = dataBase.GetCollection<Contact>("foo");
        }
        public Contact AddContact(Contact item)
        {
            contacts.InsertOne(item);
            return item;
        }

        public IEnumerable GetAllContacts()
        {
            return contacts.Find(Builders<Contact>.Filter.Empty).ToList();
        }

        public Contact GetContact(string id)
        {
            return contacts.Find(e => e.Id == id).ToList().FirstOrDefault();
        }

        public bool RemoveContact(string id)
        {
            try
            {
                DeleteResult ur= contacts.DeleteOne(e => e.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateContact(string id, Contact item)
        {
            try
            {
                var updateBuilder = Builders<Contact>.Update.Set("Name", item.Name).Set("Phone", item.Phone).Set("Email", item.Email).Set("LastModified", item.LastModified);
                UpdateResult ur = contacts.UpdateOne(e => e.Id == id, updateBuilder);
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }
    }
}