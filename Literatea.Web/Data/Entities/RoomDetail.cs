using System;
using System.ComponentModel.DataAnnotations;

namespace Literatea.Web.Data.Entities
{
    public class RoomDetail : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Día que ingreso a la sala")]
        public DateTime AdmissionDate { get; set; }
        public ReaderUser ReaderUser { get; set; }
        public Room Room { get; set; }
        public Forum Forum { get; set; }

    }
}
