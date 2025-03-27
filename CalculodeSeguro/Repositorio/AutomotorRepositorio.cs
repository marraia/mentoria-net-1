using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class AutomotorRepositorio
    {
        public void Inserir(Automotor automotor)
        {
            var sql = "INSERT INTO Automotor (Marca, Modelo, AnoFabricacao, Valor) VALUES (@Marca, @Modelo, @AnoFabricacao, @Valor)";
        }

        public void Atualizar(Automotor automotor)
        {
            var sql = "UPDATE Automotor SET Marca = @Marca, Modelo = @Modelo, AnoFabricacao = @AnoFabricacao, Valor = @Valor WHERE Id = @Id";
        }
        public void Excluir(int Id)
        {
            var sql = "DELETE FROM Automotor WHERE Id = @Id";
        }
        public void SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Automotor WHERE Id = @Id";
        }
    }
}
