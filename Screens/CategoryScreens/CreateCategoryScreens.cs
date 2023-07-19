using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class CreateCategoryScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------------");

            Console.WriteLine("Nome da categoria: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Slug da categoria: ");
            var slug = Console.ReadLine();

            Create(new Category
                {
                Nome = nome,
                Slug = slug,
                }
            );
            Console.ReadKey();
            MenuCategoryScreens.Load();            
        }

        public static void Create(Category category)
        {
            try
            {
            var repositorio = new Repositorio<Category>(Database.Connection);
            repositorio.Create(category);
            Console.WriteLine("Categoria cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro no cadastro de categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}