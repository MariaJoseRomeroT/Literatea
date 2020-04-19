namespace Literatea.Web.Models
{
using Literatea.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
    public class AuthorViewModel : Author
    {
        public int AuthorId { get; set; }
        public IEnumerable<SelectListItem> Authors { get; set; }
    }
}
