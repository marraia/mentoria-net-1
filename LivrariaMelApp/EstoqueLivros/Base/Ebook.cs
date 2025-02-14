

namespace LivrariaMelApp.EstoqueLivros.Base
{
    public class Ebook: Livro
    {
        public double TamanhoArquivo {  get; set; }
        public Ebook(string titulo, string autor, string isbn, double preco, double tamanhoArquivo)
        :base (titulo, autor, isbn, preco)
        {
          TamanhoArquivo = tamanhoArquivo;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Tamanho do Arquivo: {TamanhoArquivo} MB");
        }
    }
}
