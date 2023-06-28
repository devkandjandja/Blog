using Dapper.Contrib.Extensions;
namespace Blog.Models
{
    [Table("[Category]")]
    public class Category
    {
        public int Id {get; set;}
        public string Nome {get; set;} ="";
        public string Slug{get; set;} ="";
    }
} 