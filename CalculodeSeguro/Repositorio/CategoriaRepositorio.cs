using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class CategoriaRepositorio
    {
      public void Inserir(Categoria categoria)
        {
           var sql = "INSERT INTO Categoria (NomeCategoria) VALUES (@NomeCategoria)";
        }

       public void Atualizar(Categoria categoria)
        {
            var sql = "UPDATE Categoria SET NomeCategoria = @NomeCategoria WHERE Id = @Id";
        }
        public void Excluir(int Id)
        {
            var sql = "DELETE FROM Categoria WHERE Id = @Id";
        }
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Categoria WHERE Id = @Id";
        }
    }
}
