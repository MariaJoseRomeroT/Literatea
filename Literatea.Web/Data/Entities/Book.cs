
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book: IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Libro")]
        
        public string BookName { get; set; }

        [Display(Name = "Genero Libro")]
        
        public string Gender { get; set; }

        [Display(Name = "Editorial")]
        
        public string Editorial { get; set; }

        [Display(Name = "Numero de páginas")]
        
        public int NumberPages { get; set; }
 
        public ICollection<Room> Rooms { get; set; }
        public Author Author { get; set; }

    }
}
