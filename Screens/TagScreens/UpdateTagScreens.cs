using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar tag");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Nome: ");
            var nome =Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Nome = nome,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreens.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repositorio = new Repositorio<Tag>(Database.Connection);
                repositorio.Update(tag);
                Console.WriteLine("Tag atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar a tag.");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}