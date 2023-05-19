using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Teryt.Tests.Helpers;
using Teryt.WebApi.Commands.Terc;
using Teryt.WebApi.DTO.Response;

namespace Teryt.Tests.IntegrationTests.TERC
{
    public class GetVoivodeshipsIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;

        public GetVoivodeshipsIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }


        [Fact]
        public async Task ShouldReturnAllVoivodeshipsInPoland()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "https://localhost:7069/api/TERC/DajWojewodztwa";
            var input = new GetVoivodeshipsCommand { };

            //// Act
            var response = await client.PostAsJsonAsync(url, input);
            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(result);
        }


        [Fact]
        public async Task ShouldReturnSingleVoivodeshipInPoland()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "https://localhost:7069/api/TERC/DajWojewodztwo";
            var input = new GetVoivodeshipByIdCommand { WojewodztwoId = 2 };

            //// Act
            var response = await client.PostAsJsonAsync(url, input);
            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(result);
        }
    }
}
