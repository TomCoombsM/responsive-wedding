using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;


namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            WeddingRepos weddingRepos = new WeddingRepos();
            var persons = weddingRepos.GetPersons();
            return View(persons.ToList());
        }

        [HttpPost]
        public JsonResult Index(Person person)
        {
            WeddingRepos weddingRepos = new WeddingRepos();
            weddingRepos.AddOrGetPerson(person);
            //weddingContext
            return new JsonResult();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}