using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class AutomotorServicos
    {

        public void CriarAutomotor(Automotor automotor, int ClienteId,int CategoriaId)
        {
            var automotorRepositorio = new AutomotorRepositorio();
            var automotorExistente = automotorRepositorio.SelecionarPorId(automotor.Id);
            {
                Console.WriteLine("Automotor já cadastrado.");
                return;
            }
            automotorRepositorio.Inserir(automotor);

            var apoliceAutomovel = new Apolice(ClienteId);
            var apoliceRepositorio = new ApoliceRepositorio();
            apoliceRepositorio.Inserir(apoliceAutomovel);

            var apoliceItem = new ApoliceItem(apoliceAutomovel.NumeroApolice, CategoriaId);
            var apoliceItemRepositorio = new ApoliceItemRepositorio();
            apoliceItemRepositorio.Inserir(apoliceItem);
        }
    }
}
