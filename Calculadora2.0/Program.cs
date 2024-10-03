﻿using Calculadora2._0;

bool executado = false;

Console.WriteLine("Calculadora da Melissa");
Console.WriteLine("--------------------------");
var calculadora = new Calculadora();

do
{
    Console.WriteLine("Digite o 1º número: ");
    var a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o 2º número: ");
    var b = float.Parse(Console.ReadLine());

    calculadora.SetarValores(a, b);

    Console.WriteLine("---------------------------");
    Console.WriteLine("Como você quer calcular?");
    Console.WriteLine("Opções: ");
    Console.WriteLine("\ta - Adição");
    Console.WriteLine("\ts - Subtração");
    Console.WriteLine("\tm - Multiplicação");
    Console.WriteLine("\td - Divisão");
    Console.WriteLine("\th - Historico de operaçoes");
    Console.WriteLine("\tf - Finalizar");

    var calcular = Console.ReadLine();
    switch (calcular)
    {
        case "a":
            calculadora.Somar();
            var soma = calculadora.Visor;

            Console.WriteLine($"O resultado é: {soma}");
            break;
        case "s":
            calculadora.Subtrair();
            var subtracao = calculadora.Visor;

            Console.WriteLine($"O resultado é: {subtracao}");
            break;
        case "m":
            calculadora.Multiplicar();
            var multiplicar = calculadora.Visor;

            Console.WriteLine($"O resultado é: {multiplicar}");
            break;
        case "d":
            calculadora.Divisao();
            var dividir = calculadora.Visor;

            Console.WriteLine($"O resultado é: {dividir}");
            break;
        case "h":
            var historico = $"======= HISTORICO => {DateTime.Now} ====== \n";
            historico += calculadora.ExibirHistorico();

            Console.WriteLine(historico);
            break;
        case "f":
            Console.WriteLine("Obrigado por usar a minha calculadora!");
            executado = true;
            break;
        default:
            Console.WriteLine("Valor digitado inválido, digite novamente: ");
            break;
    }
}
while (!executado);

