using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Mvc;
using PersonalSiteDotNet.Core.Entities;
using PersonalSiteDotNet.Core.Interfaces;
using PersonalSiteDotNet.Web.Models;
using PersonalSiteDotNet.Web.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalSiteDotNet.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        // GET: api/<BlogController>
        [HttpGet]
        [ResponseType(typeof(IEnumerable<BlogDTO>))]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Blog> blog = await _blogService.GetAsync();
            IEnumerable<BlogDTO> blogDTOs = BlogMapper.mapManyToDTO(blog);
            return Ok(blogDTOs);
        }
            

        // GET api/<BlogController>/5
        [HttpGet("{id}")]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IActionResult> Get(int id)
        {
            Blog blog = await _blogService.GetByIdAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            BlogDTO blogDTO = BlogMapper.mapSingleToDTO(blog);
            return Ok(blogDTO);
        }

        // POST api/<BlogController>
        [HttpPost]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IActionResult> Post([FromBody] BlogDTO blogDTO)
        {
            Blog blog = BlogMapper.mapSingleToBlog(blogDTO);
            await _blogService.AddAsync(blog);
            return CreatedAtAction(nameof(Get), new { id = blog.Id }, blogDTO);
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BlogDTO blogDTO)
        {
            if (id != blogDTO.Id)
            {
                return BadRequest();
            }

            Blog blog = BlogMapper.mapSingleToBlog(blogDTO);

            try
            {
                await _blogService.UpdateAsync(blog);
            }
            catch (DBConcurrencyException e)
            {
                if (await _blogService.GetByIdAsync(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<BlogController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _blogService.GetByIdAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            await _blogService.DeleteAsync(blog);

            return NoContent();
        }
    }
}
