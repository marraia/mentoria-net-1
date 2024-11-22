using System.Reflection.Metadata;

namespace Treinamento2
{
    public class Usuario 
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime Data { get; set; }
        public string TimeEscolhido { get; set; }
        private List<Usuario> Usuarios { get; set; } = new List<Usuario>();


        //adicionar usuarios
        public void AdicionarUsuario(string cpf, string nome, string email, DateTime datanasc)
        {
            var usuario = new Usuario
            {
                Data = DateTime.Now,
                CPF = cpf,
                Nome = nome,
                Email = email,
                DataNasc = datanasc,
                TimeEscolhido = TimeEscolhido

            };
            Usuarios.Add(usuario);

        }
        //idade do usuario
        public double Idade()
        {
            var Idade = Data.Year - DataNasc.Year;
            return Idade;
        }

        //historico de usuarios
        public string ExibirUsuarios()
        {
            var usuario = string.Empty;
            foreach (var user in Usuarios)
            {
                usuario += $" Data de cadastro: {user.Data} | Cpf: {user.CPF} | Nome : {user.Nome} | Email: {user.Email} | Data de Nascimento: {user.DataNasc.Year} | Idade: {user.Idade()} anos | Par ou Impar: {user.ParouImpar(DataNasc)} \n";

            }
            return usuario;
        }



        public string LoginClient(string cpf)
        {
            var cliente = Usuarios.Where(item => item.CPF == cpf).FirstOrDefault();

            return $" Data de cadastro: {cliente.Data} | Cpf: {cliente.CPF} | Nome : {cliente.Nome} | Email: {cliente.Email} | Data de Nascimento: {cliente.DataNasc} | Idade: {cliente.Idade()} anos |Ano Par ou Impar: {cliente.ParouImpar(DataNasc)} \n";

        }

        public void EditarUsuario(string cpf, string nome, string email, DateTime datanasc)
        {
            var cliente = Usuarios.Where(item => item.CPF == cpf).FirstOrDefault();
            Usuarios.Remove(cliente);
            cliente.Nome = nome;
            cliente.Email = email;
            cliente.DataNasc = datanasc;
            Usuarios.Add(cliente);
        }

        public string ParouImpar(DateTime datanasc)

        {
            if (datanasc.Year % 2 == 0)
            {
                return "É par";
            }

            return "É impar";
        }

       


    }
}
//CPF - Nome - Email - Data Nascimento -  DataCadastro