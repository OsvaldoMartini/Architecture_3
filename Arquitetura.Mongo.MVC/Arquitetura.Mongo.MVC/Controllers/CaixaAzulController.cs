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
    public class CaixaAzulController : Controller
    {
        //
        // GET: /CaixaAzul/

        public ActionResult Index()
        {
            // Get all users by sorting by createdate
            var caixaAzul = MongoWrapper.GetDatabase().
                            GetCollection("caixaAzul").
                            FindAll().
                            SetSortOrder(SortBy.Descending("createdate"));

            return View(caixaAzul);
        }


        public ActionResult Edit(string id)
        {
            // Obtain id compatible with MongoDB to query
            var objectId = ObjectId.Parse(id);

            // Get user by id
            var caixaAzul = MongoWrapper.GetDatabase().
                            GetCollection("caixaAzul").
                            FindOneByIdAs<CaixaAzul>(ObjectId.Parse(id));

            return View(caixaAzul);
        }

        [HttpPost]
        public ActionResult Edit(string id, CaixaAzul caixaAzulToEdit)
        {
            // Get user collection reference
            var caixaAzulDB = MongoWrapper.GetDatabase().GetCollection("caixaAzul");

            // Update user by id
            var caixaAzul = caixaAzulDB.FindOneById(ObjectId.Parse(id));

            caixaAzul["numeroCaixa"] = caixaAzulToEdit.numeroCaixa;
            caixaAzul["cnpjCD"] = caixaAzulToEdit.cnpjCD;

            // Update user object
            caixaAzulDB.Save(caixaAzul);

            return RedirectToAction("Index");
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(string id, CaixaAzul caixaAzulToEdit)
        {
            // Get user collection reference
            var caixaAzulDb = MongoWrapper.GetDatabase().GetCollection("caixaAzul");

            // Create BsonDocument object for new user
            var caixaAzul = new BsonDocument();
            caixaAzul["numeroCaixa"] = caixaAzulToEdit.numeroCaixa;
            caixaAzul["cnpjCD"] = caixaAzulToEdit.cnpjCD;
            //caixaAzul["entrega"] = caixaAzulToEdit.entrega;
            //CaixaAzul["createdate"] = DateTime.Now;

            // Insert new user object to collection
            caixaAzulDb.Insert(caixaAzul);

            return RedirectToAction("Index");
        }

    }
}
