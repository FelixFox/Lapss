using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Context
{
    public class PASContext:DbContext 
    {
      
            public PASContext(): base("PASYSTEM")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public PASContext(string connectionString) : base(connectionString)
        {

        }
        
        public DbSet<DepartmentEntity> Departments { set; get; }
        public DbSet<AchievementsEntity> Achievements { set; get; }
        public DbSet<EmployeeEntity> Employees { set; get; }
        public DbSet<ProjectEntity> Projects { set; get; }
        public DbSet<RoleEntity> Roles { set; get; }
        public DbSet<SiteStatisticsEntity> SiteStatistics { set; get; }
        public DbSet<TaskEntity> Tasks { set; get; }
        public DbSet<WorkStatisticsEntity> WorkStatistics { set; get; }

    }
}

