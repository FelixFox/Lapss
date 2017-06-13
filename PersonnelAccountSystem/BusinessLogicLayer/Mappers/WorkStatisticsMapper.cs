using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class WorkStatisticsMapper
    {

        public WorkStatisticsDTO Map(WorkStatisticsEntity entity)
        {
            if (entity == null)
                return null;

            return new WorkStatisticsDTO
            {
               ID=entity.ID_record,
               DatetimeEndWork=entity.End_work,
               ID_Employee=entity.ID_Employee,
               DatetimeRecord=entity.Datetime_of_record,
               DatetimeStartWork=entity.Start_work,
               PercentWorkTime=entity.Percent_time_work
            };


        }

        public WorkStatisticsEntity Map(WorkStatisticsDTO Dto)
        {
            if (Dto == null)
                return null;

            return new WorkStatisticsEntity
            {
                ID_record = Dto.ID,
                End_work = Dto.DatetimeEndWork,
                ID_Employee = Dto.ID_Employee,
                Datetime_of_record = Dto.DatetimeRecord,
                Start_work = Dto.DatetimeStartWork,
                Percent_time_work = Dto.PercentWorkTime
            };
        }
    }
}
