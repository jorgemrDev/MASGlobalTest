using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DataLayer
{
    public class EmployeesRepository : IEmployeesRepository
    { 
        string url = "http://masglobaltestapi.azurewebsites.net/api/employees";
        List<EmployeeDTO> _employeeList;

        public EmployeesRepository()
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            _employeeList = JsonConvert.DeserializeObject<List<EmployeeDTO>>(reply);
        }

        public List<EmployeeDTO> GetUsersAll()
        {
            return _employeeList;
        }

        public List<EmployeeDTO> GetUserById(int id)
        {
            return _employeeList.Where(e => e.id == id).ToList();
        }
    }
}
