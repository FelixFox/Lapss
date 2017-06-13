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
    class DepartmentsRepository:IRepository<DepartmentEntity>
    {
       

            private PASContext db;

            public DepartmentsRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<DepartmentEntity> GetList()
            {
                return db.Departments;
            }

            public DepartmentEntity Get(int id)
            {
                return db.Departments.Find(id);
            }

            public void Add(DepartmentEntity item)
            {
                db.Departments.Add(item);
            }

            public void Update(DepartmentEntity item, DepartmentEntity newItem)
            {
                db.Entry(item).State = EntityState.Modified;
            }

            public IEnumerable<DepartmentEntity> Find(Func<DepartmentEntity, Boolean> predicate)
            {
                return db.Departments.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
                DepartmentEntity a = db.Departments.Find(id);
                if (a != null)
                    db.Departments.Remove(a);
            }
        }
    }

