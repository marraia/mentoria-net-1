﻿using System.Linq.Expressions;
using TreinamentoInicial;

/*int numero1 = 0;
double numero2 = 1.2; //numeros reais
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


Console.WriteLine($"Idade da Melissa {abacaxi.Idade}");*/

//decimal numeroDecimal = 2.8M;
//decimal numeroDecimal2 = 3.866666M;

//decimal resultado = numeroDecimal + numeroDecimal2;

//Console.WriteLine($"O Valor da soma é: {resultado}");


/*Console.WriteLine("Digite o primeiro valor");
var valor = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
var valor2 = int.Parse(Console.ReadLine());

var valor3 = valor + valor2;

Console.WriteLine($"O Valor da soma é: {valor3}");


Console.WriteLine("Digite o 1º valor:");
var v1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2 número: ");
var v2 = double.Parse(Console.ReadLine());

var total = v1 -v2;

Console.WriteLine($"Voce tem {total} Restantes...");*/


/*Console.WriteLine("Boletim 2024");
Console.WriteLine("--------------------------");
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua 1º nota: ");
//var nota1 = double.Parse(Console.ReadLine());
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;
media = Math.Round(media);

Console.WriteLine($"Sua média total nesse boletim ,{nome} é de : {media}");
Console.WriteLine("Aperte qualquer tecla para sair");*/

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


    var calcular = Console.ReadLine();

    switch (calcular)
    {
        case "a":
            Console.WriteLine($"O resultado entre {n1} + {n2} é: " + (n1+n2));
            executado = true;
            break;
        case "s":
            Console.WriteLine($"O resultado entre {n1} - {n2} é: " + (n1-n2));
            executado = true;
            break;
        case "m":
            Console.WriteLine($"O resultado entre {n1} x {n2} é: " + (n1*n2));
            executado = true;
            break;
        case "d":
            while (n2 == 0)
            {
                Console.WriteLine("Entre com um número maior que 0 :");
                n2 = Convert.ToSingle(Console.ReadLine()); //esse trecho de código garante que n2 não seja zero antes de realizar a divisão, evitando um erro de divisão por zero.
            }
            Console.WriteLine($"O resultado entre {n1} : {n2} é: " + (n1/n2));
            executado = true;
            break;
        default:
            Console.WriteLine("Valor digitado inválido, digite novamente: ");
            break;

    }
}
while (!executado);




