using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObj.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        private int Idade {  get; set; }

       

        //constructor para iniciar nome e idade
         public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}");
        }
    }
}
