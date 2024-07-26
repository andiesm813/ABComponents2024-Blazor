using AllABComponents2024.Models.DashboardData;

namespace AllABComponents2024.DashboardData
{
    public class MockDashboardDataService : IDashboardDataService
    {
        public Task<List<TeamGrowthType>> GetTeamGrowthList()
        {
            return Task.FromResult<List<TeamGrowthType>>(new());
        }
    }
}
