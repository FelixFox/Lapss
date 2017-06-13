using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Models
{
    [Table("Role")]
    public class RoleEntity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { set; get; }
        public string Name { set; get; }

        public virtual ICollection<EmployeeEntity> RoleEmployees { set; get; }
    }
}
