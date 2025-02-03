namespace SegurosApp.Models
{
    public abstract class SeguroBase
    {
       
        public string NomeSegurado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public decimal ValorCobertura { get; set; }


        public virtual void ExibirNome()
        {
            Console.WriteLine($"Nome: {NomeSegurado}, Data de inicio: {DataInicio}, data de termino: {DataTermino}, Valor da Cobertura: {ValorCobertura}");
        }
    }

    
}
