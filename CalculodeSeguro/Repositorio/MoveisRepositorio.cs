using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class MoveisRepositorio
    {

        protected SqlConnection connection;
        public MoveisRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Inserir(Moveis moveis)
        {
            var sql = "INSERT INTO Moveis (MarcaDoAparelho,Modelo,AnoDoModelo,IMEI,TipodeCobertura,ValorDoBem) VALUES (@MarcaDoAparelho, @Modelo,AnoDoModelo, @IMEI, @TipodeCobertura, @ValorDoBem)";

            var moveisInserido = connection.ExecuteScalar(sql, new
            {
                moveis.MarcaDoAparelho,
                moveis.Modelo,
                moveis.AnoDoModelo,
                moveis.IMEI,
                moveis.TipodeCobertura,
                moveis.ValorDoBem
            });
        }
        public Moveis SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Moveis WHERE Id = @Id";
            var moveis = connection
                            .QuerySingleOrDefault<Moveis>(sql, new { Id = Id });
            return new Moveis();
        }

       
    }
}
