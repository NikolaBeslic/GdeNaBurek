using GdeNaBurek.Models;
using GdeNaBurek.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GdeNaBurek.Controllers
{
    public class PekaraController : Controller
    {
        private ApplicationDbContext _context;

        public PekaraController()
        {
            _context = new ApplicationDbContext();
        }

        
        public ActionResult Create()
        {
            //vracanje gradova iz baze
            var ViewModel = new PekaraFormViewModel
            {
                Gradovi = _context.Gradovi.ToList()
            };

            return View(ViewModel);
        }
    }
}