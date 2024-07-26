using AllABComponents2024.Models.DashboardData;

namespace AllABComponents2024.DashboardData
{
    public interface IDashboardDataService
    {
        Task<List<TeamGrowthType>> GetTeamGrowthList();
    }
}
