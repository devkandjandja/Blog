using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-----------------------");
            List();
            Console.ReadKey();
            MenuTagScreens.Load();
        }
        private static void List()
        {
           var repositorio = new Repositorio<Tag>(Database.Connection);
           var tags = repositorio.Get();
           foreach(var item in tags)
             Console.WriteLine($"{item.Id} - {item.Nome} {item.Slug}");
        }
    }
}