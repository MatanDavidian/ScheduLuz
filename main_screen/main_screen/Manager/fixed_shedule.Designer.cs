namespace main_screen.Manager
{
    partial class fixed_schedule
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
            this.teachers_lst = new System.Windows.Forms.ListBox();
            this.teacher_name_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schedule = new System.Windows.Forms.DataGridView();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profassionORclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new System.Windows.Forms.Button();
            this.days = new System.Windows.Forms.ComboBox();
            this.return_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // teachers_lst
            // 
            this.teachers_lst.FormattingEnabled = true;
            this.teachers_lst.Location = new System.Drawing.Point(6, 58);
            this.teachers_lst.Name = "teachers_lst";
            this.teachers_lst.Size = new System.Drawing.Size(239, 82);
            this.teachers_lst.Sorted = true;
            this.teachers_lst.TabIndex = 9;
            this.teachers_lst.SelectedIndexChanged += new System.EventHandler(this.student_lst_SelectedIndexChanged);
            // 
            // teacher_name_txt
            // 
            this.teacher_name_txt.Location = new System.Drawing.Point(6, 42);
            this.teacher_name_txt.Name = "teacher_name_txt";
            this.teacher_name_txt.Size = new System.Drawing.Size(239, 20);
            this.teacher_name_txt.TabIndex = 8;
            this.teacher_name_txt.TextChanged += new System.EventHandler(this.to_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachers_lst);
            this.groupBox1.Controls.Add(this.teacher_name_txt);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // schedule
            // 
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTime,
            this.endTime,
            this.profassionORclass});
            this.schedule.Location = new System.Drawing.Point(290, 99);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(344, 245);
            this.schedule.TabIndex = 11;
            this.schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Starts:";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 50;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End:";
            this.endTime.Name = "endTime";
            this.endTime.Width = 50;
            // 
            // profassionORclass
            // 
            this.profassionORclass.HeaderText = "Class:";
            this.profassionORclass.Name = "profassionORclass";
            this.profassionORclass.Width = 200;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(559, 350);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // days
            // 
            this.days.FormattingEnabled = true;
            this.days.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.days.Location = new System.Drawing.Point(291, 57);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(121, 21);
            this.days.TabIndex = 13;
            this.days.SelectedIndexChanged += new System.EventHandler(this.days_SelectedIndexChanged);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(13, 415);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 14;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            // 
            // fixed_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.days);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.groupBox1);
            this.Name = "fixed_schedule";
            this.Text = "Fixed Schedule";
            this.Load += new System.EventHandler(this.fixed_schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teachers_lst;
        private System.Windows.Forms.TextBox teacher_name_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn profassionORclass;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox days;
        private System.Windows.Forms.Button return_btn;
    }
}