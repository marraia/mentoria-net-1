
using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos

{
    public class NauticoServico
    {
        public void CriarNautico(Nautico nautico)
        {
            var nauticoRepositorio = new NauticoRepositorio();
            var nauticoExistente = nauticoRepositorio
                .SelecionarPorRegistroEmbarcacao(nautico.RegistroEmbarcacao);

            if (nauticoExistente != null)
            {
                Console.WriteLine("Nautico já cadastrado.");
                return;
            }
            nauticoRepositorio.Inserir(nautico);
        }
       
    }
}
