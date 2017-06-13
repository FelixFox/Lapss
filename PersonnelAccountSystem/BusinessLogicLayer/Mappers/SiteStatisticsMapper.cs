using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public class SiteStatisticsMapper
    {

        public SiteStatisticsDTO Map(SiteStatisticsEntity entity)
        {
            if (entity == null)
                return null;

            return new SiteStatisticsDTO
            {
               ID=entity.ID,
               ID_employee=entity.ID_employee,
               DatetimeRecord=entity.Datetime_record,
               Forbidden_site_name=entity.Forbidden_site_name,
               PenaltyPoints=entity.Penalty_points,
               Time=entity.Time
            };


        }

        public SiteStatisticsEntity Map(SiteStatisticsDTO Dto)
        {
            if (Dto == null)
                return null;

            return new SiteStatisticsEntity
            {
                ID = Dto.ID,
                ID_employee = Dto.ID_employee,
                Datetime_record = Dto.DatetimeRecord,
                Forbidden_site_name = Dto.Forbidden_site_name,
                Penalty_points = Dto.PenaltyPoints,
                Time = Dto.Time
            };
        }
    }

}
