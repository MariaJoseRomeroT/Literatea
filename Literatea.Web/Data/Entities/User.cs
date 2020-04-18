
namespace Literatea.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage ="El campo {0} no pude tener mas de 30 caracteres" )]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no pude tener mas de 30 caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Nombre completo")]
        public string FullName => $"{LastName} {FirstName}";
    }
}
