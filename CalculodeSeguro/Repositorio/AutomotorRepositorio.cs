using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class AutomotorRepositorio
    {
        public void Inserir(Automotor automotor)
        {
            var sql = "INSERT INTO Automotor (Marca, Modelo, AnoFabricacao, Valor) VALUES (@Marca, @Modelo, @AnoFabricacao, @Valor)";
        }

        public Automotor SelecionarPorId(int Id)
        {
            var sql = "SELECT * FROM Automotor WHERE Id = @Id";
            return new Automotor();
        }

        public Automotor SelecionarPorPlaca(string placa)
        {
            var sql = "SELECT * FROM Automotor WHERE Placa = @Placa";
            return new Automotor();
        }
    }
}
