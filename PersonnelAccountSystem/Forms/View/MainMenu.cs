using Forms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.User
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();

            if (this.checkManager.Checked) 
                new ManagerInfo().Show();
            else
                new Info().Show();
        }

        private void taskList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TaskList().Show();
        }

        private void compInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CompanyInfo().Show();
        }

        private void currentTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void checkManager_CheckedChanged(object sender, EventArgs e)
        {
            rating.Visible = this.checkManager.Checked;
        }

        private void rating_Click(object sender, EventArgs e)
        {
            new RatingTable().Show();
        }
    }
}
