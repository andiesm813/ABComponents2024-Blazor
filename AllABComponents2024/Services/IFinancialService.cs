using AllABComponents2024.Models.Financial;

namespace AllABComponents2024.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
