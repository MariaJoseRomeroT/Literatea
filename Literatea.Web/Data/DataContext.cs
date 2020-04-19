
namespace Literatea.Web.Data
{
using Literatea.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
   public class DataContext:IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ReaderUser> ReaderUsers { get; set; }
        public DbSet<RoomDetail> RoomDetails { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
