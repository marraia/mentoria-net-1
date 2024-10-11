using SMP.Entidades;

namespace SMP.Repositorio
{
    public class ItemRepositorio
    {
        public List<Item> ObterItens()
        {
            var lista = new List<Item>();
            lista.Add(new Item() {  Id = Guid.NewGuid(), Descricao = "GEladeira Brastemp 220v", Marca = "Brastemp", Nome = " Geladeira Brastemp", Valor = 2000});
;

            return lista;
        }

        public Item ObterItemPorId(Guid id)
        {
            var listaItem = ObterItens();

            var item = listaItem.Where(item => item.Id == id).FirstOrDefault();

            return item;
        }
    }
}
