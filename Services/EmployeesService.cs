using DataLayer;
using Models;
using Services.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeesService : IEmployeesService
    {
        IEmployeesRepository _employeesRepository;
        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public List<EmployeeDTO> GetUsersAll()
        {
            List<EmployeeDTO> lstEmployees = _employeesRepository.GetUsersAll();
            lstEmployees.ForEach(e => e.annualSalary = Factory.GetAnualSalary(e.contractTypeName, e.hourlySalary, e.monthlySalary).TotalSalary);
            return lstEmployees;
        }

        public List<EmployeeDTO> GetUserById(int id)
        {
            List<EmployeeDTO> lstEmployees = _employeesRepository.GetUserById(id);
            lstEmployees.ForEach(e => e.annualSalary = Factory.GetAnualSalary(e.contractTypeName, e.hourlySalary, e.monthlySalary).TotalSalary);
            return lstEmployees;
        }
    }
}
