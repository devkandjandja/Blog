using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuario");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            List();
            Console.ReadKey();
            MenuUserScreens.Load();
        }
        public static void List()
        {
            var repositorio = new Repositorio<User>(Database.Connection);
            var users = repositorio.Get();
            foreach(var item in users)
             Console.WriteLine($"{item.Nome} - {item.Email} - {item.PasswordHash} - {item.Roles} - {item.Slug} - {item.Bio} - {item.Image}");
        }
    }
}