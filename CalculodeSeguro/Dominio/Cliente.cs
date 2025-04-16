
namespace CalculodeSeguro.Dominio
{
    public class Cliente
    {
        private string? cpfCadastrado;

        public int Id  { get; private set; }
        public string NomeCompleto { get;  private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereço { get; private set; }
        

        public Cliente(string nomeCompleto, string cpf, string email,string telefone,string endereco)
        {
            NomeCompleto= nomeCompleto;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
            Endereço = endereco;
        }

        public Cliente()
        {
            
        }

       

        public void AtualizarId(int id)
        {
            Id = id;
        }



    }
}
