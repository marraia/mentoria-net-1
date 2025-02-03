
namespace SegurosApp.Models
{
    public class Carro: SeguroBase
    {
        public string Placa {  get; set; }
        public string Modelo { get; set; }
        public int Ano {  get; set; }
        public string Cor {  get; set; }

        public Carro(string placa, string modelo, int ano, string cor)
        {
            Placa=placa;
            Modelo=modelo;
            Ano=ano;
            Cor=cor;
        }

        public void InformarDadosBasicos()
        {

        }
        public void ExibirNome()  
        {
            base.ExibirNome();
                Console.WriteLine($"Placa : {Placa}, Modelo : {Modelo}, Ano : {Ano}, Cor : {Cor}");
        }
    }
}
