using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreens
    {
       public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Qual id deseja excluir");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Id: ");
            var id = Console.ReadLine();            

            Delete(int.Parse(id));
               
            
            Console.ReadKey();
            MenuTagScreens.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repositorio = new Repositorio<Tag>(Database.Connection);
                repositorio.Delete(id);
                Console.WriteLine("Tag excluida com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nao foi possivel excluir a tag.");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}