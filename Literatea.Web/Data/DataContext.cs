
namespace Literatea.Web.Data
{
using Literatea.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
   public class DataContext:DbContext
    {
        public DbSet<readerUser> readerUsers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<ForumDetail> ForumDetails { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
