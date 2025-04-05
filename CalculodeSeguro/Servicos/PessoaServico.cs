using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public class PessoaServico
    {
        public void CriarPessoa(Pessoa pessoa)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            var pessoaExistente = pessoaRepositorio.SelecionarPorId(pessoa.Id);
            if (pessoaExistente != null)
            {
                Console.WriteLine("Pessoa já cadastrada.");
                return;
            }
            pessoaRepositorio.Inserir(pessoa);
        }
     
    }
}
