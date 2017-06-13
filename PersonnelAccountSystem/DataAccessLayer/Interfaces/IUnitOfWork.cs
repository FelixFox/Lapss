using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<AchievementsEntity> Achievements { get; }
        IRepository<DepartmentEntity> Departments { get; }
        IRepository<EmployeeEntity> Employees { get; }
        IRepository<ProjectEntity> Projects { get; }
        IRepository<RoleEntity> Roles { get; }
        IRepository<SiteStatisticsEntity> SiteStatistics { get; }
        IRepository<TaskEntity> Tasks { get; }
        IRepository<WorkStatisticsEntity> WorkStatistics { get; }
        
        void Save();
    }
}
