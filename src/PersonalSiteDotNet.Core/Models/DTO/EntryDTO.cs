using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Core.Models
{
    public class EntryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int BlogId { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
