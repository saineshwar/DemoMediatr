using System.Threading.Tasks;

namespace DemoMediatr.Data.Employee.Command
{
    public class EmployeeCommand : IEmployeeCommand
    {
        public async Task<Models.Employee> Add(Models.Employee employee)
        {
            return employee;
        }
    }
}