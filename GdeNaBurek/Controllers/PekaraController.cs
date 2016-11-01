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

        [Authorize] //samo ulogovani korisnici
        public ActionResult Create()
        {
            //vracanje gradova iz baze
            var ViewModel = new PekaraFormViewModel
            {
                Gradovi = _context.Gradovi.ToList()
            };

            return View(ViewModel);
        }

        //cuvanje pekare u bazi
        [Authorize]
        [HttpPost]
        public ActionResult Create(PekaraFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Gradovi = _context.Gradovi.ToList();
                return View("Create", viewModel);
            }

            var pekara = new Pekara
            {
                NazivPekare = viewModel.NazivPekare,
                Adresa = viewModel.Adresa,
                GradId = viewModel.Grad
            };

            _context.Pekare.Add(pekara);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home"); //redirekt (akcija, kontroler)
        }
    }
}