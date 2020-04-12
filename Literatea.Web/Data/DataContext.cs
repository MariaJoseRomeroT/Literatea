
namespace Literatea.Web.Data
{
using Literatea.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
   public class DataContext:DbContext
    {
        DbSet<readerUser> readerUsers { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<BookDetail> BookDetails { get; set; }
        DbSet<Forum> Forums { get; set; }
        DbSet<ForumDetail> ForumDetails { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
