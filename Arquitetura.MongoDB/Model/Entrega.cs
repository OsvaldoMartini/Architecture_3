using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Arquitetura.MongoDB
{
    public class Entrega
    {
        [BsonElementAttribute("codigoEntrega")]
        public long CodigoEntrega;
        [BsonElementAttribute("faturado")]
        public bool Faturado;
    }
}