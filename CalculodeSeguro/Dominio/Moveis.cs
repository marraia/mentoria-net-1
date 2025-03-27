

namespace CalculodeSeguro.Dominio
{
    public class Moveis
    {
        public int Id { get; private set; }
        public string MarcaDoAparelho { get; private set; }
        public string Modelo { get; private set; }
        public int AnoDoModelo { get; private set; }
        public string IMEI { get; private set; }
        public string TipodeCobertura { get; private set; }
        public decimal ValorDoBem { get; private set; }


        public Moveis(string marcaDoAparelho, string modelo, int anoDoModelo, string iMEI, string tipodeCobertura, decimal valorDoBem)
        {
            MarcaDoAparelho = marcaDoAparelho;
            Modelo = modelo;
            AnoDoModelo = anoDoModelo;
            IMEI = iMEI;
            TipodeCobertura = tipodeCobertura;
            ValorDoBem = valorDoBem;
        }

        public void AtualizarId(int id)
        {
            Id = id;
        }
    }
}
