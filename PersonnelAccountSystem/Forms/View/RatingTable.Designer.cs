namespace Forms.View
{
    partial class RatingTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HPpoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonusPts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.Employee,
            this.Total,
            this.WorkHours,
            this.HPpoints,
            this.BonusPts});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 215);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.MinimumWidth = 30;
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 30;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 150;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 75;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 75;
            // 
            // WorkHours
            // 
            this.WorkHours.HeaderText = "WorkHours";
            this.WorkHours.MinimumWidth = 65;
            this.WorkHours.Name = "WorkHours";
            this.WorkHours.ReadOnly = true;
            this.WorkHours.Width = 65;
            // 
            // HPpoints
            // 
            this.HPpoints.HeaderText = "HPpoints";
            this.HPpoints.MinimumWidth = 65;
            this.HPpoints.Name = "HPpoints";
            this.HPpoints.ReadOnly = true;
            this.HPpoints.Width = 65;
            // 
            // BonusPts
            // 
            this.BonusPts.HeaderText = "BonusPts";
            this.BonusPts.MinimumWidth = 65;
            this.BonusPts.Name = "BonusPts";
            this.BonusPts.ReadOnly = true;
            this.BonusPts.Width = 65;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RaingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RaingTable";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn HPpoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonusPts;
        private System.Windows.Forms.Button button1;
    }
}