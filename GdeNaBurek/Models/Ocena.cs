namespace GdeNaBurek.Models
{
    public class Ocena
    {
        public int Id { get; set; }
        public Burek Burek { get; set; }
        public int OcenaVrednost { get; set; }

    }
}