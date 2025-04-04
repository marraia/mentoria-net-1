using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class ApoliceRepositorio
    {
        public void Inserir(Apolice apolice)
        {
            var sql = "INSERT INTO Apolice (NumeroApolice, ClienteId) VALUES (@NumeroApolice, @ClienteId)";
        }

        public void Atualizar(Apolice apolice)
        {
            var sql = "UPDATE Apolice SET DataInicio = @DataInicio, DataFim = @DataFim WHERE numeroApolice = @NumeroApolice";
        }

        public Apolice SelecionarPorNumeroDaApolice(string numeroApolice)
        {
            var sql = "SELECT * FROM Apolice WHERE NumeroApolice = @NumeroApolice";
            return new Apolice();
        }

    }
}
