using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorIntegrationTests
{
    public class CalculatorEndToEnd : IClassFixture<WebApplicationFactory<CalculatorWebApplication.Startup>>
    {

        private readonly WebApplicationFactory<CalculatorWebApplication.Startup> _factory;

        public CalculatorEndToEnd(WebApplicationFactory<CalculatorWebApplication.Startup> factory )
        {
            _factory = factory;
        }

        [Fact]       
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/");
                        
            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task PostInput_ShouldReturnSum_PostSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act

            var calcRequest = new CalculatorWebApplication.Dtos.CalculationRequest
            {
                Input = "1,2",
                Operation = "Add"
            };
           
            var request = new HttpRequestMessage();
            //var response = new HttpResponseMessage();

            request.Content = JsonContent.Create(calcRequest, typeof(CalculatorWebApplication.Dtos.CalculationRequest));
            request.RequestUri = new Uri("/calculation", UriKind.Relative);
            request.Method = HttpMethod.Post;
            

            var response = await client.SendAsync(request);

            var responeString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<CalculatorWebApplication.Dtos.CalculationResponse>(responeString);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("3", result.CalculationResult);

            
        }
    }

}