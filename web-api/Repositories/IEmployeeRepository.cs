using System.Collections.Generic;
using web_api.Models;

namespace web_api.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployeeList();

        IEnumerable<Employee> GetEmployeeDetails(int empId);

    }
}
