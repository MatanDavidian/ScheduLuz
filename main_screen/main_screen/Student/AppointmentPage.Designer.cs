namespace main_screen.Student
{
    partial class AppointmentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentPage));
            this.title = new System.Windows.Forms.Label();
            this.choose_teacher = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Maroon;
            this.title.Location = new System.Drawing.Point(19, 9);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(340, 39);
            this.title.TabIndex = 6;
            this.title.Text = "Schedule a meeting";
            // 
            // choose_teacher
            // 
            this.choose_teacher.AutoSize = true;
            this.choose_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.choose_teacher.Location = new System.Drawing.Point(50, 76);
            this.choose_teacher.Name = "choose_teacher";
            this.choose_teacher.Size = new System.Drawing.Size(132, 16);
            this.choose_teacher.TabIndex = 7;
            this.choose_teacher.Text = "choose a teacher:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(198, 72);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(161, 20);
            this.teacher_name.TabIndex = 8;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(393, 70);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(87, 22);
            this.submit.TabIndex = 9;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(403, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 79;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(53, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 78;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.teacher_name);
            this.Controls.Add(this.choose_teacher);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentPage";
            this.Text = "AppointmentPage";
            this.Load += new System.EventHandler(this.AppointmentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label choose_teacher;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}