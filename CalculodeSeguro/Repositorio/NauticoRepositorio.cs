using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class NauticoRepositorio
    {
        public void Inserir(Nautico nautico)
        {
            var sql = "INSERT INTO Nautico (RegistroEmbarcacao, TipoEmbarcacao, Ano) VALUES (@RegistroEmbarcacao, @TipoEmbarcacao, @Ano)";
        }
        public void Atualizar(Nautico nautico)
        {
            var sql = "UPDATE Nautico SET RegistroEmbarcacao = @RegistroEmbarcacao, TipoEmbarcacao = @TipoEmbarcacao, Ano = @Ano WHERE Id = @Id";
        }
        public void Excluir(int Id)
        {
            var sql = "DELETE FROM Nautico WHERE Id = @Id";
        }
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Nautico WHERE Id = @Id";
        }
    }
}
