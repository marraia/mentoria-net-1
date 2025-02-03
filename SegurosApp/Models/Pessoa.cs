

namespace SegurosApp.Models
{
    internal class Pessoa:SeguroBase
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }
    }
}
