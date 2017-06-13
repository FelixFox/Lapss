using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class AchievementMapper
    {

        public AchievementDTO Map(AchievementsEntity entity)
        {
            if (entity == null)
                return null;

            return new AchievementDTO
            {
                ID = entity.ID,
                ID_employee = entity.ID_employee,
                PointsAdded = entity.PointsAdded,
                ID_task = entity.ID_task
            };


        }

            public AchievementsEntity Map(AchievementDTO Dto)
            {
                if (Dto == null)
                    return null;

                return new AchievementsEntity
                {
                    ID = Dto.ID,
                    ID_employee = Dto.ID_employee,
                    PointsAdded = Dto.PointsAdded,
                    ID_task = Dto.ID_task
                };
            }
        }

    }

