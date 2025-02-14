namespace LivrariaMelApp.EstoqueLivros.Base
{
    public class Livraria
    {
         private List <Livro> livros;
        public Livraria(string titulo, string autor, string isbn, double preco)
        {
            this.
            livros = new List <Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            foreach (var livro in livros)
            {
                livro.ExibirInformacoes();
                Console.WriteLine();
            }
        }

        public Livro BuscarLivroPorTitulo(string titulo)
        {
            return livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}
