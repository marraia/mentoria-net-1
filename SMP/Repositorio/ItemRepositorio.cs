using SMP.Entidades;

namespace SMP.Repositorio
{
    public class ItemRepositorio
    {
        public List<Item> ObterItens()
        {
            var lista = new List<Item>();
            lista.Add(new Item() {  Id = Guid.Parse("9012baaf-ca26-45f6-b85b-4772b645aabf"), Descricao = "Geladeira Brastemp 220v", Marca = "Brastemp", Nome = " Geladeira Brastemp", Valor = 2000});
            lista.Add(new Item() { Id = Guid.Parse("9b1583ef-05e8-4f2b-86fc-c0c91793f495"), Descricao = "Maquina de lavar Brastemp 220v", Marca = "Brastemp", Nome = " Maquina de lavar Brastemp", Valor = 1500 });
            

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
