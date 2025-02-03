

namespace SeguroMelApp.CalculoSeguro.Base
{
    public class Carro: ApoliceBase
    {
        public string Placa {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Kilometragem { get; set; }


        public Carro(string placa, string marca, string modelo, decimal kilometragem)
        {
            Placa=placa;
            Marca=marca;
            Modelo=modelo;
            Kilometragem=kilometragem;
        }

        public void ExibirContrato()
        {
            base.ExibirContrato();
            Console.WriteLine($"Placa do Carro:{Placa} - Marca: {Marca} - Modelo: {Modelo} - Kilometros rodados - {Kilometragem} km ");
        }
    }
}
