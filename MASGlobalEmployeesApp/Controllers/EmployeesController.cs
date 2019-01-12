using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MASGlobalEmployeesApp.Controllers
{
    public class EmployeesController : ApiController
    {
        IEmployeesService _employeesService;
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        // GET: api/Employees/id
        public HttpResponseMessage GetEmployees(string id = null)
        {
            List<EmployeeDTO> lstEmployees;
            if (id == null)
            {
                lstEmployees = _employeesService.GetUsersAll();                
            }
            else
            {
                lstEmployees = _employeesService.GetUserById(Convert.ToInt32(id));
            }
            
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstEmployees);
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            return response;
        }
    }
}


