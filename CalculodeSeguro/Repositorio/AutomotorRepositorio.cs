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
            var sql = "INSERT INTO Automotor (Placa, Modelo, AnoFabricacao, Valor) VALUES (@Marca, @Modelo, @AnoFabricacao, @Valor)";

            var automotorInserido = connection.ExecuteScalar(sql, new
            {
                automotor.Placa,
                automotor.Modelo,
                automotor.Ano,
                automotor.ValorDoBem
            });
        }

        public Automotor SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Automotor WHERE Id = @Id";
            

            var automotor = connection
                            .QuerySingleOrDefault<Automotor>(sql, new { Id = Id });
            return new Automotor();
        }

        public Automotor SelecionarPorPlaca(string placa)
        {
            var sql = "SELECT * FROM Automotor WHERE Placa = @Placa";
            var automotor = connection
                            .QuerySingleOrDefault<Automotor>(sql, new { Placa = placa });
            return new Automotor();
        }

        public void Atualizar(Automotor automotor)
        {
            var sql = "UPDATE Automotor SET Placa = @Placa, Modelo = @Modelo, AnoFabricacao = @AnoFabricacao, Valor = @Valor WHERE Id = @Id";
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
