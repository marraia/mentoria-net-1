using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class PessoaRepositorio
    {
        public void Inserir(Pessoa pessoa)
        {
            var sql = "INSERT INTO Pessoa (Nome, Cpf, DataNascimento) VALUES (@Nome, @Cpf, @DataNascimento)";
        }

 
        

        public Pessoa SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Pessoa WHERE Id = @Id";
            return new Pessoa();
        }
    }
}
