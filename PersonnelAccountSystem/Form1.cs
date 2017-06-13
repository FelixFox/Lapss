using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using PersonnelAccountSystem.BusinessLogicLayer.Services;
using PersonnelAccountSystem.DataAccessLayer.Context;
using PersonnelAccountSystem.DataAccessLayer.Models;
using PersonnelAccountSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelAccountSystem
{
    public partial class Form1 : Form
    {
        private string connectionString;


        public Form1()
        {
            InitializeComponent();
            connectionString = "PASYSTEM";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* using (EmployeeService service = new EmployeeService("PASYSTEM"))
             {
                 service.DeleteEmployee(1);
                 List<EmployeeDTO> employes = service.GetAllEmployees().ToList<EmployeeDTO>();
                 EmployeeDTO ex = service.GetEmployeeInfo(1);
                 //richTextBox1.Text += ex.Name + "\n";
                 foreach (EmployeeDTO em in employes)
                 {
                     richTextBox1.Text += em.Name + "\n";
                 }
             }*/
            using (EmployeeService service = new EmployeeService(connectionString))
            {
                EmployeeDTO emp = new EmployeeDTO
                {
                    Name = "Employee1",
                    Birth = "21/12/1990",
                    Start_of_working = "20/04/2017",
                    ID_role = 1,
                    CurrentSalary = 1234,
                    IDDepartment = 1,
                    Number = 123456789,
                    Score = 0,
                    Summary_Work_Hours = 0
                };

                if (service.CreateNewEmployee(emp))
                    MessageBox.Show("Данные успешно добавлены");
            }
               

                

        }
    }
}
