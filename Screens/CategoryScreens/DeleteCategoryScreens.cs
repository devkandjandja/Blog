using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class DeleteCategoryScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deseja excluir alguma categoria");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadLine();
            MenuCategoryScreens.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repositorio = new Repositorio<Category>(Database.Connection);
                repositorio.Delete(id);
                Console.WriteLine("Categoria excluida comsucesso.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Falha ao excluir esta categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}