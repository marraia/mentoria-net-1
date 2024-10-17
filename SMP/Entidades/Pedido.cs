namespace SMP.Entidades
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public List<Item> Itens { get; set; } = new List<Item> ();
    }
}
