using System;

namespace Literatea.Web.Data.Entities
{
    public class readerUser : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Room Room { get; set; }

    }
}
