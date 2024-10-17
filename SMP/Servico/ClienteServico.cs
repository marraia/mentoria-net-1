using SMP.Entidades;
using SMP.Repositorio;

namespace SMP.Servico
{
    public class ClienteServico
    {
        public Cliente LoginCliente(string cpf)
        {
            var repositorio = new ClienteRepositorio();
            var logado = repositorio.LoginClient(cpf);

            return logado;
        }

    }
}
