
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;

    public class Book: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //se relaciona con room 
        public ICollection<Room> Rooms { get; set; }
        public BookDetail BookDetail { get; set; }

    }
}
