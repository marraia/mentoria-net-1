// See https://aka.ms/new-console-template for more information




using TreinamentoInicial;

int numero1 = 0;
double numero2 = 1.2;
decimal numero3 = 2.0M;
string nome = "Melissa";
bool verdaeiroOuFalso = false;
DateTime data = DateTime.Now;
Guid numeroGuid = Guid.NewGuid();

var xuxu = new Random();
var valorSorteado = xuxu.Next();



var abacaxi = new Pessoa();
abacaxi.Nome = "Melissa";
abacaxi.Sobrenome = "Martins";
abacaxi.CalcularIdade(new DateTime(1995, 10, 09));


var dataNew = new DateTime(1995, 10, 09);
var dataNew2 = DateTime.Parse("1995-10-19");


Console.WriteLine($"Idade da Melissa {abacaxi.Idade}");

//decimal numeroDecimal = 2.8M;
//decimal numeroDecimal2 = 3.866666M;

//decimal resultado = numeroDecimal + numeroDecimal2;

//Console.WriteLine($"O Valor da soma é: {resultado}");


Console.WriteLine("Digite o primeiro valor");
var valor = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
var valor2 = int.Parse(Console.ReadLine());

var valor3 = valor + valor2;

Console.WriteLine($"O Valor da soma é: {valor3}");





