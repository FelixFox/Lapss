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
    class WorkStatisticsRepository : IRepository<WorkStatisticsEntity>
    {

        

            private PASContext db;

            public WorkStatisticsRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<WorkStatisticsEntity> GetList()
            {
                return db.WorkStatistics;
            }

            public WorkStatisticsEntity Get(int id)
            {
                return db.WorkStatistics.Find(id);
            }

            public void Add(WorkStatisticsEntity item)
            {
                db.WorkStatistics.Add(item);
            }

            public void Update(WorkStatisticsEntity item, WorkStatisticsEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<WorkStatisticsEntity> Find(Func<WorkStatisticsEntity, Boolean> predicate)
            {
                return db.WorkStatistics.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                WorkStatisticsEntity a = db.WorkStatistics.Find(id);
                if (a != null)
                    db.WorkStatistics.Remove(a);
            }
        }
    }

