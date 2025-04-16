using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class ApoliceRepositorio
    {
        protected SqlConnection connection;
        public ApoliceRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public Apolice SelecionarPorNumeroDaApolice(string numeroApolice)
        {
            var sql = "SELECT * FROM Apolice WHERE NumeroApolice = @NumeroApolice";

            var apolice = connection
                            .QuerySingleOrDefault<Apolice>(sql, new { NumeroApolice = numeroApolice });
            return apolice;
        }

        public void Inserir(Apolice apolice)
        {
            var sql = "INSERT INTO Apolice (NumeroApolice, ClienteId) VALUES (@NumeroApolice, @ClienteId)";
            var apoliceInserida = connection.ExecuteScalar(sql, new
            {
                apolice.NumeroApolice,
                apolice.ClienteId
            });
        }

        public void Atualizar(Apolice apolice)
        {
            var sql = "UPDATE Apolice SET DataInicio = @DataInicio, DataFim = @DataFim WHERE numeroApolice = @NumeroApolice";
            var apoliceAtualizada = connection.Execute(sql, new
            {
                apolice.DataInicio,
                apolice.DataFim,
                apolice.NumeroApolice
            });
        }

       
        public void Deletar(Apolice apolice)
        {
            var sql = "DELETE FROM Apolice WHERE Id = @Id";
            var apoliceDeletada = connection.Execute(sql, new { Id = apolice.Id });
        }

    }
}
