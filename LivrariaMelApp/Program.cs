using LivrariaMelApp.EstoqueLivros.Base;

Console.WriteLine("Melissa Livros");
Console.WriteLine("Opções:");


Console.WriteLine("Digite o Titulo:");
var titulo = Console.ReadLine();
Console.WriteLine("Autor:");
var autor = Console.ReadLine();
Console.WriteLine("isbn");
var isbn = Console.ReadLine();
Console.WriteLine("Preço: ");
var preco = Convert.ToDouble(Console.ReadLine());
var livraria = new Livraria(titulo, autor, isbn, preco);
livraria.ListarLivros();