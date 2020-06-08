using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Core.Services
{
    public interface IBlogService
    {
        Task AddAsync(Blog blog);
        Task DeleteAsync(Blog blog);
        Task UpdateAsync(Blog blog);
        Task<IEnumerable<Blog>> GetAsync();
        Task<Blog> GetByIdAsync(int id);
    }
}
