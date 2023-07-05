using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome: ");
            var nome =Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Nome = nome,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreens.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repositorio = new Repositorio<Tag>(Database.Connection);
                repositorio.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nao foi possivel cadastrar a tag.");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}