using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Core.Models
{
    public class EntryRequestParameters: RequestParameters
    {
        public DateTime? PublishedDateFrom { get; set; } = null;
        public DateTime? PublishedDateTo { get; set; } = null;
        public DateTime? ModifiedDateFrom { get; set; } = null;
        public DateTime? ModifiedDateTo { get; set; } = null;
        public int? BlogId { get; set; } = null;
        public IEnumerable<string> TagLabels { get; set; } = null;
    }
}
