namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que deseja realizar");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuario");
            Console.WriteLine("2 - Cadastrar usuario");
            Console.WriteLine("3 - Atualizar usuario");
            Console.WriteLine("4 - Excluir usuario");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1:
                ListUserScreens.Load();
                break;
                case 2: 
                CreateUserScreens.Load();
                break;
                case 3:
                UpdateUserScreens.Load();
                break;
                case 4:
                DeleteUserScreens.Load();
                break;
                default: Load(); break;
            }
        }
    }
}
