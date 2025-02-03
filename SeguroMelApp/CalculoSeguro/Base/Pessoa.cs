
namespace SeguroMelApp.CalculoSeguro.Base
{
    public class Pessoa : ApoliceBase
    {
        public string Sexo { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string sexo, string profissao)
        {
            Sexo = sexo;
            Profissao = profissao;
            ValorDoBem = 100000;
        }

        public override void CalcularSeguro()
        {
            var anoCalculo = DateTime.Now.Year - DataBasica.Year;
            if (anoCalculo <= 18)
            {
                var valorCalculo = ((ValorDoBem * 1) / 100);
                ValorSeguro = valorCalculo;
            }
            else
            {
                var valorCalculo = ((ValorDoBem * 3) / 100);
                ValorSeguro = valorCalculo;
            }
        }

    }
}
