

namespace LivrariaMelApp.EstoqueLivros.Base
{
    public abstract class Livro
    {
       
     public string Titulo { get; set; }
     public string Autor { get; set; }
     public string ISBN { get; set; }

     private double preco;
       
      public double Preco
        {
            get { return Preco; }
            private set { Preco =value; }
        }

        public Livro (string titulo, string autor, string isbn, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            this.Preco = preco;
        }

        public void AplicarDesconto(double percentual)
        {
            Preco -= Preco * (percentual/ 100);
        }

        public virtual void ExibirInformacoes()
        {
          Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Preço: {Preco}");
        }

    }
}
