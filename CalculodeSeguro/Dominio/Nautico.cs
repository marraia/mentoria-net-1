
namespace CalculodeSeguro.Dominio
{
    public class Nautico
    {
        public int Id { get; private set; }
        public string RegistroEmbarcacao { get; private set; }
        public string TipoEmbarcacao { get; private set; }
        public int Ano { get; private set; }


        public Nautico(string registroEmbarcacao, string tipoEmbarcacao, int ano)
        {
            RegistroEmbarcacao = registroEmbarcacao;
            TipoEmbarcacao = tipoEmbarcacao;
            Ano = ano;
        }

        public void AtualizarId(int id)
        {
            Id = id;
        }
    }
}
