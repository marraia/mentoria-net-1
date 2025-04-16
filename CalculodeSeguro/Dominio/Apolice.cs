
namespace CalculodeSeguro.Dominio
{
    public class Apolice
    {
        public int Id { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string NumeroApolice { get; private set; }
        public int ClienteId { get; private set; }


         public Apolice(int clienteId)
        {
            NumeroApolice = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Ticks}{DateTime.Now.Millisecond} ";
            ClienteId = clienteId;
        }

        public Apolice()
        {

        }

        public void AtualizarId(int id)
        {
            Id = id;
        }

        public void GerarApolice()
        {
            DataInicio = DateTime.Now;
            DataFim = DataInicio.AddYears(1);
        }

        
    }
}
