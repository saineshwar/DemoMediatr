using System.Collections.Generic;
using DemoMediatr.Models;
using MediatR;

namespace DemoMediatr.Core.Employee.Commands
{
    public class CreateEmployeeCommand : IRequest<Models.Employee>
    {
        public Models.Employee Employee { get; set; }
    }

    public class GetEmployeeQuery : IRequest<List<Models.Employee>>
    {
        
    }
}