using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Department")]
    public class DepartmentEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID_dep { set; get; }
        public string Name { set; get; }

        //[ForeignKey("Employee")]
        public int? ID_manager { set; get; }
       // public virtual EmployeeEntity Employee { set; get; }


        public virtual ICollection<EmployeeEntity> Employees { set; get; }

    }
}
