namespace LivrariaMelApp.EstoqueLivros.Base
{
    public class LivroFisico: Livro
    {
      public double Peso {  get; set; }
        public int Paginas { get; set; }

        public LivroFisico(string titulo,string autor,string isbn, double preco, double peso, int paginas)
          : base(titulo, autor, isbn, preco)
        {
            Peso = peso;
            Paginas = paginas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Peso : {Peso}, Páginas: {Paginas}");
        }
    }
}
