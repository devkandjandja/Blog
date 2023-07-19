namespace Blog.Screens.CategoryScreens
{
    public static class MenuCategoryScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que deseja em categoria:");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categoria");
            Console.WriteLine("2 - Criar ");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("Excluir");
            Console.WriteLine();
            Console.WriteLine();
            
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1:
                ListCategoryScreens.Load();
                break;
                case 2:
                CreateCategoryScreens.Load();
                break;
                case 3:
                UpdateCategoryScreens.Load();
                break;
                case 4:
                DeleteCategoryScreens.Load();
                break;
                default: Load(); break;

            }
        }
    }
}