using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class ListRoleScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Role");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuRoleScreens.Load();
        }  
        public static void List()
        {
            var repositorio = new Repositorio<Role>(Database.Connection);
            var roles = repositorio.Get();
            foreach(var item in roles)
              Console.WriteLine($"{item.Nome} - {item.Slug}");
        }
    }
}