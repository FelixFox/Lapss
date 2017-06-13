using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Achievements")]
    public class AchievementsEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { set; get; }

        [ForeignKey("Task")]
        public int ID_task { set; get; }
        public virtual TaskEntity Task { set; get; }

        [ForeignKey("Employee")]
        public int? ID_employee { set; get; }
        public virtual EmployeeEntity Employee { set; get; }

        public string Comment { set; get; }
        public int PointsAdded { set; get; }
    }
}
