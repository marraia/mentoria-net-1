using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class CategoriaRepositorio
    {
     public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Categoria WHERE Id = @Id";
        }
    }
}
