using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMediatr.Core.Employee.Commands;
using MediatR;
using DemoMediatr.Data.Employee.Queries;
using DemoMediatr.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoMediatr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetEmployeeQuery());
            return Ok(result);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {


            var result = await _mediator.Send(new GetEmployeeQuery());

            return Ok(result);
        }

        // POST api/<EmployeeController>
        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="employee"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddEmployeeModel employee)
        {
            var result = await _mediator.Send(new CreateEmployeeCommand()
            {
                Employee = new Employee()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    EmployeeId = 1,
                    Phone = "9878987898",
                    Age = 50,
                    Birthday = DateTime.Now
                }
            });
            return Ok(result);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
