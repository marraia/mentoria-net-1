

using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class ApoliceItemServico
    {
        public void ItensApolice(ApoliceItem apoliceItem)
        {
            var itensDaApolice = new ApoliceItemRepositorio();
            var itensEscolhidos = itensDaApolice.SelecionarPorId(apoliceItem.Id);
        }
    }
}
