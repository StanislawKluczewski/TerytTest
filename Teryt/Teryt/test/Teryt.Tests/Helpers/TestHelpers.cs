using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Teryt.Tests.Helpers
{
    public static class TestHelpers
    {
        public static string jsonMediaType = "application/json";
        public static int expectedMaElapsedMilliseconds = 1000;
        public readonly static JsonSerializerOptions jsonSerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7069")
        };

    }
}
