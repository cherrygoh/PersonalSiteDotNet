using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Core.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EntryTag> EntryTags { get; set; }
    }
}
