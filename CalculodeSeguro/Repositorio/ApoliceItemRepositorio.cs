

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

        public ApoliceItem  SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM ApoliceItem WHERE Id = @Id";
            return new ApoliceItem();
        }

      
    }
}
