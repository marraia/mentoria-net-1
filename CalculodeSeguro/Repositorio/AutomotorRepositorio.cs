using CalculodeSeguro.Dominio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CalculodeSeguro.Repositorio
{
    public class AutomotorRepositorio
    {
        protected SqlConnection connection;
        public AutomotorRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Inserir(Automotor automotor)
        {
            var sql = "INSERT INTO AutomovelAutomotor (Placa, Modelo, Ano, Chassi, ValorDoBem) VALUES (@Placa, @Modelo, @Ano, @Chassi, @ValorDoBem)";

            var automotorInserido = connection.ExecuteScalar(sql, new
            {
                automotor.Placa,
                automotor.Modelo,
                automotor.Ano,
                automotor.Chassi,
                automotor.ValorDoBem
            });
        }

        public Automotor SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM AutomovelAutomotor WHERE Id = @Id";
            

            var automotor = connection
                            .QuerySingleOrDefault<Automotor>(sql, new { Id = Id });
            return automotor;
        }

        public Automotor SelecionarPorPlaca(string placa)
        {
            var sql = "SELECT * FROM AutomovelAutomotor WHERE Placa = @Placa";
            var automotor = connection
                            .QuerySingleOrDefault<Automotor>(sql, new { Placa = placa });
            return new Automotor();
        }

        public void Atualizar(Automotor automotor)
        {
            var sql = "UPDATE AutomovelAutomotor SET Placa = @Placa, Modelo = @Modelo, AnoFabricacao = @AnoFabricacao, Valor = @Valor WHERE Id = @Id";
            var automotorAtualizado = connection.Execute(sql, new
            {
                automotor.Placa,
                automotor.Modelo,
                automotor.Ano,
                automotor.ValorDoBem,
                automotor.Id
            });
        }

        public void Deletar(Automotor automotor)
        {
            var sql = "DELETE FROM Automotor WHERE Id = @Id";
            var automotorDeletado = connection.Execute(sql, new { Id = automotor.Id });
        }
    }
}
