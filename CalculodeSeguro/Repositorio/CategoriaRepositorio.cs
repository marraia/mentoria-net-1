using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;


namespace CalculodeSeguro.Repositorio
{
    public class CategoriaRepositorio
    {
        protected SqlConnection connection;
        public CategoriaRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public Categoria SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Categoria WHERE Id = @Id";
            return new Categoria(sql);
        }
    }
}
