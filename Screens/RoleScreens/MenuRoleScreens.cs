namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que deseja em Role (Perfil)");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar role");
            Console.WriteLine("2 - Cadastrar role");
            Console.WriteLine("3 - Atualizar role");
            Console.WriteLine("4 - Excluir role");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1:
                ListRoleScreens.Load();
                break;
                case 2: 
                CreateRoleScreens.Load();
                break;
                case 3:
                UpdateRoleScreens.Load();
                break;
                case 4:
                DeleteRoleScreens.Load();
                break;
                default: Load(); break;
            }
        }
    }
}