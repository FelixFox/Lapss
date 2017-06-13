namespace Forms.User
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.compInfo = new System.Windows.Forms.LinkLabel();
            this.stats = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.Button();
            this.currentTask = new System.Windows.Forms.Button();
            this.checkManager = new System.Windows.Forms.CheckBox();
            this.rating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main menu";
            // 
            // compInfo
            // 
            this.compInfo.AutoSize = true;
            this.compInfo.Location = new System.Drawing.Point(98, 232);
            this.compInfo.Name = "compInfo";
            this.compInfo.Size = new System.Drawing.Size(71, 13);
            this.compInfo.TabIndex = 2;
            this.compInfo.TabStop = true;
            this.compInfo.Text = "Company info";
            this.compInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.compInfo_LinkClicked);
            // 
            // stats
            // 
            this.stats.Location = new System.Drawing.Point(58, 49);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(157, 43);
            this.stats.TabIndex = 3;
            this.stats.Text = "Statistics";
            this.stats.UseVisualStyleBackColor = true;
            this.stats.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskList
            // 
            this.taskList.Location = new System.Drawing.Point(58, 98);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(157, 44);
            this.taskList.TabIndex = 4;
            this.taskList.Text = "Task list";
            this.taskList.UseVisualStyleBackColor = true;
            this.taskList.Click += new System.EventHandler(this.taskList_Click);
            // 
            // currentTask
            // 
            this.currentTask.Location = new System.Drawing.Point(58, 148);
            this.currentTask.Name = "currentTask";
            this.currentTask.Size = new System.Drawing.Size(157, 45);
            this.currentTask.TabIndex = 6;
            this.currentTask.Text = "Current task";
            this.currentTask.UseVisualStyleBackColor = true;
            this.currentTask.Click += new System.EventHandler(this.currentTask_Click);
            // 
            // checkManager
            // 
            this.checkManager.AutoSize = true;
            this.checkManager.Location = new System.Drawing.Point(12, 232);
            this.checkManager.Name = "checkManager";
            this.checkManager.Size = new System.Drawing.Size(68, 17);
            this.checkManager.TabIndex = 7;
            this.checkManager.Text = "Manager";
            this.checkManager.UseVisualStyleBackColor = true;
            this.checkManager.CheckedChanged += new System.EventHandler(this.checkManager_CheckedChanged);
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(58, 199);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(157, 27);
            this.rating.TabIndex = 8;
            this.rating.Text = "Rating";
            this.rating.UseVisualStyleBackColor = true;
            this.rating.Visible = false;
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.checkManager);
            this.Controls.Add(this.currentTask);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.compInfo);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel compInfo;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button taskList;
        private System.Windows.Forms.Button currentTask;
        private System.Windows.Forms.CheckBox checkManager;
        private System.Windows.Forms.Button rating;
    }
}