
using System.Drawing;

namespace SeguroMelApp.CalculoSeguro.Base
{
    public abstract class ApoliceBase
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal ValorDoBem { get; set; }
        public DateTime DataBasica { get; set; }
       

        public virtual void CalcularSeguro()
        {
            var anoCalculo = DateTime.Now.Year - DataBasica.Year;
            if (anoCalculo >= 10)
            {
                var valorCalculo = ((ValorDoBem * 10) / 100);
                ValorSeguro = valorCalculo;   
            }
            else
            {
                var valorCalculo = ((ValorDoBem * 25) / 100);
                ValorSeguro = valorCalculo;
            }
        }

        public void InformarDadosDaApolice(string nome, decimal valorDoBem, DateTime? dataBasica = null)
        {
            Nome = nome;
            ValorDoBem = valorDoBem;
            if (dataBasica != null) 
            {
                DataBasica = dataBasica.Value;
            }
            
        }



        public void Contratar()
        {
            DataInicio = DateTime.Now;
            DataTermino = DateTime.Now.AddYears(1);
        }

       public void ExibirValor( )
        {
            Console.WriteLine($"Valor  do seguro : {ValorSeguro}");
        }


    }

}
