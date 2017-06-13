using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.DTOs
{
    public class WorkStatisticsDTO
    {

        public int ID { set; get; }
        public string DatetimeRecord { set; get; }
        public string DatetimeStartWork { set; get; }
        public string DatetimeEndWork { set; get; }
        public int? ID_Employee { set; get; }
        public virtual int PercentWorkTime { set; get; }
    }
}
