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
    class RolesRepository : IRepository<RoleEntity>
    {
       

            private PASContext db;

            public RolesRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<RoleEntity> GetList()
            {
                return db.Roles;
            }

            public RoleEntity Get(int id)
            {
                return db.Roles.Find(id);
            }

            public void Add(RoleEntity item)
            {
                db.Roles.Add(item);
            }

            public void Update(RoleEntity item, RoleEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<RoleEntity> Find(Func<RoleEntity, Boolean> predicate)
            {
                return db.Roles.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                RoleEntity a = db.Roles.Find(id);
                if (a != null)
                    db.Roles.Remove(a);
            }
        }
    }


