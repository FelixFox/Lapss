using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class DepartmentDTO
    {
       
        public int ID_dep { set; get; }
        public string Name { set; get; }
        public int? ID_manager { set; get; }

    }
}
