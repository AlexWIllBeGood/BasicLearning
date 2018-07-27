using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicLearning.Models
{
    public class ContractRepository : IContractRepository
    {
        IMongoClient client = null;
        IMongoDatabase dataBase = null;
        IMongoCollection<BsonDocument> collection=null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public ContractRepository(string connection)
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
            collection = dataBase.GetCollection<BsonDocument>("foo");
        }
        public Contact AddContact(Contact item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveContact(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateContact(string id, Contact item)
        {
            throw new NotImplementedException();
        }
    }
}