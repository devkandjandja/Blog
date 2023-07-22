using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Seleciona o id para excluir");
            Console.WriteLine("---------------------");

            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            

            Delete(int.Parse(id)); 

            Console.ReadKey();
            MenuUserScreens.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repositorio = new Repositorio<User>(Database.Connection);
                repositorio.Delete(id);
                Console.WriteLine("Usuario cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao excluir usuario!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}