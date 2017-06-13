using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Interaces
{
    public interface IEmployeeService:IDisposable
    {
        bool ChangeEmployeeInfo(int id, EmployeeDTO newInfo);
        bool CreateNewEmployee(EmployeeDTO newEmployee);
        bool DeleteEmployee(int id);
        IEnumerable<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeInfo(int id);
        
        void Dispose();
    }
}
