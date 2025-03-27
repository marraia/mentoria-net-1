
namespace CalculodeSeguro.Dominio
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string NomeCategoria { get; private set; }


        public Categoria(string nomeCategoria)
        {
            NomeCategoria = nomeCategoria;
        }

        public void AtualizarId(int id)
        {
            Id = id;
        }


    }
}
