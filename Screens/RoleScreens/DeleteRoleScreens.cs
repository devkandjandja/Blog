using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deseja excluir alguma perfil.");
            Console.WriteLine("-----------------------");

            Console.WriteLine("id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuRoleScreens.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repositorio = new Repositorio<Role>(Database.Connection);
                repositorio.Delete(id);
                Console.WriteLine("Perfil excluido com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nao foi possivel escluir o perfil.");
                Console.WriteLine(ex.Message);
            }            
        }
    }
}