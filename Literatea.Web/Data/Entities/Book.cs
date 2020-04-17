
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Libro")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string BookName { get; set; }
        [Display(Name = "Genero Libro")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Gender { get; set; }
        [Display(Name = "Editorial")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Editorial { get; set; }
        [Display(Name = "Numero de páginas")]
        [Required(ErrorMessage = "{0} es requerido")]
        public int NumberPages { get; set; }
        //se relaciona con room 
        public ICollection<Room> Rooms { get; set; }
        public Author Author { get; set; }

    }
}
