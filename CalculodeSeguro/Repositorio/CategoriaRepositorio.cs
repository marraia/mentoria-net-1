using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class CategoriaRepositorio
    {
     public Categoria SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Categoria WHERE Id = @Id";
            return new Categoria(sql);
        }
    }
}
