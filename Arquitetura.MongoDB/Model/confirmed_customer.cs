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
    public class Confirmed_customer
    {

        public Confirmed_customer()
        {
            customer_web = new List<Customer_web>();
           
        }

        public Object id { get; set; }

        [BsonElementAttribute("eventname")]
        public String eventname { get; set; }

        [BsonElementAttribute("email")]
        public String email { get; set; }

        [BsonElementAttribute("customer_web")]
        public IList<Customer_web> customer_web { get; set; }

    }
}
