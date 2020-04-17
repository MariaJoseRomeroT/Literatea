using System.ComponentModel.DataAnnotations;

namespace Literatea.Web.Data.Entities
{
    public class Author: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Autor")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string AuthorName { get; set; }
    }
}
