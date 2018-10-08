﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi20181008.Models
{
    public class Contact
    {
        [BsonId]
        public string Id { get; set;}
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime LastModified { get; set; }
    }
}