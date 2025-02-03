
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SeguroMelApp.CalculoSeguro.Base
{
    public class Nautico : ApoliceBase
    {

        public string RegistroNaval { get; set; }
        public string TipoEmbarcacao { get; set; }
        public int AnoConstrucao { get; set; }

        public Nautico(string registroNaval, string tipoEmbarcacao, int anoConstrucao)
        {
           RegistroNaval = registroNaval;
           TipoEmbarcacao = tipoEmbarcacao;
           AnoConstrucao = anoConstrucao;
        }

        // data de ano maior que 20 = 15% //menor = 1%
        public override void CalcularSeguro()
        {
            var anoCalculo = DateTime.Now.Year - DataBasica.Year;
            if (anoCalculo >= 20)
            {
                var valorCalculo = ((ValorDoBem * 15) / 100);
                ValorSeguro = valorCalculo;
            }
            else
            {
                var valorCalculo = ((ValorDoBem * 1) / 100);
                ValorSeguro = valorCalculo;
            }
        }


    }
}
