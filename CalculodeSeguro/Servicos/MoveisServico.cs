
using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class MoveisServico
    {
        public void criarMoveis(Moveis moveis)
        {
            var moveisRepositorio = new MoveisRepositorio();
            var moveisExistente = moveisRepositorio.SelecionarPorId(moveis.Id);
            if (moveisExistente != null)
            {
                Console.WriteLine("Moveis já cadastrados.");
                return;
            }
            moveisRepositorio.Inserir(moveis);
        }
    }
}


