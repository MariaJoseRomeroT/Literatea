using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Literatea.Web.Helpers
{
    interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboUsers();
        IEnumerable<SelectListItem> GetComboReaderUsers();
        IEnumerable<SelectListItem> GetComboBooks();
        IEnumerable<SelectListItem> GetComboRooms();
        IEnumerable<SelectListItem> GetComboRoomDetails();
        IEnumerable<SelectListItem> GetComboForums();
        IEnumerable<SelectListItem> GetComboAuthors();
    }
}
