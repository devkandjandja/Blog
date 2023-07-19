using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class UpdateRoleScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Role: ");

            Console.WriteLine();
            var id = Console.ReadLine();            
            Console.WriteLine("-----------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("slug: ");
            var slug = Console.ReadLine();   

            Update(new Role
                {
                    Id = int.Parse(id),
                    Nome = nome,
                    Slug = slug
                }
            );
            Console.ReadKey();
            MenuRoleScreens.Load(); 
        }

        public static void Update(Role role)
        {
            try
            {
                var repositorio = new Repositorio<Role>(Database.Connection);
                repositorio.Update(role);
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