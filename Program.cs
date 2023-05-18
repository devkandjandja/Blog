using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"server=localhost,1433; database=Blog; User ID=sa; Password=1q2w3e4r@#$;  trust server certificate=true";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            //ReadUsers();
            //ReadUser();
            //CreateUser();
            //UpDateUser();
            //DeleteUser();
            connection.Close();
        }
        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.Get();
                
                foreach(var user in users)
                {
                    Console.WriteLine(user.Nome);
                }
            }
        }
        public static void ReadUser(SqlConnection connection)
        {
            using(var connetion = new SqlConnection(CONNECTION_STRING))
            {
                var  user = connetion.Get<User>(1);
                Console.WriteLine(user.Nome);
                //Console.WriteLine(user.Email);
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Nome= "Laurindo",
                Email = "alberto@gmail.com",
                PasswordHash= "nada ",
                Bio = "Equipa_balta.io", 
                Image= "https:blog.com",
                Slug="suporte@@tecnica-balta.io"
            };
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro efetuado com sucesso.");
            }
        }
        public static void UpDateUser()
        {
            var user = new User()
            {
                Id = 3,               
                Nome= "Alberto Kandjandja",
                Email = "Alberto@gmail.com",
                PasswordHash= "hash",
                Bio = "Equipa kandjandja.io", 
                Image= "https//:kandjandja.blog.com",
                Slug="suporte-tecnica-kandjandja.io"  
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Dados de usuarios atuliza com sucesso.");           
            }
        }
        public static void DeleteUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Usuario deletado com sucesso");
            }
        }
    }
}