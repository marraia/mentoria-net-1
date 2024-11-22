

namespace Treinamento2
{
    public class Futebol
    {
        public int Vasco { get; set; }
        public int Flamengo { get; set; }
        public int Botafogo { get; set; }
        public int Fluminense { get; set; }
        public string TimeEscolhido { get; set; }
        private List<Usuario> Usuarios { get; set; } = new List<Usuario>();


       
        public void AdicionarVoto(string timeEscolhido)
        {
            switch (timeEscolhido)
            {
                case "v":
                    Vasco++;
                    break;
                case "f":
                    Flamengo++;
                    break;
                case "b":
                    Botafogo++;
                    break;
                case "t":
                    Fluminense++;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha entre v(Vasco), f (Flamengo), b (Botafogo), t (Fluminense).");
                    break;
            }
        }

        public void ExibirResultados()
        {
            Console.WriteLine($"Vasco: {Vasco}");
            Console.WriteLine($"Flamengo: {Flamengo}");
            Console.WriteLine($"Botafogo: {Botafogo}");
            Console.WriteLine($"Fluminense: {Fluminense}");
        }

        public void CapturarVotos(int numeroDeVotos)
        {
            for (int i = 0; i < numeroDeVotos; i++)
            {
                Console.WriteLine("Escolha um time: v (Vasco), f (Flamengo), b (Botafogo), t (Fluminense).");
                string timeEscolhido = Console.ReadLine();
                AdicionarVoto(timeEscolhido);
            }
        }
    }
}
/*-Qual time os usuarios torçem. propriedade nova
        - a quantidade total de cada time
        - criar uma nova opção no menu dizendo a quantidade de times cadastrados.
        - pegar uma lista, agrupar essa lista e somar a quantidade times cadastrados.*/