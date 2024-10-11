namespace SMP.Entidades
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public int TipoPagamento { get; set; }
        public DateTime DateTime { get; set; }
        public bool Atrasado { get; set; }
        public Pedido Pedido { get; set; }
    }
}
