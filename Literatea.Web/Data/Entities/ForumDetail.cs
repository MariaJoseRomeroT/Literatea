
namespace Literatea.Web.Data.Entities
{
using System.Collections.Generic;
    public class ForumDetail
    {
        public int Id { get; set; }
        public string ForumName { get; set; }
public ICollection<Forum> Forums { get; set; }
    }
}
