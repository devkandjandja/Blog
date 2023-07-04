using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreens
    {
        public static void Load()
        {
            List();
        }
        public static void List()
        {
           var repositorio = new Repositorio<Tag>();
        }
    }
}