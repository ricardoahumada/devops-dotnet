using HelloWorld.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
namespace HelloWorld.FunctionalTests
{
    public class HomePageShould : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client; public HomePageShould(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }
        
        [Fact]
        public async Task ReturnHttpStatusCodeOk()
        {
            var response = await _client.GetAsync("/"); Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}