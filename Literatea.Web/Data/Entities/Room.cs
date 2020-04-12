

namespace Literatea.Web.Data.Entities
{
    using System.Collections.Generic;
    public class Room: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //una sala o room esta relacionada con varios usuarios lectores
        public ICollection<readerUser> ReaderUsers { get; set; }

        public Book Book { get; set; }
        public Forum Forum { get; set; }
    }
}
