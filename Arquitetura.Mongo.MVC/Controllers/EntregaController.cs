using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using Arquitetura.MongoDB;

namespace Arquitetura.Mongo.MVC.Controllers
{
    public class EntregaController : Controller
    {
        //
        // GET: /Entregas/
        public ActionResult Index(string id)
        {
            // Get remarks by id
            var caixaAzul = MongoWrapper.GetDatabase().
                            GetCollection("caixaAzul").
                            FindOneByIdAs<CaixaAzul>(ObjectId.Parse(id));

            return View(caixaAzul);
        }

        [HttpPost]
        public ActionResult Index(string id, string codEntrega, string faturado)
        {
            var caixaAzul = MongoWrapper.GetDatabase().GetCollection("caixaAzul");
            var caixaAzulOne = caixaAzul.FindOneById(ObjectId.Parse(id));

            var entrega = new BsonDocument().
                                Add("codigoEntrega", codEntrega).
                                Add("faturado", faturado);

            if (caixaAzulOne.Contains("entregas"))
            {
                caixaAzulOne["entregas"].AsBsonArray.Add(BsonValue.Create(entrega));
            }
            else
            {
                caixaAzulOne["entregas"] = new BsonArray().Add(BsonValue.Create(entrega));
            }

            caixaAzul.Save(caixaAzulOne);

            return RedirectToAction("Index", new { id = id });
        }

    }
}
