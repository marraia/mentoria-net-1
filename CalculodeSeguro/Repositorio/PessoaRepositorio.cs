using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class PessoaRepositorio
    {

        protected SqlConnection connection;
        public PessoaRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void Inserir(Pessoa pessoa)
        {
            var sql = "INSERT INTO Pessoa (Nome, Cpf, DataNascimento) VALUES (@Nome, @Cpf, @DataNascimento)";
            var pessoaInserida = connection.ExecuteScalar(sql, new
            {
                pessoa.Genero,
                pessoa.Profissao,
                pessoa.DataDeNascimento
            });
        }

 
        

        public Pessoa SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Pessoa WHERE Id = @Id";

            var pessoa = connection
                            .QuerySingleOrDefault<Pessoa>(sql, new { Id = Id });
            return new Pessoa();
        }
    }
}
