
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Libro")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Name { get; set; }
        //se relaciona con room 
        public ICollection<Room> Rooms { get; set; }
        public BookDetail BookDetail { get; set; }

    }
}
