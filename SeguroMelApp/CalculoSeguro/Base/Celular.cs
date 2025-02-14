using SeguroMelApp.CalculoSeguro.Interface;

namespace SeguroMelApp.CalculoSeguro.Base
{
    public class Celular :ApoliceBase, Iseguro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }


        public Celular(string marca, string modelo, int ano)
        {
            Marca=marca;
            Modelo=modelo;
            Ano=ano;
        }

        public void ExibirSeguro()
        {
            Console.WriteLine(" Seguro de celular confirmado!");
        }
    }
}
