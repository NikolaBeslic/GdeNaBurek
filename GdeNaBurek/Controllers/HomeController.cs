using GdeNaBurek.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace GdeNaBurek.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var svePekare = _context.Pekare.
                Include(p => p.Grad);
            return View(svePekare);
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