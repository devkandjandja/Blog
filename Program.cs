using Blog.Screens.CategoryScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"server=localhost,1433; database=Blog; User ID=sa; Password=1q2w3e4r@#$; trust server certificate=true";
        static void Main(string[] args)
        {
           Database.Connection = new SqlConnection(CONNECTION_STRING);
           Database.Connection.Open();

                Load();

            Console.ReadKey();                 
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.WriteLine("Meu blog");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Gestao de usuario");
            Console.WriteLine("2 - Gestao de perfil");
            Console.WriteLine("3 - Gestao de categoria");
            Console.WriteLine("4 - Gestao de tag");
            Console.WriteLine("5 - Vincular perfil/usuario");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatorios");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1:
                MenuUserScreens.Load();
                break;
                case 2:
                MenuRoleScreens.Load();
                break;
                case 3:
                MenuCategoryScreens.Load();
                break;
                case 4:
                MenuTagScreens.Load();
                break;
                default: Load(); break;
            }

        }             
    }
}