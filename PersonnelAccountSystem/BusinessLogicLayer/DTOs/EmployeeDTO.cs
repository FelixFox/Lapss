using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class EmployeeDTO
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Start_of_working { get; set; }
        public int Summary_Work_Hours { get; set; }
        public string Birth { get; set; }
        public int ID_role { set; get; }
        public int CurrentSalary { set; get; }
        public int Score { set; get; }
        public int IDDepartment { set; get; }

    }
}
