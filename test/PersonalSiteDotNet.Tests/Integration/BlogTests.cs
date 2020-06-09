using Microsoft.AspNetCore.Mvc.Testing;
using PersonalSiteDotNet.Web;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PersonalSiteDotNet.Tests.Integration
{
    public class BlogTests: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BlogTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_NoParameters_ReturnsAll()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "/api/blog";

            //Act
            var response = await client.GetAsync(url);

            //Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
