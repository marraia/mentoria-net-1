

using CalculodeSeguro.Dominio;
using CalculodeSeguro.Servicos;
using Dapper;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Xml.Linq;
using static Dapper.SqlMapper;

namespace CalculodeSeguro.Repositorio
{
    public class ClienteRepositorio
    {
        protected SqlConnection connection;
        public ClienteRepositorio()
        {
            connection = new SqlConnection("Server=localhost;Database=ResguardoSeguros;User Id=sa;Password=123Aa321;");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Inserir(Cliente cliente)
        {
            var sql = "insert into cliente (NomeCompleto, CPF, Email, Telefone, Endereco) values (@NomeCompleto, @CPF, @Email, @Telefone, @Endereco)";
        }

        public Cliente Selecionar(int id)
        {
            var sql = "select * from cliente where Id = @id";

            var cliente = connection
                            .QuerySingleOrDefault<Cliente>(sql, new { Id = id });

            return cliente;
        }
        public Cliente SelecionarPorCpf(string cpf)
        {
            var sql = "select * from cliente where cpf = @cpf";
            return new Cliente();
        }
    }
}

       /* public virtual async Task<TKey> InsertAsync(TEntity entity)
        {
            var query = "ComandoSQL"

     var id = await _connection
                         .ExecuteScalarAsync<TKey>(query,
                                       entity,
                                       transaction: _transactionBase.GetDbTransaction())
                         .ConfigureAwait(false);
            return id;
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            var query = "ComandoSQL"
       
     await _connection
             .ExecuteAsync(query,
                           entity,
                           transaction: _transactionBase.GetDbTransaction())
             .ConfigureAwait(false);
        }
        public virtual async Task<int> DeleteAsync(TKey id)
        {
            var query = "ComandoSQL"
       
     return await _connection
             .ExecuteAsync(sql,
                             new { Id = id },
                             transaction: _transactionBase.GetDbTransaction())
             .ConfigureAwait(false);
        }
        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            var query = "ComandoSQL"


     return await _connection
                     .QuerySingleOrDefaultAsync<TEntity>(sql, new { Id = id })
                     .ConfigureAwait(false);
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query = "ComandoSQL"
       
     return await _connection
                     .QueryAsync<TEntity>(sql)
                     .ConfigureAwait(false);
        }
    }
}*/
