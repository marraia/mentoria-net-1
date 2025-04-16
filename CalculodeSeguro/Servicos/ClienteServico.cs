
using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class ClienteServico
    {
        public int CriarCliente(Cliente cliente)
        {
            var clienteRepositorio = new ClienteRepositorio();
            var clienteExistente = clienteRepositorio.SelecionarPorCpf(cliente.CPF);
            if (clienteExistente != null)
            {
                Console.WriteLine("Cliente já cadastrado");
                return clienteExistente.Id;
            }
            var clienteInserido =  clienteRepositorio.Inserir(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso");
            return clienteInserido;

        }


        public Cliente SelecionarClientePorCpf(Cliente cliente)
        {  var clienteRepositorio =  new ClienteRepositorio();
           var clienteEncontrado = clienteRepositorio.SelecionarPorCpf(cliente.CPF);
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente não encontrado");
                return default;
            }
            Console.WriteLine("Cliente encontrado com sucesso");
            Console.WriteLine($"Bem vindo de volta Sr(a) {cliente.NomeCompleto}");
            return clienteEncontrado;
        }
    }
}
 //selecionar por cpf e retornar o cliente,caso nao encontrado colocar mensagem de erro
//tela -> negocio -> repositorio
