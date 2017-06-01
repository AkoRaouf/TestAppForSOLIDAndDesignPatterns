using System.Web.Mvc;
using TestAppForSOLIDAndDesignPatterns.Core.Core.OCP;
using TestAppForSOLIDAndDesignPatterns.Web.Models;

namespace TestAppForSOLIDAndDesignPatterns.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IncomeDetails incomeDetails)
        {
            ICountryTaxCalculator t = null;
            switch (incomeDetails.Countary)
            {
                case "USA":
                    t = new TaxCalculatorForUs();
                    break;
                case "UK":
                    t = new TaxCalculatorForUk();
                    break;
                case "IN":
                    t = new TaxCalculatorForIn();
                    break;
            }
            if (t == null) return View();
            t.TotalIncome = incomeDetails.TotalIncome;
            t.TotalDeduction = incomeDetails.TotalDeduction;
            var taxCalculator = new TaxCalculator();
            ViewBag.TotalTax = taxCalculator.Calculate(t);
            return View("Index", incomeDetails);
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