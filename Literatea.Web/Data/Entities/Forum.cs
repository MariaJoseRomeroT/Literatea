

namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    public class Forum : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
