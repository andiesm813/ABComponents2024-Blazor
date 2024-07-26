using System.Net.Http.Json;
using AllABComponents2024.Models.DashboardData;

namespace AllABComponents2024.DashboardData
{
    public class DashboardDataService: IDashboardDataService
    {
        private readonly HttpClient _http;

        public DashboardDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<TeamGrowthType>> GetTeamGrowthList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/9d362c81-e18a-4fff-4355-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TeamGrowthType>>().ConfigureAwait(false);
            }

            return new List<TeamGrowthType>();
        }
    }
}
