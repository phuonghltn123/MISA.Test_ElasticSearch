using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Test_ElasticSearch.Models;
using Nest;

namespace MISA.Test_ElasticSearch.Controllers
{
    public class CatalogController : Controller
    {

        private ElasticClient client;
        public CatalogController( ElasticClient client)
        {
            this.client = client; 
        }
        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getdata")]
        public async Task<List<Recipe>> DoSearchAsync()
        {
            var response = await (client.SearchAsync<Recipe>
                (
                    s => s.Index("abc.abcd").Size(100).Query(q => q.Match(m => m.Field(f => f.name).Query("Cold Coban"))).Sort(so => so.Ascending(de => de.cookTime.Suffix("keyword")))
                )) ;
            return response.Hits.Select(s => s.Source).ToList();
        }

        // GET: Catalog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }   

        // GET: Catalog/Create
        public ActionResult Create()
        {
            return View();
        }



        // GET: Catalog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}