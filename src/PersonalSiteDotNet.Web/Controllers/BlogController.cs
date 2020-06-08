using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalSiteDotNet.Core.Entities;
using PersonalSiteDotNet.Core.Services;

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
        public async Task<IEnumerable<Blog>> Get()
        {
            return await _blogService.GetAsync();
        }
            

        // GET api/<BlogController>/5
        [HttpGet("{id}")]
        public async Task<Blog> Get(int id)
        {
            return await _blogService.GetByIdAsync(id);
        }

        // POST api/<BlogController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Blog blog)
        {
            await _blogService.AddAsync(blog);
            return CreatedAtAction(nameof(Get), new { id = blog.Id }, blog);
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
