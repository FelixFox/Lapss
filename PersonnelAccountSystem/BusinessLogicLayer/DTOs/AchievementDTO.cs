using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class AchievementDTO
    {
       
        public int ID { set; get; }
        public int ID_task { set; get; }
        public int? ID_employee { set; get; }
        public string Comment { set; get; }
        public int PointsAdded { set; get; }
    }
}
