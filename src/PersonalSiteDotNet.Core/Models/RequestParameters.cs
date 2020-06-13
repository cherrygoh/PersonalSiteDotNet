using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Core.Models
{
    public class RequestParameters
    {
        // Filter parameters
        public int? Id { get; set; } = null;

        // Sorting parameters
        public string sortProperty { get; set; } = null;
        public bool? sortDesc { get; set; } = null;

        // Paging parameters
        public int? pageNumber { get; set; } = null;
        public int? pageSize { get; set; } = null; 
    }
}
