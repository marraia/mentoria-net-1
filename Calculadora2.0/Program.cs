using Calculadora2._0;

float n1 = 0;
float n2 = 0;
bool executado = false;


Console.WriteLine("Calculadora");
Console.WriteLine("--------------------------");
var calculadora = new Calculadora(n1, n2);

do
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Como você quer calcular?");
    Console.WriteLine("Opções: ");
    Console.WriteLine("\ta - Adição");
    Console.WriteLine("\ts - Subtração");
    Console.WriteLine("\tm - Multiplicação");
    Console.WriteLine("\td - Divisão");


    var calcular = Console.ReadLine();
    switch (calcular)
    {
        case "a":
            calculadora.CalcularNumeros();
            calculadora.Somar();
            var soma = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} + {n2} é: {(soma)}");

            executado = calculadora.VerificarParOuImpar();
            break;
        case "s":
            calculadora.CalcularNumeros();
            calculadora.Substrair();
            var subtracao = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} - {n2} é: {(subtracao)}");

            executado = calculadora.VerificarParOuImpar();
            break;
        case "m":
            calculadora.CalcularNumeros();
            calculadora.Multiplicar();
            var multiplicar = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} * {n2} é: {(multiplicar)}");
            executado = calculadora.VerificarParOuImpar();
            break;
        case "d":
            calculadora.CalcularNumeros();
            calculadora.Divisão();
            var dividir = calculadora.Visor;

            Console.WriteLine($"O resultado entre {n1} / {n2} é: {(dividir)} ");
            executado = calculadora.VerificarParOuImpar();
            break;

        default:
            Console.WriteLine("Valor digitado inválido, digite novamente: ");
            break;

    }
}
while (!executado);
