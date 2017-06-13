using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class TaskMapper
    {

        public TaskDTO Map(TaskEntity entity)
        {
            if (entity == null)
                return null;

            return new TaskDTO
            {
                ID=entity.ID,
                ID_performer=entity.ID_performer,
                ID_project=entity.ID_project,
                Status=entity.Status  
            };
        }

        public TaskEntity Map(TaskDTO Dto)
        {
            if (Dto == null)
                return null;

            return new TaskEntity
            {
                ID = Dto.ID,
                ID_performer = Dto.ID_performer,
                ID_project = Dto.ID_project,
                Status = Dto.Status
            };
        }
    }
}
