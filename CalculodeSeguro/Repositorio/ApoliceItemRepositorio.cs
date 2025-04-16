

using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class ApoliceItemRepositorio
    {

        protected SqlConnection connection;
        public ApoliceItemRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void Inserir(ApoliceItem apoliceItem)
        {
            var sql = "INSERT INTO ApoliceItem (ApoliceId, CategoriaId) VALUES (@ApoliceId, @CategoriaId)";

            var apoliceItemInserido = connection.ExecuteScalar(sql, new
            {
                apoliceItem.ApoliceId,
                apoliceItem.CategoriaId
            });
        }

        public void Atualizar(ApoliceItem apoliceItem)
        {
            var sql = "UPDATE ApoliceItem SET EspecialidadeId = @EspecialidadeId, ValorSeguro = @ValorSeguro WHERE Id = @Id";

            var apoliceItemAtualizado = connection.Execute(sql, new
            {
                apoliceItem.EspecialidadeId,
                apoliceItem.ValorSeguro,
                apoliceItem.Id
            });
        }

        public ApoliceItem  SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM ApoliceItem WHERE Id = @Id";
            var apoliceItem = connection
                            .QuerySingleOrDefault<ApoliceItem>(sql, new { Id = Id });
            return apoliceItem;
        }

        public void Deletar(ApoliceItem apoliceItem)
        {
            var sql = "DELETE FROM ApoliceItem WHERE Id = @Id";
            var apoliceItemDeletado = connection.Execute(sql, new { Id = apoliceItem.Id });
        }

    }
}
