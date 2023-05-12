using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"server=localhost,1433; database=Blog; User ID=sa; Password=1q2w3e4r@#$;  trust server certificate=true";

        static void Main(string[] args)
        {
            ReadUsers();
        }

        public static void ReadUsers()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();
                foreach(var user in users)
                {
                    Console.WriteLine(user.Nome);
                }
            }
        }

    }
}