

namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BookDetail : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Libro")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string BookName { get; set; }
        [Display(Name = "Nombre Autor")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string AutorName { get; set; }
        [Display(Name = "Genero Libro")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Gender { get; set; }
        [Display(Name = "Editorial")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Editorial { get; set; }
        [Display(Name = "Numero de páginas")]
        [Required(ErrorMessage = "{0} es requerido")]
        public int NumberPages { get; set; }

        //Se relaciona con libro o book
        public ICollection<Book> Books { get; set; }

    }
}
