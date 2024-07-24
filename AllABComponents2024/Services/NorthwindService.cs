using System.Net.Http.Json;
using AllABComponents2024.Models.Northwind;

namespace AllABComponents2024.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<EmployeesType>> GetEmployees()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-employees-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeesType>>().ConfigureAwait(false);
            }

            return new List<EmployeesType>();
        }
    }
}
