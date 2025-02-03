
using System.Text.RegularExpressions;

namespace SeguroMelApp.CalculoSeguro.Base
{
    internal class Moto: ApoliceBase
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }



        public Moto(string modelo, string placa, int ano )
        {
            Modelo= modelo;
            Placa= placa;
            Ano= ano;
        }

        public void ExibirContrato()
        {
            base.ExibirContrato();
            Console.WriteLine($"Placa do Carro:{Placa} - Ano: {Ano} - Modelo: {Modelo} ");
        }
    }
}
