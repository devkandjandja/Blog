using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List de categoria");
            Console.WriteLine("--------------------");
            Console.ReadKey();
            List();
            MenuCategoryScreens.Load();
        }
        public static void List()
        {
            var repositorio = new  Repositorio<Category>(Database.Connection);
            var categoris = repositorio.Get();
            foreach(var item in categoris)
             Console.WriteLine($"{item.Nome} - {item.Posts} - {item.Slug}");
        }
    }
}