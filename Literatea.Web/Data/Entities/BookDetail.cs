

namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    public class BookDetail : IEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AutorName { get; set; }
        public string Gender { get; set; }
        public string Editorial { get; set; }
        public int NumberPages { get; set; }

        //Se relaciona con libro o book
        public ICollection<Book> Books { get; set; }

    }
}
