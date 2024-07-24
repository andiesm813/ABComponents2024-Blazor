using AllABComponents2024.Models.Northwind;

namespace AllABComponents2024.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}
