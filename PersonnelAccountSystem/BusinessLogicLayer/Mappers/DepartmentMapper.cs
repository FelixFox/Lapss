using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class DepartmentMapper
    {

        public DepartmentDTO Map(DepartmentEntity entity)
        {
            if (entity == null)
                return null;

            return new DepartmentDTO
            {
                ID_dep = entity.ID_dep,
                Name = entity.Name,
                ID_manager = entity.ID_manager
        };


        }

        public DepartmentEntity Map(DepartmentDTO Dto)
        {
            if (Dto == null)
                return null;

            return new DepartmentEntity
            {
                ID_dep = Dto.ID_dep,
                Name = Dto.Name,
                ID_manager = Dto.ID_manager
            };
        }
    }

}


