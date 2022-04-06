using System.Threading;
using System.Threading.Tasks;
using DemoMediatr.Core.Employee.Commands;
using DemoMediatr.Data.Employee;
using DemoMediatr.Data.Employee.Command;
using MediatR;

namespace DemoMediatr.Core.Employee.Handler
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Models.Employee>
    {
        private readonly IEmployeeCommand _employeeCommand;

        public CreateEmployeeCommandHandler(IEmployeeCommand employeeCommand)
        {
            _employeeCommand = employeeCommand;
        }

        public async Task<Models.Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeCommand.Add(request.Employee);
        }
    }

    
}