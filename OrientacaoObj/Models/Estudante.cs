

namespace OrientacaoObj.Models
{
    public class Estudante : Pessoa
    {
        public string Curso { get; set; }

        // Usando o construtor para inicializar nome,idade e curso
        public Estudante(string nome, int idade, string curso) : base(nome, idade)//chamando a classe pai e suas caracteristicas
        {
            Curso = curso;
        }
        
        public void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Curso : {Curso}");
        }
    }
}
