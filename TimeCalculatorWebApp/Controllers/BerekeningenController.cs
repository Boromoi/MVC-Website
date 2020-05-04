using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeCalculatorWebApp.Calculator;

namespace TimeCalculatorWebApp.Controllers
{
    public class BerekeningenController : Controller
    {
        // GET: Berekeningen
        public ActionResult Index()
        {
            Models.BerekeningenViewModel emptyModel = new Models.BerekeningenViewModel();
            return View(emptyModel);
        }
        // POST: Berekeningen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<Models.BerekeningenViewModel> Index(Models.BerekeningenViewModel collection)
        {
            // TODO: Add insert logic here
            var dateTimeBeginTijd = DateTime.Parse(collection.DateTimeBeginTijd);
            var dateTimeEindTijd = DateTime.Parse(collection.DateTimeEindTijd);

            var mijnBerekeningen = new Berekeningen(dateTimeBeginTijd, dateTimeEindTijd);
            collection.Resultaat = $"Resultaat Uren:[{mijnBerekeningen.hours}], Minuten:[{mijnBerekeningen.minutes}]";

            return View(collection);
        }
    }
}