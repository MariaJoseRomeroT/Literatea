namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ReaderUser : IEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<RoomDetail> RoomDetails { get; set; }
    }
}
