
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ForumDetail
    {
        public int Id { get; set; }
        [Display(Name = "Detalles del Foro")]
        public string ForumName { get; set; }
public ICollection<Forum> Forums { get; set; }
    }
}
