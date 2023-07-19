namespace Blog.Screens.TagScreens
{
   public static class MenuTagScreens
   {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que deseja realizar");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tag");
            Console.WriteLine("2 - Cadastrar tag");
            Console.WriteLine("3 - Atualizar tag");
            Console.WriteLine("4 - Excluir tag");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1:
                ListTagScreens.Load();
                break;
                case 2: 
                CreateTagScreens.Load();
                break;
                case 3:
                UpdateTagScreens.Load();
                break;
                case 4:
                DeleteTagScreens.Load();
                break;
                default: Load(); break;
            }
        }
   }
}