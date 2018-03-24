using System.ComponentModel.DataAnnotations;

namespace fp_web_aula_1.Models
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public int EnderecoDeEmail { get; set; }
        public string Bandeira { get; set; }
        public bool Publicado { get; set; }
    }
}
