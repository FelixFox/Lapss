using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("WorkStatistics")]
    public class WorkStatisticsEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID_record { set; get; }

        public string Datetime_of_record { set; get; }
        public string Start_work { set; get; }
        public string End_work { set; get; }

        [ForeignKey("Employee")]
        public int? ID_Employee { set; get; }
        public virtual EmployeeEntity Employee { set; get; }

        public virtual int Percent_time_work { set; get; }
    }
}
