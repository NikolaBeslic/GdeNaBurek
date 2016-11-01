using System.ComponentModel.DataAnnotations;

namespace GdeNaBurek.Models
{
    public class Grad
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NazivGrada { get; set; }
    }
}