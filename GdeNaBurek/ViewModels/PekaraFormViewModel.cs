using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace GdeNaBurek.ViewModels
{
    public class PekaraFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string NazivPekare { get; set; }

        [Required]
        public string Adresa { get; set; }

        [Required]
        public int Grad { get; set; }

        public IEnumerable Gradovi { get; set; }
    }
}