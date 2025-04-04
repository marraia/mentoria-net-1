using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class NauticoRepositorio
    {
        public void Inserir(Nautico nautico)
        {
            var sql = "INSERT INTO Nautico (RegistroEmbarcacao, TipoEmbarcacao, Ano) VALUES (@RegistroEmbarcacao, @TipoEmbarcacao, @Ano)";
        }
      
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Nautico WHERE Id = @Id";
        }
    }
}
