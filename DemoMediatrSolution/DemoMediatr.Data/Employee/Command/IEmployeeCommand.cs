using System.Threading.Tasks;

namespace DemoMediatr.Data.Employee.Command
{
    public interface IEmployeeCommand
    {
        Task<Models.Employee> Add(Models.Employee employee);
    }
}