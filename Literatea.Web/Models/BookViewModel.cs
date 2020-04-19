namespace Literatea.Web.Models
{
using Literatea.Web.Data.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class BookViewModel : Book
    {
        public int BookId { get; set; }
        public IEnumerable<SelectListItem> Books { get; set; }
    }
}
