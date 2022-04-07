using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoMediatr.Core.Employee.Commands;
using DemoMediatr.Data.Employee.Queries;
using MediatR;

namespace DemoMediatr.Core.Employee.Handler
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<Models.Employee>>
    {
        private readonly IEmployeeQueries _employeeQueries;

        public GetEmployeeQueryHandler(IEmployeeQueries employeeQueries)
        {
            _employeeQueries = employeeQueries;
        }

        public async Task<List<Models.Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _employeeQueries.ListofEmployee();
        }
    }

}