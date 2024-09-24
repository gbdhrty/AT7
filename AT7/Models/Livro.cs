using System.ComponentModel.DataAnnotations;

namespace AT7.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }
}
