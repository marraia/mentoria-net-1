using System.Reflection;

namespace CalculodeSeguro.Repositorio
{
    public class MoveisRepositorio
    {

        public void Inserir(MoveisRepositorio moveis)
        {
            var sql = "INSERT INTO Moveis (MarcaDoAparelho,Modelo,AnoDoModelo,IMEI,TipodeCobertura,ValorDoBem) VALUES (@MarcaDoAparelho, @Modelo,AnoDoModelo, @IMEI, @TipodeCobertura, @ValorDoBem)";
        }
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Moveis WHERE Id = @Id";
        }
    }
}
