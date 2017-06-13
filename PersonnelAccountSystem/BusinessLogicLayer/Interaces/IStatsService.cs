using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Interaces
{
    public interface IStatsService<T> where T:class
    {

        IEnumerable<T> GetForDepartment(int ID_department);
        T GetForEmployee(int? ID_employee);
        bool ClearForDepartment(int ID_department);
        bool ClearForEmployee(int ID_employee);
        void Dispose();
        
    }
}
