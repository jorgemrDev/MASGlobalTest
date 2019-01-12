using Models;
using System.Collections.Generic;

namespace Services
{
    public interface IEmployeesService
    {
        List<EmployeeDTO> GetUsersAll();
        List<EmployeeDTO> GetUserById(int id);
    }
}