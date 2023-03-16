using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


/*
 * UPDATE
  [User]
SET
  [Name] = 'Gabriel Lima'
WHERE
  id = 1
*/

namespace Blog.Repositories
{
    internal class Repository<T> where T : class //(aceita a criação de repositorios genericos apenas do tipo CLASS)
    {
        private readonly SqlConnection _connection; //propriedade do tipo sqlconnection

        public Repository(SqlConnection connection)
          => _connection = connection;

        public IEnumerable<T> Get() //Função para ler os usuarios 
           => _connection.GetAll<T>(); //Conectando aos campos da tabela USUARIOS(USERS)    
      
        public T Get(int id)
            => _connection.Get<T>(id);
      
        public void Create(T model)
            => _connection.Insert<T>(model);
       
        public void Update(T model)
            => _connection.Update<T>(model);   
       
        public void Delete(T model)
            => _connection.Delete<T>(model);
       
        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model); //Conectando aos campos da tabela USUARIOS(USERS) 
        }

    }
}
