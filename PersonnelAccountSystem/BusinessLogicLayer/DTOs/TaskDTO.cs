using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class TaskDTO
    {
      
        public int ID { set; get; }
        public int ID_project { set; get; }
        public int ID_performer { set; get; }
        public bool Status { set; get; }

    }
}
