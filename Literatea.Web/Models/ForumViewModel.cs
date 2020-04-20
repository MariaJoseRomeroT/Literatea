namespace Literatea.Web.Models
{
using Literatea.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
    public class ForumViewModel : Forum
    {
        public int RoomDetailId { get; set; }
        public IEnumerable<SelectListItem> RoomDetails { get; set; }
    }
}
