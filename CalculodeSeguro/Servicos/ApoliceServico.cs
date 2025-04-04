

using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class ApoliceServico
    {
        public void CriarApolice(Apolice apolice)
        {
            var apoliceRepositorio = new ApoliceRepositorio();
            var apoliceExistente = apoliceRepositorio.SelecionarPorNumeroDaApolice(apolice.NumeroApolice);
            if (apoliceExistente != null)
            {
                Console.WriteLine("Apolice já cadastrada");
                return;
            }
            apoliceRepositorio.Inserir(apolice);
            Console.WriteLine("Apolice cadastrada com sucesso");
        }

        public Apolice SelecionarApolicePorNumero(string numeroApolice)
        {
            var apoliceRepositorio = new ApoliceRepositorio();
            var apoliceEncontrada = apoliceRepositorio.SelecionarPorNumeroDaApolice(numeroApolice);
            if (apoliceEncontrada == null)
            {
                Console.WriteLine("Apolice não encontrada");
                return default;
            }
            return apoliceEncontrada;
        }
    }
}
