//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
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
    public class Allevent
    {

        public Object id { get; set; }

        [BsonElementAttribute("eventname")]
        public String eventname { get; set; }
           [BsonElementAttribute("eventdate")]
        public System.DateTime eventdate { get; set; }



    }
}
