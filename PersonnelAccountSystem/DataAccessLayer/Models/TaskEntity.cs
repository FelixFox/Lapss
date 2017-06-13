using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Task")]
    public class TaskEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { set; get; }
        [ForeignKey("Project")]
        public int ID_project { set; get; }
        public virtual ProjectEntity Project { set; get; }
        [ForeignKey("Employee")]
        public int ID_performer { set; get; }
        
        public virtual EmployeeEntity Employee { set; get; }

        public bool Status { set; get; }
    }
}
