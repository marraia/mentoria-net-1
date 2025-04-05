using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class AutomotorServicos
    {

        public void CriarAutomotor(Automotor automotor)
        {
            var automotorRepositorio = new AutomotorRepositorio();
            var automotorExistente = automotorRepositorio.SelecionarPorId(automotor.Id);
            {
                Console.WriteLine("Automotor já cadastrado.");
            }
            automotorRepositorio.Inserir(automotor);
        }
    }
}
