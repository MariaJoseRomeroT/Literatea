

namespace Literatea.Web.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Room: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sala")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Name { get; set; }
        public ICollection<RoomDetail> RoomDetails { get; set; }
        public Book Book { get; set; }
        
    }
}
