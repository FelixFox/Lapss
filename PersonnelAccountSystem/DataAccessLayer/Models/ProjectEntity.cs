using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Project")]
    public class ProjectEntity
    {

        [Key]
        [Column(Order = 0)]
        public int ID { set; get; }
        public string Name { set; get; }

        [ForeignKey("Employee")]
        public int? ID_leader { set; get; }
        public virtual EmployeeEntity Employee { set; get; }

        public virtual ICollection<TaskEntity> ProjectTasks { set; get; }
    }
        
}
