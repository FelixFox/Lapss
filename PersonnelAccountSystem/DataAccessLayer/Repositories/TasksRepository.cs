using PersonnelAccountSystem.DataAccessLayer.Context;
using PersonnelAccountSystem.DataAccessLayer.Interfaces;
using PersonnelAccountSystem.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Repositories
{
    class TasksRepository : IRepository<TaskEntity>
    {
       

            private PASContext db;

            public TasksRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<TaskEntity> GetList()
            {
                return db.Tasks;
            }

            public TaskEntity Get(int id)
            {
                return db.Tasks.Find(id);
            }

            public void Add(TaskEntity item)
            {
                db.Tasks.Add(item);
            }

            public void Update(TaskEntity item, TaskEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<TaskEntity> Find(Func<TaskEntity, Boolean> predicate)
            {
                return db.Tasks.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                TaskEntity a = db.Tasks.Find(id);
                if (a != null)
                    db.Tasks.Remove(a);
            }
        }
    }

