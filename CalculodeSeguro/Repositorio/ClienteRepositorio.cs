

using CalculodeSeguro.Dominio;

namespace CalculodeSeguro.Repositorio
{
    public class ClienteRepositorio
    {
        //insert delete update select terminar de fazer os metodos para as outras classes respeitando a necessidade de cada propridade
        //exemplo: se a propriedade for um objeto, fazer um select para trazer o objeto completo
        //slelect no numeroApolice para trazer a apolice completa

        public void Inserir(Cliente cliente)
        {
            var sql = "insert into cliente (NomeCompleto, CPF, Email, Telefone, Endereco) values (@NomeCompleto, @CPF, @Email, @Telefone, @Endereco)";
        }

        public void Atualizar(Cliente cliente)
        {
            var sql = "update cliente set NomeCompleto = @NomeCompleto, CPF = @CPF, Email = @Email, Telefone = @Telefone, Endereco = @Endereco where Id = @Id";
        }

        public void Excluir(int Id)
        {
            var sql = "delete from cliente where Id = @Id";
        }
        public void Selecionar(int Id)
        {
            var sql = "select * from cliente where Id = @Id";
        }
        public void SelecionarPorCpf(string cpf)
        {
            var sql = "select * from cliente where cpf = @cpf";
        }
    }
}
