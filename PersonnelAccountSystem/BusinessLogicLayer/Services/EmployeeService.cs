using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.BusinessLogicLayer.Interaces;
using PersonnelAccountSystem.DataAccessLayer.Models;
using PersonnelAccountSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelAccountSystem.BusinessLogicLayer.Services
{

    public class EmployeeService:IEmployeeService
    {
        // PASUnitOfWork uof;
        /*using (AptekaDBContext db = new AptekaDBContext())
            {
                var entity = db.Apteks.Find(oldValues.ID_apteka);
    db.Entry(entity).CurrentValues.SetValues(newValues);
                db.SaveChanges();

                return true;
            }

            return false;*/
        PASUnitOfWork uof;
        public EmployeeService(string connectionString)
        {
            //this.conString = connectionString;
            uof = new PASUnitOfWork(connectionString);

        }
        public  bool ChangeEmployeeInfo(int id, EmployeeDTO newInfo)
        {
            
                try
                {
                    EmployeeEntity newEntity = Mappers.EmployeeMapper.Map(newInfo);
                    var entity = uof.Employees.Get(id);
                    uof.Employees.Update(entity, newEntity);
                    uof.Save();
                
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                
            
        }

        public bool CreateNewEmployee(EmployeeDTO newEmployee)
        {
            try
            {
                EmployeeEntity item = Mappers.EmployeeMapper.Map(newEmployee);
                uof.Employees.Add(item);
                uof.Save();
                
                return true;
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        public bool DeleteEmployee(int id)
        {
            //try
            //{
                uof.Employees.Remove(id);
                uof.Save();
                return true ;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return false;
           // }
            
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    uof.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            try
            {
                IEnumerable<EmployeeEntity> entityList;
                entityList= uof.Employees.GetList();
                List<EmployeeDTO> dtoList=new List<EmployeeDTO>();
                foreach(EmployeeEntity em in entityList)
                {
                    dtoList.Add(Mappers.EmployeeMapper.Map(em));
                }
                IEnumerable<EmployeeDTO> result = dtoList;
                return result; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public EmployeeDTO GetEmployeeInfo(int id)
        {
            try
            {
                EmployeeDTO item = Mappers.EmployeeMapper.Map(uof.Employees.Get(id));
               if (item!=null)
                return item;
               else throw new Exception("NULL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
