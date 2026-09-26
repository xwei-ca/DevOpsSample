using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace DevOpsSample.Api.Tests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public UnitTest1(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task WeatherForecastReturnsOK()
        {
            var response = await _client.GetAsync("http://localhost:5071/WeatherForecast");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
