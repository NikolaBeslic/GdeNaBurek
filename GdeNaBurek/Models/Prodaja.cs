namespace GdeNaBurek.Models
{
    public class Prodaja
    {
        public int ProdajaId { get; set; }
        public Burek Burek { get; set; }
        public Pekara Pekara { get; set; }
        public double Cena { get; set; }
        public double Kolicina { get; set; }
    }
}