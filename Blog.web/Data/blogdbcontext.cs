using Blog.web.Models.Domin;
using Microsoft.EntityFrameworkCore;

namespace Blog.web.Data
{
    public class blogdbcontext :DbContext
    {
        public blogdbcontext(DbContextOptions options): base(options)
        {

        }
        public DbSet<blogpost>blogposts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
