using NUnit.Framework;
using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.BusinessLogicLayer.Services;
using PersonnelAccountSystem.DataAccessLayer.Context;
using PersonnelAccountSystem.DataAccessLayer.Models;
using PersonnelAccountSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Tests
{
    [TestFixture]
    public class EmployeeServiceTests
    {




        private string ConnectionString = "POSYSTEM";
        [Test]
        public void CreateNewEmployee_savesNewEmployeeInContext()
        {
            EmployeeDTO emp;
            using (EmployeeService service = new EmployeeService(ConnectionString))
            {
                emp = new EmployeeDTO
                {
                    Name = "Employee1",
                    Birth = "21/12/1990",
                    Start_of_working = "20/04/2017",
                    ID_role = 1,
                    CurrentSalary = 1234,
                    IDDepartment = 1,
                    Number = 123456789,
                    Score = 0,
                    Summary_Work_Hours = 0
                };
                service.CreateNewEmployee(emp);

            }

            using (PASContext c = new PASContext(ConnectionString))
            {
                c.Employees.Load();
                EmployeeEntity ent = Mappers.EmployeeMapper.Map(emp);
                Assert.AreEqual(c.Entry(ent).Entity.Birth, emp.Birth);
                Assert.AreEqual(c.Entry(ent).Entity.Current_salary, emp.CurrentSalary);
                Assert.AreEqual(c.Entry(ent).Entity.Name, emp.Name);
            }


        }


        /*
                [Test]
                public void GetEmployeeInfo_getsCorrectInfoOfDTO()
                {
                    EmployeeDTO emp;
                    using (EmployeeService service = new EmployeeService(ConnectionString))
                    {
                        emp = service.GetEmployeeInfo((int)3);

                    }

                    using (PASContext c = new PASContext(ConnectionString))
                    {
                        c.Employees.Load();
                        EmployeeEntity ent = c.Employees.Find(3);
                        Assert.AreEqual(ent.Birth, emp.Birth);
                        Assert.AreEqual(ent.Current_salary, emp.CurrentSalary);
                        Assert.AreEqual(ent.Name, emp.Name);
                    }


                }
            }*/
    }
}
