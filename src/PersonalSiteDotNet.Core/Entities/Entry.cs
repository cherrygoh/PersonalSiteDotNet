using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Core.Entities
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public ICollection<EntryTag> EntryTags {get; set;}
    }
}
