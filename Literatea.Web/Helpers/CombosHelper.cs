using Literatea.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Literatea.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboReaderUsers()
        {
            var list = dataContext.ReaderUsers.Select(
                c=>new SelectListItem 
            {
                Text= c.Name,
                Value = $"{c.Id}"
                }).ToList();
            list.Insert(0,new SelectListItem
            {
                Text="[Debe seleccionar un genero]",
                Value="0"
            });
            return list;
        }
    }
}
        
