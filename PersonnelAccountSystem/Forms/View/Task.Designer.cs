namespace Forms.User
{
    partial class Task
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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reassign = new System.Windows.Forms.Button();
            this.toggleProgress = new System.Windows.Forms.Button();
            this.closeTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.createTask = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(124, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(133, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 60);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "USer comments on task";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // reassign
            // 
            this.reassign.Location = new System.Drawing.Point(12, 213);
            this.reassign.Name = "reassign";
            this.reassign.Size = new System.Drawing.Size(75, 37);
            this.reassign.TabIndex = 3;
            this.reassign.Text = "Reassign task";
            this.reassign.UseVisualStyleBackColor = true;
            this.reassign.Click += new System.EventHandler(this.button1_Click);
            // 
            // toggleProgress
            // 
            this.toggleProgress.Location = new System.Drawing.Point(90, 213);
            this.toggleProgress.Name = "toggleProgress";
            this.toggleProgress.Size = new System.Drawing.Size(75, 37);
            this.toggleProgress.TabIndex = 4;
            this.toggleProgress.Text = "Start/stop progress";
            this.toggleProgress.UseVisualStyleBackColor = true;
            this.toggleProgress.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeTask
            // 
            this.closeTask.Location = new System.Drawing.Point(171, 213);
            this.closeTask.Name = "closeTask";
            this.closeTask.Size = new System.Drawing.Size(75, 37);
            this.closeTask.TabIndex = 5;
            this.closeTask.Text = "Close task";
            this.closeTask.UseVisualStyleBackColor = true;
            this.closeTask.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "task description";
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(252, 213);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(75, 37);
            this.createTask.TabIndex = 7;
            this.createTask.Text = "Create task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Main menu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.createTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeTask);
            this.Controls.Add(this.toggleProgress);
            this.Controls.Add(this.reassign);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task";
            this.Text = "Current task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button reassign;
        private System.Windows.Forms.Button toggleProgress;
        private System.Windows.Forms.Button closeTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Button button5;
    }
}