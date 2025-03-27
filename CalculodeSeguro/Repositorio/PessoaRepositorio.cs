using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class PessoaRepositorio
    {
        public void Inserir(Pessoa pessoa)
        {
            var sql = "INSERT INTO Pessoa (Nome, Cpf, DataNascimento) VALUES (@Nome, @Cpf, @DataNascimento)";
        }

        public void Atualizar(Pessoa pessoa)
        {
            var sql = "UPDATE Pessoa SET Nome = @Nome, Cpf = @Cpf, DataNascimento = @DataNascimento WHERE Id = @Id";
        }

        public void Excluir(int Id)
        {
            var sql = "DELETE FROM Pessoa WHERE Id = @Id";
        }

        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Pessoa WHERE Id = @Id";
        }
    }
}
