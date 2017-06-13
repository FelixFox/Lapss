using PersonnelAccountSystem.DataAccessLayer.Context;
using PersonnelAccountSystem.DataAccessLayer.Interfaces;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Repositories
{
    class PASUnitOfWork:IUnitOfWork
    {




        private PASContext db;

        private AchievementsRepository achievementRepository;
        private DepartmentsRepository departmentsRepository;
        private EmployeeRepository employeeRepository;
        private ProjectsRepository projectsRepository;
        private RolesRepository rolesRepository;
        private SiteStatisticsRepository siteStatisticsRepository;
        private TasksRepository tasksRepository;
        private WorkStatisticsRepository workStatisticsRepository;
        


        public PASUnitOfWork(string connectionString)
            {
                db = new PASContext(connectionString);
            }

            public IRepository<AchievementsEntity> Achievements
            {
                get
                {
                    if (achievementRepository == null)
                    {
                        achievementRepository = new AchievementsRepository(db);
                     }
                    return achievementRepository;
                }
            }



            public IRepository<DepartmentEntity> Departments
            {
                get
                {
                        if (departmentsRepository == null)
                        {
                         departmentsRepository = new DepartmentsRepository(db);
                        }
                       
                    return departmentsRepository;
                }
            }


        public IRepository<EmployeeEntity> Employees
        {
            get
            {
                if (employeeRepository == null)
                {
                    employeeRepository = new EmployeeRepository(db);
                }
                return employeeRepository;
            }
        }

        public IRepository<ProjectEntity> Projects
        {
            get
            {
                if (projectsRepository == null)
                {
                    projectsRepository = new ProjectsRepository(db);
                }
                return projectsRepository;
            }
        }

        public IRepository<RoleEntity> Roles
        {
            get
            {
                if (rolesRepository == null)
                {
                    rolesRepository = new RolesRepository(db);
                }
                return rolesRepository;
            }
        }

        public IRepository<SiteStatisticsEntity> SiteStatistics
        {
            get
            {
                if (siteStatisticsRepository == null)
                {
                    siteStatisticsRepository = new SiteStatisticsRepository(db);
                }
                return siteStatisticsRepository;
            }
        }


        public IRepository<TaskEntity> Tasks
        {
            get
            {
                if (tasksRepository == null)
                {
                    tasksRepository = new TasksRepository(db);
                }
                return tasksRepository;
            }
        }

        public IRepository<WorkStatisticsEntity> WorkStatistics
        {
            get
            {
                if (workStatisticsRepository == null)
                {
                    workStatisticsRepository = new WorkStatisticsRepository(db);
                }
                return workStatisticsRepository;
            }
        }

        public void Save()
            {
                db.SaveChanges();
            }

            private bool disposed = false;

            public virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                    this.disposed = true;
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

    }

