namespace Literatea.Web.Helpers
{
using Literatea.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboUsers()
        {
            var list = dataContext.Users.Select(
                c=>new SelectListItem 
            {
                Text = c.FullName,
                Value = $"{c.Id}"
                }).ToList();
            list.Insert(0,new SelectListItem
            {
                Text="[Ingresa nombre de usuario...]",
                Value="0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboReaderUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboBooks()
        {
            var list = dataContext.Books.Select(
                c => new SelectListItem
                {
                    Text = c.BookName,
                    Value = $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Ingresa nombre de usuario...]",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboRooms()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboForums()
        {
            throw new NotImplementedException();
        }
    }
}
        
