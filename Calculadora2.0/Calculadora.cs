using Microsoft.VisualBasic;
using static Calculadora2._0.Calculadora;

using System;
using System.Collections.Generic;

namespace Calculadora2._0
{
    //Classe criada para mostrar o historico das operações
    public class Historico
    {
        //propriedades da classe Historico
        public DateTime Data { get; set; }
        public string Operacao { get; set; }
        public string Valores { get; set; }
        public float Resultado { get; set; }

        public string ToString()
        {

            return $"{Data.ToString("yy-MM-dd")}, {Operacao} = {Resultado}, {Valores}";
        }
        //Data.ToString("yy-MM-dd") é para retornar a data do dia atual em formato de texto (string)
    }

    // Classe para fazer as operações
    public class Calculadora
    {

        public Calculadora(float a, float b)
        {
            A = a;
            B = b;

            historicoList = new List<Historico>();

        }

        //propriedades da classe Calculadora
        public float A { get; set; }
        public float B { get; set; }
        public float Visor { get; set; }
        public List<Historico> historicoList { get; set; }
        //Propriedades da classe

        //Metodos da classe
        public void Somar()
        {

            Visor = A + B;
            AdicionarAoHistorico("Soma", $"{A} + {B}", Visor); //metodo

        }

        public void Subtrair()
        {
            if (A < B)
            {

                var posicao = A;
                A = B;
                B = posicao;

            }

            Visor = A - B;
            AdicionarAoHistorico("Subtração", $"{A} - {B}", Visor);

        }

        public void Multiplicar()
        {
            Visor = A * B;
            AdicionarAoHistorico("Multiplicação", $"{A} x {B}", Visor);

        }

        public void Divisão()

        {
            if (A == 0)
            {

                Console.WriteLine("Não é possivel dividir com 0");

            }
            else
            {


                Visor = (float)A / (float)B;
                AdicionarAoHistorico("Divisao", $"{A} / {B}", Visor);



            }
        }

        public void CalcularNumeros()
        {
            Console.WriteLine("Digite o 1º número: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            B = float.Parse(Console.ReadLine());
        }

        public void AdicionarAoHistorico(string operacao, string valores, float resultado)
        {
            Historico historico = new Historico
            {
                Data = DateTime.Now,
                Operacao = operacao,
                Valores = valores,
                Resultado = resultado
            };

            historicoList.Add(historico);
            ExibirHistorico();

        }

        public void ExibirHistorico() //metodo para chamar e imprimir o historico na tela
        {
            Console.WriteLine("Histórico de operações: ");
            foreach (var item in historicoList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //Metodos da classe


    }
}
















































/*namespace Calculadora2._0
{
    public class Calculadora
    {
        public Calculadora(float a, float b)
        {
            A = a;
            B = b;
        }

        //PROPRIEDADES DA CLASSE
        public float A { get; set; }
        public float B { get; set; }
        public float Visor { get; set; }
        //PROPRIEDADES DA CLASSE


        //METODOS DA CLASSE
        public void Somar()
        {
            Visor = A + B;
        }

        public void Substrair()
        {
            if (A < B)
            {
                var posicao = A;
                A = B;
                B = posicao;
            }

            Visor = A - B;
        }

        public void Multiplicar()
        {
            Visor = A * B;
        }

        public void Divisão()
        {
            if (A == 0)
            {
                Console.WriteLine("Não é possível dividir com 0");
            }
            else
            {
                Visor = (float)A / (float)B;
            }
        }

        public bool VerificarParOuImpar()
        {
            try
            {
                for (var i = 0; i <= Visor; i++)
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

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void CalcularNumeros()
        {
            Console.WriteLine("Digite o 1º número: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            B = float.Parse(Console.ReadLine());
        }


        //METODOS DA CLASSE
    }
}*/
