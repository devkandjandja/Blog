using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"server=localhost,1433; database=Blog; User ID=sa; Password=1q2w3e4r@#$; trust server certificate=true";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            ReadUsers(connection);
            ReadRoles(connection);   
            ReadTags(connection);                  
            connection.Close();
        }
        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repositorio<User>(connection);
            var itens = repository.Get();
                
                foreach(var item in itens)
                {   
                 Console.WriteLine(item.Nome);
                 foreach(var role in item.Roles)
                   Console.WriteLine($" - {role.Nome}");
                }
        }    

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UseRepositorio(connection);
            var items = repository.GetWithRoles();

             foreach(var item in items)
                {   
                 Console.WriteLine(item.Nome);
                 foreach(var role in item.Roles)
                   Console.WriteLine($" - {role.Nome}");
                }

        }    
        public static void ReadRoles(SqlConnection connection)
        {
           var repository = new Repositorio<Role>(connection);
           var items = repository.Get();

           foreach(var item in items)
             Console.WriteLine(item.Nome);              
              
        }
        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repositorio<Tag>(connection);
            var items = repository.Get();

            foreach(var item in items)
            Console.WriteLine(item.Nome);
        }       
    }
}