using Calculadora2._0;

bool executado = false;


Console.WriteLine("Calculadora");
Console.WriteLine("--------------------------");
Console.WriteLine("Digite o 1º número: ");
var n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2º número: ");
var n2 = float.Parse(Console.ReadLine());
do
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Como você quer calcular?");
    Console.WriteLine("Opções: ");
    Console.WriteLine("\ta - Adição");
    Console.WriteLine("\ts - Subtração");
    Console.WriteLine("\tm - Multiplicação");
    Console.WriteLine("\td - Divisão");

    var calculadora = new Calculadora(n1, n2);

    var calcular = Console.ReadLine();

    switch (calcular)
    {
        case "a":
            calculadora.Somar();
            var soma = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} + {n2} é: {(soma)}");

            executado = calculadora.VerificarParOuImpar();
            break;
        case "s":
            calculadora.Substrair();
            var subracao = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} + {n2} é: {(subracao)}");

            executado = calculadora.VerificarParOuImpar();
            break;
        default:
            Console.WriteLine("Valor digitado inválido, digite novamente: ");
            break;

    }
}
while (!executado);
