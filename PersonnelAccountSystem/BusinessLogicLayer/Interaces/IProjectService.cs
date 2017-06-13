using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Interaces
{
    public interface IProjectService
    {
        bool ChangeProjectInfo(int id, ProjectDTO newInfo);
        ProjectDTO getProjectInfo(int id);
        bool DeleteProject(int id);
        //IEnumerable<EmployeeEntity> GetEmployeesOfProject(int id);
        bool AddProject(ProjectDTO newProject);
        void Dispose();
    }
}
