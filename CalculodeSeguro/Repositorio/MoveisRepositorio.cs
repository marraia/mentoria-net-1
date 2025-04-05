using CalculodeSeguro.Dominio;
using System.Reflection;

namespace CalculodeSeguro.Repositorio
{
    public class MoveisRepositorio
    {

        public void Inserir(Moveis moveis)
        {
            var sql = "INSERT INTO Moveis (MarcaDoAparelho,Modelo,AnoDoModelo,IMEI,TipodeCobertura,ValorDoBem) VALUES (@MarcaDoAparelho, @Modelo,AnoDoModelo, @IMEI, @TipodeCobertura, @ValorDoBem)";
        }
        public Moveis SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Moveis WHERE Id = @Id";
            return new Moveis();
        }

       
    }
}
