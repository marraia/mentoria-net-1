using SMP.Entidades;
using SMP.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace SMP.Servico
{
    public class VendaServico
    {
        public List<Item> CarrinhoCompra { get; set; }= new List<Item>();

        public List<Item> ObterItensPrateleira()
        {
            var repositorio = new ItemRepositorio();
            return repositorio.ObterItens();
        }

        public Item ObterItemPorId(Guid id)
        {
            var repositorio = new ItemRepositorio();
            return repositorio.ObterItemPorId(id);
        }

        public void AdicionarCarrinhoCompra(Item item)
        {
            CarrinhoCompra.Add(item);

        }

        public Pedido FecharPedido()
        {
            var pedido = new Pedido();
            pedido.Data = DateTime.Now;
            pedido.Id = Guid.NewGuid();

            foreach (var item in CarrinhoCompra)
            {
                pedido.Itens.Add(item);
            }

            pedido.Valor = pedido.Itens.Sum(item => item.Valor);
            return pedido;
        }
    }
}
