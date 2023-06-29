using Dapper.Contrib.Extensions;
namespace Blog.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        public int Id {get; set;}
        public string Nome {get; set;} ="";
        public string Slug {get; set;} ="";
    }
}