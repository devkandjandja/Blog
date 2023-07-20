using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuario");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();

            Console.WriteLine("Passworld: ");
            var password = Console.ReadLine();

            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();  

            Create( new User
                {
                    Nome = nome,
                    Email = email,
                    PasswordHash = password,
                    Bio = bio
                }
            );  

            Console.ReadKey();
            MenuUserScreens.Load(); 
        }
        public static void Create(User user)
        {
            try
            {
                var repositorio = new Repositorio<User>(Database.Connection);
                repositorio.Create(user);
                Console.WriteLine("Usuario cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuario.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}