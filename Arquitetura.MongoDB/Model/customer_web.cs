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
    public class Customer_web
    {

        public Customer_web()
        {
            this.confirmed_customer = new HashSet<Confirmed_customer>();
        }

        public Object id { get; set; }

        [BsonElementAttribute("fullname")]
        public String fullname { get; set; }

        [BsonElementAttribute("email")]
        public String email { get; set; }

        [BsonElementAttribute("postCode")]
        public String postCode { get; set; }

         [BsonElementAttribute("confirmed_customer")]
        public virtual ICollection<Confirmed_customer> confirmed_customer { get; set; }

    }
}
