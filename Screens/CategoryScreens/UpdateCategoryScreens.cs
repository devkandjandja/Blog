using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class UpdateCategoryScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------------");

            Console.WriteLine("Id da categoria: ");
            var id = Console.ReadLine();

            Console.WriteLine("Nome da categoria: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Slug da categoria: ");
            var slug = Console.ReadLine();

            Update(new Category {
                Id = int.Parse(id),
                Nome = nome,
                Slug = slug,
                }
            );
            Console.ReadKey();
            MenuCategoryScreens.Load(); 
        }

        public static void Update(Category category)
        {
            try
            {
                var repositorio = new Repositorio<Category>(Database.Connection);
                repositorio.Update(category);
                Console.WriteLine("Categoria atualizado com sucesso.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao atualizar categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}