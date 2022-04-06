using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatr.Data.Employee.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        public EmployeeQueries()
        {
            
        }

        public async Task<List<Models.Employee>> ListofEmployee()
        {

            var li = new List<Models.Employee>()
            {
                new Models.Employee()
                {
                    FirstName = "A",
                    LastName = "A",
                    EmployeeId = 1,
                    Age = 50,
                    Birthday = DateTime.Now,
                    Phone = "211111"
                }
            };
            

            return li;
        }
    }
}