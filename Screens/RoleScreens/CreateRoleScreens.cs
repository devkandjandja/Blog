using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Role: ");
            Console.WriteLine("-----------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("slug: ");
            var slug = Console.ReadLine();   

            Create(new Role
                {
                    Nome = nome,
                    Slug = slug
                }
            );
            Console.ReadKey();
            MenuRoleScreens.Load(); 
        }

        public static void Create(Role role)
        {
            try
            {
                var repositorio = new Repositorio<Role>(Database.Connection);
                repositorio.Create(role);
                Console.WriteLine("Perfil cadastrado com sucesso.");
            }
            catch(Exception ex)
            {
            Console.WriteLine("Nao foi possivel cadastrar a tag.");
            Console.WriteLine(ex.Message);
            }

        }
    }
}