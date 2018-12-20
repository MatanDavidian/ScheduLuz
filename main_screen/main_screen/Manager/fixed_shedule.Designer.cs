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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fixed_schedule));
            this.teachers_lst = new System.Windows.Forms.ListBox();
            this.teacher_name_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.DataGridView();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profassionORclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new System.Windows.Forms.Button();
            this.days = new System.Windows.Forms.ComboBox();
            this.return_btn = new System.Windows.Forms.Button();
            this.teacher_rad_btn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classnum_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grade_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachers_lst
            // 
            this.teachers_lst.FormattingEnabled = true;
            this.teachers_lst.Location = new System.Drawing.Point(64, 58);
            this.teachers_lst.Name = "teachers_lst";
            this.teachers_lst.Size = new System.Drawing.Size(181, 82);
            this.teachers_lst.Sorted = true;
            this.teachers_lst.TabIndex = 9;
            this.teachers_lst.SelectedIndexChanged += new System.EventHandler(this.student_lst_SelectedIndexChanged);
            // 
            // teacher_name_txt
            // 
            this.teacher_name_txt.Location = new System.Drawing.Point(64, 42);
            this.teacher_name_txt.Name = "teacher_name_txt";
            this.teacher_name_txt.Size = new System.Drawing.Size(181, 20);
            this.teacher_name_txt.TabIndex = 8;
            this.teacher_name_txt.TextChanged += new System.EventHandler(this.to_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.teachers_lst);
            this.groupBox1.Controls.Add(this.teacher_name_txt);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(55, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // schedule
            // 
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTime,
            this.endTime,
            this.profassionORclass});
            this.schedule.Location = new System.Drawing.Point(333, 113);
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
            this.update_btn.Location = new System.Drawing.Point(602, 364);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // days
            // 
            this.days.Enabled = false;
            this.days.FormattingEnabled = true;
            this.days.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.days.Location = new System.Drawing.Point(334, 71);
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
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click_1);
            // 
            // teacher_rad_btn
            // 
            this.teacher_rad_btn.AutoSize = true;
            this.teacher_rad_btn.Location = new System.Drawing.Point(35, 74);
            this.teacher_rad_btn.Name = "teacher_rad_btn";
            this.teacher_rad_btn.Size = new System.Drawing.Size(14, 13);
            this.teacher_rad_btn.TabIndex = 15;
            this.teacher_rad_btn.TabStop = true;
            this.teacher_rad_btn.UseVisualStyleBackColor = true;
            this.teacher_rad_btn.CheckedChanged += new System.EventHandler(this.teacher_rad_btn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 241);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.classnum_cb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grade_cb);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(55, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 107);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class";
            // 
            // classnum_cb
            // 
            this.classnum_cb.FormattingEnabled = true;
            this.classnum_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.classnum_cb.Location = new System.Drawing.Point(64, 69);
            this.classnum_cb.Name = "classnum_cb";
            this.classnum_cb.Size = new System.Drawing.Size(65, 21);
            this.classnum_cb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade:";
            // 
            // grade_cb
            // 
            this.grade_cb.FormattingEnabled = true;
            this.grade_cb.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.grade_cb.Location = new System.Drawing.Point(64, 19);
            this.grade_cb.Name = "grade_cb";
            this.grade_cb.Size = new System.Drawing.Size(65, 21);
            this.grade_cb.TabIndex = 0;
            // 
            // fixed_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.teacher_rad_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.days);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fixed_schedule";
            this.Text = "Fixed Schedule";
            this.Load += new System.EventHandler(this.fixed_schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton teacher_rad_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox classnum_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grade_cb;
    }
}