using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class RoleMapper
    {

        public RoleDTO Map(RoleEntity entity)
        {
            if (entity == null)
                return null;

            return new RoleDTO
            {
               ID=entity.ID,
               Name=entity.Name
            };


        }

        public RoleEntity Map(RoleDTO Dto)
        {
            if (Dto == null)
                return null;

            return new RoleEntity
            {
                ID = Dto.ID,
                Name = Dto.Name
            };
        }
    }
}
