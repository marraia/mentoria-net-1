using BenchmarkDotNet.Attributes;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
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
/*
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
 */



//Calculadora
/*bool executado = false;


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
            var soma = n1+n2;
            for (var i =0; i <= soma; i++)
            {
                if(i % 2 == 0 )
                {
                    Console.WriteLine($"O numero {i} é par");
                }else
                {
                    Console.WriteLine($"O numero {i} é Impar");
                }
            }
            executado = true;
                break;
        case "s":
            Console.WriteLine($"O resultado entre {n1} - {n2} é: " + (n1-n2));
            var subtraçao = n1-n2;
            for (var i = 0; i <= subtraçao; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"O numero {i} é par");
                }
                else
                {
                    Console.WriteLine($"O numero {i} é Impar");
                }
            }
            executado = true;
            break;
        case "m":
            Console.WriteLine($"O resultado entre {n1} x {n2} é: " + (n1*n2));
            var multiplicaçao = n1*n2;
            for (var i = 0; i <= multiplicaçao; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"O numero {i} é par");
                }
                else
                {
                    Console.WriteLine($"O numero {i} é Impar");
                }
            }
            executado = true;
            break;
        case "d":
            while (n2 == 0)
            {
                Console.WriteLine("Entre com um número maior que 0 :");
                n2 = Convert.ToSingle(Console.ReadLine()); //esse trecho de código garante que n2 não seja zero antes de realizar a divisão, evitando um erro de divisão por zero.
            }
            Console.WriteLine($"O resultado entre {n1} : {n2} é: " + (n1/n2));
            var divisao = n1/n2;
            for (var i = 0; i <= divisao; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"O numero {i} é par");
                }
                else
                {
                    Console.WriteLine($"O numero {i} é Impar");
                }
            }
            executado = true;
            break;
        default:
            Console.WriteLine("Valor digitado inválido, digite novamente: ");
            break;

    }
}
while (!executado);*/


//For e Foreach
/*var nomes = new List<string>();
nomes.Add("Fernando"); //0
nomes.Add("Melissa"); //1
nomes.Add("DotNet"); //2


foreach (var item in nomes)
{
    Console.WriteLine($"Nome: {item}");
}

for (var index = 0; index < nomes.Count; index++)
{
    var nomePessoa = nomes[index];
    Console.WriteLine($"Nomes {nomePessoa}");
}

for (var index = 0; index <= 100; index++)
{
    Console.WriteLine($"Valor do index {index}");
}

var index1 = 0;
do
{
    index1++;
    Console.WriteLine($"Valor do index1 {index1}");
} while (index1 < 100);

var index2 = 0;

while (index2 < 100)
{
    index2++;
    Console.WriteLine($"Valor do index2 {index2}");
}
*/

//par ou ímpar
/*
Console.Write("Digite qualquer valor: ");
var valor = Convert.ToInt32(Console.ReadLine());

for(var i = 0; i <= valor; i++)
{
    if(i % 2==0)
    {
        Console.WriteLine($"{i}É par");
    }else
    {
        Console.WriteLine($"{i}É ímpar");
    }
}


int[] arrai= {1,3,4,5,7,7,8,6,7,0,9,5,5,33,2,1,};


Console.WriteLine("Qual número que voce quer contar?");
var numero = Convert.ToInt32(Console.ReadLine());
var qtdN = 0;
foreach(var valor in arrai)
{
    if(valor == numero)
    {
        qtdN++;
    }
    Console.Write(valor);
}
Console.WriteLine($"O valor {numero} foi encontrado {qtdN} vezes no Array.");*/

int[] listaDeNumeros = { 10,5,6,3,22,88,9 };
var numeroMaior = listaDeNumeros[0];//ele inicia a variavel com o valor na posição 0
var numeroMenor = listaDeNumeros[0];
foreach (var lista in listaDeNumeros)
{
    if (lista > numeroMaior)
    {
        numeroMaior = lista;
    }
    
    if(lista < numeroMenor)
    {
        numeroMenor = lista;
    }
}
Console.WriteLine($"O numero maioe é : {numeroMaior} e o numero menor  é : {numeroMenor}");