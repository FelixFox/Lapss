using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Mappers
{
    public static class EmployeeMapper
    {

        public static EmployeeDTO Map(EmployeeEntity entity)
        {
            if (entity == null)
                return null;

            return new EmployeeDTO
            {
                ID=entity.ID,
                Name=entity.Name,
                Birth=entity.Birth,
                CurrentSalary=entity.Current_salary,
                IDDepartment=entity.ID_department,
                ID_role=entity.ID_role,
                Number=entity.Number,
                Score=entity.Score,
                Start_of_working=entity.Start_of_working,
                Summary_Work_Hours=entity.Summary_work_hours
            };


        }

        public static EmployeeEntity Map(EmployeeDTO Dto)
        {
            if (Dto == null)
                return null;

            return new EmployeeEntity
            {
                ID = Dto.ID,
                Name = Dto.Name,
                Birth = Dto.Birth,
                Current_salary = Dto.CurrentSalary,
                ID_department = Dto.IDDepartment,
                ID_role = Dto.ID_role,
                Number = Dto.Number,
                Score = Dto.Score,
                Start_of_working = Dto.Start_of_working,
                Summary_work_hours = Dto.Summary_Work_Hours
            };
        }
    }
}
