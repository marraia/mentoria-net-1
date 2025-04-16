using CalculodeSeguro.Dominio;
using CalculodeSeguro.Servicos;
using Dapper;
using System.ComponentModel.DataAnnotations;
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

        public int Inserir(Cliente cliente)
        {
            var sql = "insert into cliente (NomeCompleto, CPF, Email, Telefone, Endereço) values (@NomeCompleto, @CPF, @Email, @Telefone, @Endereço)";

            var clienteInserido = connection.ExecuteScalar<int>(sql, new 
            {
                cliente.NomeCompleto,
                cliente.CPF,
                cliente.Email,
                cliente.Telefone,
                cliente.Endereço
            });
            return clienteInserido;
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

            var cliente = connection
                            .QuerySingleOrDefault<Cliente>(sql, new { Cpf = cpf });

            return cliente;
        }

        public void Atualizar(Cliente cliente)
        {
            var sql = "update cliente set NomeCompleto = @NomeCompleto, CPF = @CPF, Email = @Email, Telefone = @Telefone, Endereço = @Endereço where Id = @Id";
            
            var clienteAtualizado = connection.Execute(sql, new
            {
                cliente.NomeCompleto,
                cliente.CPF,
                cliente.Email,
                cliente.Telefone,
                cliente.Endereço,
                cliente.Id
            });
            
        }

        public void Deletar(int id)
        {
            var sql = "delete from cliente where Id = @id";
            var clienteDeletado = connection
                            .Execute(sql, new { Id = id });
            
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
