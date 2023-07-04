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
            Console.WriteLine("Listar tag");
            Console.WriteLine("Cadastrar tag");
            Console.WriteLine("Atualizar tag");
            Console.WriteLine("Excluir tag");
            Console.WriteLine();
            Console.WriteLine();

            var opcion = short.Parse(Console.ReadLine()!);

            switch(opcion)
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