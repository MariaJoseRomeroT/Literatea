

namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Forum : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Foro")]
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
