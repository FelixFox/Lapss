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
    class SiteStatisticsRepository : IRepository<SiteStatisticsEntity>
    {
    
            private PASContext db;

            public SiteStatisticsRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<SiteStatisticsEntity> GetList()
            {
                return db.SiteStatistics;
            }

            public SiteStatisticsEntity Get(int id)
            {
                return db.SiteStatistics.Find(id);
            }

            public void Add(SiteStatisticsEntity item)
            {
                db.SiteStatistics.Add(item);
            }

            public void Update(SiteStatisticsEntity item, SiteStatisticsEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<SiteStatisticsEntity> Find(Func<SiteStatisticsEntity, Boolean> predicate)
            {
                return db.SiteStatistics.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                SiteStatisticsEntity a = db.SiteStatistics.Find(id);
                if (a != null)
                    db.SiteStatistics.Remove(a);
            }
        }
    }


