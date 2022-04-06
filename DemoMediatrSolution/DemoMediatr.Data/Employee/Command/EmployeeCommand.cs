using System.Threading.Tasks;

namespace DemoMediatr.Data.Employee.Command
{
    public class EmployeeCommand : IEmployeeCommand
    {
        public async Task<Models.Employee> Add(Models.Employee Employee)
        {
            var s = new Models.Employee();

            return s;
        }
    }
}