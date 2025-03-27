using System.Reflection;

namespace CalculodeSeguro.Repositorio
{
    public class MoveisRepositorio
    {

        public void Inserir(MoveisRepositorio moveis)
        {
            var sql = "INSERT INTO Moveis (MarcaDoAparelho,Modelo,AnoDoModelo,IMEI,TipodeCobertura,ValorDoBem) VALUES (@MarcaDoAparelho, @Modelo,AnoDoModelo, @IMEI, @TipodeCobertura, @ValorDoBem)";
        }

        public void Atualizar(MoveisRepositorio moveis)
        {
            var sql = "UPDATE Moveis SET MarcaDoAparelho = @MarcaDoAparelho, Modelo = @Modelo, AnoDoModelo = @AnoDoModelo, IMEI = @IMEI, TipodeCobertura = @TipodeCobertura, ValorDoBem = @ValorDoBem WHERE Id = @Id";
        }

        public void Excluir(int Id)
        {
            var sql = "DELETE FROM Moveis WHERE Id = @Id";
        }

        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Moveis WHERE Id = @Id";
        }
    }
}
