using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento2
{
    public class Usuario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime Data { get; set; }
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
                DataNasc = datanasc
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