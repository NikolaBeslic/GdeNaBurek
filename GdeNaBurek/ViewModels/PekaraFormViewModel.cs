using System.Collections;

namespace GdeNaBurek.ViewModels
{
    public class PekaraFormViewModel
    {
        public int Id { get; set; }
        public string NazivPekare { get; set; }
        public string Adresa { get; set; }
        public int Grad { get; set; }
        public IEnumerable Gradovi { get; set; }
    }
}