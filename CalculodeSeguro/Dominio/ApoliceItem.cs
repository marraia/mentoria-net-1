namespace CalculodeSeguro.Dominio
{
    public class ApoliceItem
    {
        public int Id { get; private set; }
        public string ApoliceId { get; private set; }
        public int CategoriaId { get; private set; }
        public int EspecialidadeId { get; private set; }
        public decimal ValorSeguro { get; private set; }

        public ApoliceItem(string apoliceId, int categoriaId)
        {
            ApoliceId = apoliceId;
            CategoriaId = categoriaId;
            
        }

        public ApoliceItem()
        {
        }

        public void AtualizarId(string id)
        {
            Id = id;
        }

        public void AtualizarEspecialidade(int especialidadeId)
        {
            EspecialidadeId = especialidadeId;
        }

        public void CalcularSeguro(decimal valorSeguro)
        {
            ValorSeguro = valorSeguro;
        }
    }
}
