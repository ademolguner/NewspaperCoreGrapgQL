using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewspaaperCoreGrapgQL.Entities.Models;
using System.IO;

namespace NewspaaperCoreGrapgQL.DataAccess.Concrete
{
    public class NewspaperContext : DbContext
    {

        public NewspaperContext()
        {
        }
        public NewspaperContext(DbContextOptions<NewspaperContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// dosyadan okuyacak sekilde düzenle
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=NewspaperDb;Integrated Security=True;");
        }
         
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<PostTag> PostTag { get; set; }
    }
}
