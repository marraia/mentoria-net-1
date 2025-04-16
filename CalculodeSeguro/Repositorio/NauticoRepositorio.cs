using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class NauticoRepositorio
    {

        protected SqlConnection connection;
        public NauticoRepositorio()
        { 
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Inserir(Nautico nautico)
        {
         
            var sql = "INSERT INTO Nautico (RegistroEmbarcacao, TipoEmbarcacao, Ano) VALUES (@RegistroEmbarcacao, @TipoEmbarcacao, @Ano)";

            var nauticoInserido = connection.ExecuteScalar(sql, new
            {
                nautico.RegistroEmbarcacao,
                nautico.TipoEmbarcacao,
                nautico.Ano
            });
        }
      
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Nautico WHERE Id = @Id";

            var nautico = connection
                            .QuerySingleOrDefault<Nautico>(sql, new { Id = Id });
        }

        public Nautico SelecionarPorRegistroEmbarcacao(string registroEmbarcacao)
        {
            var sql = "SELECT * FROM Nautico WHERE RegistroEmbarcacao = @RegistroEmbarcacao";

            var nautico = connection
                            .QuerySingleOrDefault<Nautico>(sql, new { RegistroEmbarcacao = registroEmbarcacao });
            return new Nautico();
        }
    }
}
