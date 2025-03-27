

using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class ApoliceItemRepositorio
    {
        public void Inserir(ApoliceItem apoliceItem)
        {
            var sql = "INSERT INTO ApoliceItem (ApoliceId, CategoriaId) VALUES (@ApoliceId, @CategoriaId)";
        }

        public void Atualizar(ApoliceItem apoliceItem)
        {
            var sql = "UPDATE ApoliceItem SET EspecialidadeId = @EspecialidadeId, ValorSeguro = @ValorSeguro WHERE Id = @Id";
        }

        public void Excluir(int Id)
        {
            var sql = "DELETE FROM ApoliceItem WHERE Id = @Id";
        }

        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM ApoliceItem WHERE Id = @Id";
        }
    }
}
