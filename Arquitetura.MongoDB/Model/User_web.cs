using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Arquitetura.MongoDB
{
    public class User_web
    {

        public Object id { get; set; }
        [BsonElementAttribute("login")]
        public String login { get; set; }
        [BsonElementAttribute("password")]
        public String password { get; set; }

    }
}
