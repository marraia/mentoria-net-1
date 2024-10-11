using SMP.Entidades;
namespace SMP.Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> ObterClientes()
        {
            var lista = new List<Cliente>();
            lista.Add(new Cliente() { CPF = "09809809890", Id = Guid.NewGuid(), Nome = "Silvio Santos" });
            lista.Add(new Cliente() { CPF = "12345678901", Id = Guid.NewGuid(), Nome = "Neymar Junior" });
            lista.Add(new Cliente() { CPF = "01234567890", Id = Guid.NewGuid(), Nome = "Gabigol" });
            lista.Add(new Cliente() { CPF = "09876543211", Id = Guid.NewGuid(), Nome = "Zico" });

            return lista;
        }

        public Cliente LoginClient(string cpf)
        {
            var listaClientes = ObterClientes();

            var cliente = listaClientes.Where(item => item.CPF == cpf).FirstOrDefault();

            return cliente;
        }
    }
}
