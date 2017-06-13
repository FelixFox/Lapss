using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class ProjectDTO
    {
     
        public int ID { set; get; }
        public string Name { set; get; }
        public int? ID_leader { set; get; }

    }
}
