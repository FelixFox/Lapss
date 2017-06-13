using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Interaces
{
    interface IAnalisysService
    {
        int CalculateRecommendedSalary(int id_employee);
       
        void Dispose();
    }
}
