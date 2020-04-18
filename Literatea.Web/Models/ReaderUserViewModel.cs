namespace Literatea.Web.Models
{
using Literatea.Web.Data.Entities;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class ReaderUserViewModel : ReaderUser
    {
        public IFormFile ImageFile { get; set; }
        public int ReaderUserId { get; set; }
        public IEnumerable<SelectListItem> ReaderUsers { get; set; }
    }
}
