using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Core.Models
{
    public class PagedResult<T>
    {
        // Max # of rows/ entries in a page
        public int PageSize { get; set; }
        
        public int PageNumber { get; set; }
        
        // Max # of pages
        public int PageCount { get; set; }
        
        // Total number of results from query
        public int ResultsCount { get; set; }
        
        // Total number of results on this page
        public int RowCount { get; set; }
        public IEnumerable<T> Results { get; set; } 
    }
}
