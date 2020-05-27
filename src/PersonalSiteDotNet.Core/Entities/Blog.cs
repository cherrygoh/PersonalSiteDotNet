using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Core.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Entry> Entries { get; set; }
    }
}
