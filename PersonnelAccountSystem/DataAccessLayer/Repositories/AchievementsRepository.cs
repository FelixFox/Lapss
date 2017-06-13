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
     class AchievementsRepository:IRepository<AchievementsEntity>
    {

            private PASContext db;

            public AchievementsRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<AchievementsEntity> GetList()
            {
                return db.Achievements;
            }

            public AchievementsEntity Get(int id)
            {
                return db.Achievements.Find(id);
            }

            public void Add(AchievementsEntity item)
            {
                db.Achievements.Add(item);
            }

            public void Update(AchievementsEntity item, AchievementsEntity NewItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<AchievementsEntity> Find(Func<AchievementsEntity, Boolean> predicate)
            {
                return db.Achievements.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
            AchievementsEntity a = db.Achievements.Find(id);
                if (a != null)
                    db.Achievements.Remove(a);
            }
        }
    }

