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
    class EmployeeRepository:IRepository<EmployeeEntity>
    {

            private PASContext db;

            public EmployeeRepository(PASContext context)
            {
                this.db = context;
            }

            public IEnumerable<EmployeeEntity> GetList()
            {
            return db.Employees;
                
            }

            public EmployeeEntity Get(int id)
            {
                db.Employees.Load();
                return db.Employees.Find(id);
            }

            public void Add(EmployeeEntity item)
            {
            try
            {
                db.Employees.Add(item);
                db.Entry(item).State = EntityState.Added;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

            public void Update(EmployeeEntity item, EmployeeEntity newItem)
            {
            try
            {
                var entity = db.Employees.Find(item.ID);
                db.Entry(entity).CurrentValues.SetValues(newItem);
              
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
                
            }

            public IEnumerable<EmployeeEntity> Find(Func<EmployeeEntity, Boolean> predicate)
            {
                return db.Employees.Where(predicate).ToList();
            }

            public void Remove(int id)
            {
            try
            {

                db.Employees.Include(req => req.Projects).Include(req => req.WorkStatistics).Include(req => req.SiteStatistics).Include(req => req.Achievements).Include(req => req.Tasks).Load();
                EmployeeEntity a = db.Employees.Find(id);


                if (a != null)
                {
                    foreach (ProjectEntity p in a.Projects)
                    {
                        p.ID_leader = null;

                    }


                    a.WorkStatistics.ToList().ForEach(p => db.WorkStatistics.Remove(p));
                    a.SiteStatistics.ToList().ForEach(p => db.SiteStatistics.Remove(p));
                    a.Tasks.ToList().ForEach(p => db.Tasks.Remove(p));
                    a.Achievements.ToList().ForEach(p => db.Achievements.Remove(p));
                    //foreach (WorkStatisticsEntity p in a.WorkStatistics)
                    //{
                    //    db.WorkStatistics.Remove(p);
                    //
                    //}

                    /*foreach (SiteStatisticsEntity p in a.SiteStatistics)
                    {
                        db.SiteStatistics.Remove(p);

                    }*/
                    db.Employees.Remove(a);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
                    
            }
        }
    

