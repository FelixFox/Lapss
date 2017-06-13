using PersonnelAccountSystem.DataAccessLayer.Context;
using PersonnelAccountSystem.DataAccessLayer.Interfaces;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelAccountSystem.DataAccessLayer.Repositories
{
    class ProjectsRepository:IRepository<ProjectEntity>
    {

            private PASContext db;

            public ProjectsRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<ProjectEntity> GetList()
            {
                try
                {
                    return db.Projects.Include(q => q.Employee).Include(q => q.ProjectTasks);
                }
                 catch (Exception ex)

                 {
                     MessageBox.Show(ex.Message);
                     return null;
                 }    
                
            }

            public ProjectEntity Get(int id)
            {
                return db.Projects.Find(id);
            }

            public void Add(ProjectEntity item)
            {
                db.Projects.Add(item);
            }

            public void Update(ProjectEntity item, ProjectEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<ProjectEntity> Find(Func<ProjectEntity, Boolean> predicate)
            {
                return db.Projects.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                ProjectEntity a = db.Projects.Find(id);
                if (a != null)
                    db.Projects.Remove(a);
            }
        }
    }
