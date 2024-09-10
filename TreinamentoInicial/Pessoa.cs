using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoInicial
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public void CalcularIdade(DateTime dataAniversario)
        {
            Idade = DateTime.Now.Year - dataAniversario.Year;
        }
    }
}
