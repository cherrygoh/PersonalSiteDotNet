using PersonalSiteDotNet.Core.Entities;
using PersonalSiteDotNet.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Web.Mappers
{
    public static class BlogMapper
    {
        public static BlogDTO mapSingleToDTO(Blog blog)
        {
            return new BlogDTO()
            {
                Id = blog.Id,
                Name = blog.Name
            };
        }

        public static IEnumerable<BlogDTO> mapManyToDTO(IEnumerable<Blog> blogs)
        {
            IEnumerable<BlogDTO> blogDTOs = blogs.Select(blog => mapSingleToDTO(blog));
            return blogDTOs;
        }

        public static Blog mapSingleToBlog(BlogDTO blogDTO)
        {
            return new Blog()
            {
                Id = blogDTO.Id,
                Name = blogDTO.Name
            };
        }
    }
}
