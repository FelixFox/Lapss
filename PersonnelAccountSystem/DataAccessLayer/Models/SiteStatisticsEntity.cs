using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("SiteStatistics")]
    public class SiteStatisticsEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { set; get; }

        public string Datetime_record { set; get; }
        public string Forbidden_site_name { set; get; }
        public int Time { set; get; }
        [ForeignKey("Employee")]
        public int ID_employee { set; get; }
        public virtual EmployeeEntity Employee { set; get; }
        public int Penalty_points { set; get; }
    }
}
