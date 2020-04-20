namespace Literatea.Web.Models
{
using Literatea.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
    public class RoomViewModel : Room
    {
        public int RoomId { get; set; }
        public IEnumerable<SelectListItem> Rooms { get; set; }
    }
}
