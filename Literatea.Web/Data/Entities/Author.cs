namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

    public class Author: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Autor")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string AuthorName { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
