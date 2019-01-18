using System;
using System.Collections.Generic;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Services;
using Moq;
namespace MASGlobalEmployeesTest
{
    [TestClass]
    public class BussinessLayerTests
    {
        [TestMethod]
        public void TestGetUsersAll()
        {
            //ARRANGE
            List<EmployeeDTO> lstEmployees = createResponse();
            Mock<IEmployeesRepository> mock = new Mock<IEmployeesRepository>();
            EmployeesService busssinessLayer = new EmployeesService(mock.Object);
            mock.Setup(c => c.GetUsersAll())
                .Returns(lstEmployees);

            //ACT
            List<EmployeeDTO> result = busssinessLayer.GetUsersAll();

            //ASSERT
            Assert.AreEqual(result[0].annualSalary, (120 * result[0].hourlySalary * 12));
            Assert.AreEqual(result[1].annualSalary, (result[0].monthlySalary * 12));
        }

        private List<EmployeeDTO> createResponse()
        {
            List<EmployeeDTO> lstEmployees = new List<EmployeeDTO>();
            EmployeeDTO employee = new EmployeeDTO()
            {
                name = "Test Name",
                contractTypeName = "HourlySalaryEmployee",
                hourlySalary = 100,
                monthlySalary = 1000
            };
            lstEmployees.Add(employee);
            employee = new EmployeeDTO()
            {
                name = "Test Name",
                contractTypeName = "MonthlySalaryEmployee",
                hourlySalary = 100,
                monthlySalary = 1000
            };
            lstEmployees.Add(employee);
            return lstEmployees;
        }
    }
}
