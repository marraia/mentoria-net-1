using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SegurosApp.Models
{
    internal class Moto : SeguroBase
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Cilindradas { get; set; }


        public Moto(string placa, string modelo, int ano, int cilindradas) 
        { 
            Placa=placa;
            Modelo=modelo;
            Ano=ano;
            Cilindradas=cilindradas;
        }
        public void MotoInfo()
        {
            Console.WriteLine($"Placa : {Placa}, Modelo : {Modelo}, Ano : {Ano}, Cilindradas : {Cilindradas}");
        }
}

   
}
