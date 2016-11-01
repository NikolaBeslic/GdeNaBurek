using System.ComponentModel.DataAnnotations;

namespace GdeNaBurek.Models
{
    public class Pekara
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NazivPekare { get; set; }
        public string Adresa { get; set; }
        public Grad Grad { get; set; }
    }
}