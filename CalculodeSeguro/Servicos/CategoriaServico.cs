using CalculodeSeguro.Dominio;
using CalculodeSeguro.Repositorio;

namespace CalculodeSeguro.Servicos
{
    public  class CategoriaServico
    {
        public void EscolherCategoria(Categoria categoria)
        {
            
            var categorias = new CategoriaRepositorio();
            var categoriaEscolhida = categorias.SelecionarPorId(categoria.Id);


        }

    }
}
