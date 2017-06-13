using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class SiteStatisticsDTO
    {        
        public int ID { set; get; }
        public string DatetimeRecord { set; get; }
        public string Forbidden_site_name { set; get; }
        public int Time { set; get; }   
        public int ID_employee { set; get; }
        public int PenaltyPoints { set; get; }
    }
}
