namespace Calculadora2._0
{
    // Classe para fazer as operações
    public class Calculadora
    {
        //propriedades da classe Calculadora
        public float A { get; set; }
        public float B { get; set; }
        public float Visor { get; set; }
        public List<Historico> Historico { get; set; } = new List<Historico>();
        //Propriedades da classe

        public void SetarValores(float a, float b)
        {
            A = a;
            B = b;
        }

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

        public void Divisao()
        {
            if (A == 0)
            {
                Console.WriteLine("Não é possivel dividir com 0");
            }
            else
            {
                Visor = A / B;
                AdicionarAoHistorico("Divisao", $"{A} / {B}", Visor);
            }
        }

        public void AdicionarAoHistorico(string operacao, string valores, float resultado)
        {
            var historico = new Historico
            {
                Data = DateTime.Now,
                Operacao = operacao,
                Valores = valores,
                Resultado = resultado
            };

            Historico.Add(historico);
        }

        public string ExibirHistorico() //metodo para chamar e imprimir o historico na tela
        {
            var historico = string.Empty;

            foreach (var item in Historico)
            {
                historico += $"Data:{item.Data} | Operacao: {item.Operacao} | Valores : {item.Valores} | Resultado: {item.Resultado};\n";
            }

            return historico;
            
        }
       public float TotalResultados()
        {
            float somaTotal = 0;
            foreach (var item in Historico)
            {
                somaTotal += item.Resultado;
            }

            return somaTotal;
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
