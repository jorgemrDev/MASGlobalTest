using Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IEmployeesRepository
    {
        List<EmployeeDTO> GetUsersAll();
        List<EmployeeDTO> GetUserById(int id);
    }
}
