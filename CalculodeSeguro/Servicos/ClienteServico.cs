
using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class ClienteServico
    {
        public void CriarCliente(Cliente cliente)
        {
            var clienteRepositorio = new ClienteRepositorio();
            var clienteExistente = clienteRepositorio.SelecionarPorCpf(cliente.CPF);
            if (clienteExistente != null)
            {
                Console.WriteLine("Cliente já cadastrado");
                return;
            }
            clienteRepositorio.Inserir(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso");

        }


        public Cliente SelecionarClientePorCpf(Cliente cliente)
        {  var clienteRepositorio =  new ClienteRepositorio();
           var clienteEncontrado = clienteRepositorio.SelecionarPorCpf(cliente.CPF);
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente não encontrado");
                return default;
            }
            return clienteEncontrado;
        }
    }
}
 //selecionar por cpf e retornar o cliente,caso nao encontrado colocar mensagem de erro
//tela -> negocio -> repositorio
