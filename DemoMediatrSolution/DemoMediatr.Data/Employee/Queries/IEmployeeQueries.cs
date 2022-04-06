using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMediatr.Data.Employee.Queries
{
    public interface IEmployeeQueries
    {
        Task<List<Models.Employee>> ListofEmployee();
    }
}