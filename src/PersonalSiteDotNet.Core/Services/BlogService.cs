using PersonalSiteDotNet.Core.Entities;
using PersonalSiteDotNet.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Core.Services
{
    public class BlogService : IBlogService
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<Blog> _blogRepository;
        public BlogService(IUnitOfWork unitOfWork, IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Blog blog)
        {
            _blogRepository.Add(blog);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Blog blog)
        {
            _blogRepository.Delete(blog);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Blog>> GetAsync()
        {
            return await _blogRepository.GetAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Blog blog)
        {
            _blogRepository.Update(blog);
            await _unitOfWork.CommitAsync();
        }
    }
}
