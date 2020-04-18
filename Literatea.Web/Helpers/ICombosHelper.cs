using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Literatea.Web.Helpers
{
    interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboReaderUsers();
    }
}
