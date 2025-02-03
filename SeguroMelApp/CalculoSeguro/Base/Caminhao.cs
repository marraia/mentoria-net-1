
namespace SeguroMelApp.CalculoSeguro.Base
{
    public class Caminhao : ApoliceBase
    {
        public string GeneroDoMotorista {  get; set; }
        public string Itinerario { get; set; }
        public string TipoDeCarga { get; set; }

        public Caminhao(string generoDoMotorista, string itinerario, string tipoDeCarga)
        {
            GeneroDoMotorista = generoDoMotorista;
            Itinerario = itinerario;
            TipoDeCarga = tipoDeCarga;
        }


        public override void CalcularSeguro()
        {
           var genero = GeneroDoMotorista.ToString();
            if (genero == "Masculino")
            {
                var valorCalculo = ((ValorDoBem * 12) / 100);
                ValorSeguro = valorCalculo;
            }
            else
            {
                var valorCalculo = ((ValorDoBem * 10) / 100);
                ValorSeguro = valorCalculo;
            }
        }

       


    }
}
