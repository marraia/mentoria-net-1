

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculodeSeguro.Dominio
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Genero { get; private set; }
        public string Profissao { get; private set; }
        public DateTime DataDeNascimento { get; private set; }

        public Pessoa(string genero, string profissao, DateTime dataDeNascimento)
        {
            Genero = genero;
            Profissao = profissao;
            DataDeNascimento = dataDeNascimento;
        }
        public Pessoa()
        {
        }
        public void AtualizarId(int id)
        {
            Id = id;
        }
    }
}