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
    public class CaixaAzul
    {
        public CaixaAzul()
        {
            Entregas = new List<Entrega>();
           
        }

        public ObjectId id { get; set; }
        [BsonElementAttribute("cnpjCD")]
        public String cnpjCD { get; set; }
        [BsonElementAttribute("numeroCaixa")]
        public long numeroCaixa { get; set; }
        [BsonElementAttribute("entregas")]
        public IList<Entrega> Entregas { get; set; }

        public string GetFullName()
        {
            return String.Format("CNPJ CD: {0} Número Caixa : {1}", cnpjCD, numeroCaixa);
        }

        

    }
}
