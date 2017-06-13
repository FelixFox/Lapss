using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class ProjectMapper
    {

        public ProjectDTO Map(ProjectEntity entity)
        {
            if (entity == null)
                return null;

            return new ProjectDTO
            {
                ID=entity.ID,
                Name=entity.Name,
                ID_leader=entity.ID_leader
            };


        }

        public ProjectEntity Map(ProjectDTO Dto)
        {
            if (Dto == null)
                return null;

            return new ProjectEntity
            {
                ID = Dto.ID,
                Name = Dto.Name,
                ID_leader = Dto.ID_leader
            };
        }
    }
}
