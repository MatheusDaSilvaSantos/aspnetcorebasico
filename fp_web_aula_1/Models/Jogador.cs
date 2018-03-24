using System;

namespace fp_web_aula_1.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public int Camisa { get; set; }
    }
}
