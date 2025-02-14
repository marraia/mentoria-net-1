
using SeguroMelApp.CalculoSeguro.Base;
using SeguroMelApp.CalculoSeguro.Interface;

namespace SeguroMelApp.CalculoSeguro
{
    internal class Joias:ApoliceBase, Iseguro
    {
        public string CertificadoAutenticidade {  get; set; }





        public Joias(string certificadoAutenticidade)
        {
          CertificadoAutenticidade = certificadoAutenticidade;
        }

        public void ExibirSeguro()
        {
            Console.WriteLine("SEguro de joias Comfirmado");
        }
    }
}
