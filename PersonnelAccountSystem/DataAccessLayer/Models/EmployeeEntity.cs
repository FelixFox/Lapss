using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Employee")]
    public class EmployeeEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Start_of_working { get; set; }
        public int Summary_work_hours { get; set; }
        public string Birth { get; set; }

        [ForeignKey("Role")]
        public int ID_role { set; get; }
        public virtual RoleEntity Role { set; get; }

        public int Current_salary { set; get; }
        public int Score { set; get; }

        [ForeignKey("Department")]
        public int ID_department { set; get; }
        public virtual DepartmentEntity Department { set; get; }

        public virtual ICollection<AchievementsEntity> Achievements { set; get; }
        public virtual ICollection<ProjectEntity> Projects { set; get; }
        public virtual ICollection<SiteStatisticsEntity> SiteStatistics { set; get; }
        public virtual ICollection<WorkStatisticsEntity> WorkStatistics { set; get; }
        public virtual ICollection<TaskEntity> Tasks { set; get; }
        



    }
}
