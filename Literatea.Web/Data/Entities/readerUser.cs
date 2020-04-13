using System;
using System.ComponentModel.DataAnnotations;

namespace Literatea.Web.Data.Entities
{
    public class readerUser : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string LastName { get; set; }

        [Display(Name = "Cumpleaños")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "{0} es requerido")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string Password { get; set; }

        public Room Room { get; set; }

    }
}
