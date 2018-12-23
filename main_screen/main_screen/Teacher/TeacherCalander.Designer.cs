namespace main_screen
{
    partial class TeacherCalander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherCalander));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_done_btn = new System.Windows.Forms.Button();
            this.add_chklist_btn = new System.Windows.Forms.Button();
            this.add_chklist_txt = new System.Windows.Forms.TextBox();
            this.checklist = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surveys = new System.Windows.Forms.Button();
            this.motd = new System.Windows.Forms.GroupBox();
            this.motd_txt = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.reception_hours = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.view_contacts_btn = new System.Windows.Forms.Button();
            this.watch_stundent_schedule = new System.Windows.Forms.Button();
            this.multi_studnt_event_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_event = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.motd.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.clear_done_btn);
            this.groupBox1.Controls.Add(this.add_chklist_btn);
            this.groupBox1.Controls.Add(this.add_chklist_txt);
            this.groupBox1.Controls.Add(this.checklist);
            this.groupBox1.Location = new System.Drawing.Point(482, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 292);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checklist";
            // 
            // clear_done_btn
            // 
            this.clear_done_btn.BackgroundImage = global::main_screen.Properties.Resources.orangebtn;
            this.clear_done_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_done_btn.FlatAppearance.BorderSize = 0;
            this.clear_done_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clear_done_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clear_done_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clear_done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_done_btn.Location = new System.Drawing.Point(6, 244);
            this.clear_done_btn.Name = "clear_done_btn";
            this.clear_done_btn.Size = new System.Drawing.Size(206, 41);
            this.clear_done_btn.TabIndex = 3;
            this.clear_done_btn.Text = "Clear Checked";
            this.clear_done_btn.UseVisualStyleBackColor = true;
            this.clear_done_btn.Click += new System.EventHandler(this.clear_done_btn_Click);
            // 
            // add_chklist_btn
            // 
            this.add_chklist_btn.Location = new System.Drawing.Point(163, 32);
            this.add_chklist_btn.Name = "add_chklist_btn";
            this.add_chklist_btn.Size = new System.Drawing.Size(49, 23);
            this.add_chklist_btn.TabIndex = 2;
            this.add_chklist_btn.Text = "Add";
            this.add_chklist_btn.UseVisualStyleBackColor = true;
            this.add_chklist_btn.Click += new System.EventHandler(this.add_chklist_btn_Click);
            // 
            // add_chklist_txt
            // 
            this.add_chklist_txt.BackColor = System.Drawing.SystemColors.Control;
            this.add_chklist_txt.Location = new System.Drawing.Point(6, 34);
            this.add_chklist_txt.Name = "add_chklist_txt";
            this.add_chklist_txt.Size = new System.Drawing.Size(154, 20);
            this.add_chklist_txt.TabIndex = 1;
            // 
            // checklist
            // 
            this.checklist.BackColor = System.Drawing.SystemColors.Control;
            this.checklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checklist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checklist.FormattingEnabled = true;
            this.checklist.Location = new System.Drawing.Point(6, 60);
            this.checklist.Name = "checklist";
            this.checklist.Size = new System.Drawing.Size(196, 195);
            this.checklist.TabIndex = 0;
            this.checklist.SelectedIndexChanged += new System.EventHandler(this.checklist_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Starts,
            this.Ends});
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 249);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 110;
            // 
            // Starts
            // 
            this.Starts.Text = "Starts";
            // 
            // Ends
            // 
            this.Ends.Text = "Ends";
            this.Ends.Width = 62;
            // 
            // Surveys
            // 
            this.Surveys.BackColor = System.Drawing.Color.Transparent;
            this.Surveys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Surveys.BackgroundImage")));
            this.Surveys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Surveys.FlatAppearance.BorderSize = 0;
            this.Surveys.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Surveys.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Surveys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Surveys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Surveys.Location = new System.Drawing.Point(706, 310);
            this.Surveys.Name = "Surveys";
            this.Surveys.Size = new System.Drawing.Size(125, 30);
            this.Surveys.TabIndex = 25;
            this.Surveys.Text = "Surveys";
            this.Surveys.UseVisualStyleBackColor = false;
            this.Surveys.Click += new System.EventHandler(this.Surveys_Click);
            // 
            // motd
            // 
            this.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            this.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motd.Controls.Add(this.motd_txt);
            this.motd.ForeColor = System.Drawing.Color.AliceBlue;
            this.motd.Location = new System.Drawing.Point(245, 228);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(231, 221);
            this.motd.TabIndex = 23;
            this.motd.TabStop = false;
            this.motd.Text = "Message Of the Day";
            // 
            // motd_txt
            // 
            this.motd_txt.AutoSize = true;
            this.motd_txt.BackColor = System.Drawing.Color.Transparent;
            this.motd_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motd_txt.Location = new System.Drawing.Point(7, 20);
            this.motd_txt.Name = "motd_txt";
            this.motd_txt.Size = new System.Drawing.Size(104, 13);
            this.motd_txt.TabIndex = 0;
            this.motd_txt.Text = "Message Of the Day";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(706, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // reception_hours
            // 
            this.reception_hours.BackColor = System.Drawing.Color.Transparent;
            this.reception_hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reception_hours.BackgroundImage")));
            this.reception_hours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reception_hours.FlatAppearance.BorderSize = 0;
            this.reception_hours.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.reception_hours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reception_hours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reception_hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reception_hours.Location = new System.Drawing.Point(706, 274);
            this.reception_hours.Name = "reception_hours";
            this.reception_hours.Size = new System.Drawing.Size(125, 30);
            this.reception_hours.TabIndex = 19;
            this.reception_hours.Text = "reception hours";
            this.reception_hours.UseVisualStyleBackColor = false;
            this.reception_hours.Click += new System.EventHandler(this.reception_hours_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(706, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // view_contacts_btn
            // 
            this.view_contacts_btn.BackColor = System.Drawing.Color.Transparent;
            this.view_contacts_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_contacts_btn.BackgroundImage")));
            this.view_contacts_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_contacts_btn.FlatAppearance.BorderSize = 0;
            this.view_contacts_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.view_contacts_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.view_contacts_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.view_contacts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_contacts_btn.Location = new System.Drawing.Point(706, 202);
            this.view_contacts_btn.Name = "view_contacts_btn";
            this.view_contacts_btn.Size = new System.Drawing.Size(125, 30);
            this.view_contacts_btn.TabIndex = 17;
            this.view_contacts_btn.Text = "Contacts Page";
            this.view_contacts_btn.UseVisualStyleBackColor = false;
            this.view_contacts_btn.Click += new System.EventHandler(this.view_contacts_btn_Click);
            // 
            // watch_stundent_schedule
            // 
            this.watch_stundent_schedule.BackColor = System.Drawing.Color.Transparent;
            this.watch_stundent_schedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("watch_stundent_schedule.BackgroundImage")));
            this.watch_stundent_schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.watch_stundent_schedule.FlatAppearance.BorderSize = 0;
            this.watch_stundent_schedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.watch_stundent_schedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.watch_stundent_schedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.watch_stundent_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch_stundent_schedule.Location = new System.Drawing.Point(706, 156);
            this.watch_stundent_schedule.Name = "watch_stundent_schedule";
            this.watch_stundent_schedule.Size = new System.Drawing.Size(125, 40);
            this.watch_stundent_schedule.TabIndex = 16;
            this.watch_stundent_schedule.Text = "Watch Student Schedule";
            this.watch_stundent_schedule.UseVisualStyleBackColor = false;
            this.watch_stundent_schedule.Click += new System.EventHandler(this.watch_stundent_schedule_Click);
            // 
            // multi_studnt_event_btn
            // 
            this.multi_studnt_event_btn.BackColor = System.Drawing.Color.Transparent;
            this.multi_studnt_event_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multi_studnt_event_btn.BackgroundImage")));
            this.multi_studnt_event_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multi_studnt_event_btn.FlatAppearance.BorderSize = 0;
            this.multi_studnt_event_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.multi_studnt_event_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multi_studnt_event_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multi_studnt_event_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multi_studnt_event_btn.Location = new System.Drawing.Point(706, 120);
            this.multi_studnt_event_btn.Name = "multi_studnt_event_btn";
            this.multi_studnt_event_btn.Size = new System.Drawing.Size(125, 30);
            this.multi_studnt_event_btn.TabIndex = 15;
            this.multi_studnt_event_btn.Text = "MultiStudent Event";
            this.multi_studnt_event_btn.UseVisualStyleBackColor = false;
            this.multi_studnt_event_btn.Click += new System.EventHandler(this.multi_studnt_event_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.Transparent;
            this.profile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_btn.BackgroundImage")));
            this.profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_btn.FlatAppearance.BorderSize = 0;
            this.profile_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_btn.Location = new System.Drawing.Point(706, 84);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(125, 30);
            this.profile_btn.TabIndex = 14;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(706, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Send Mail";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_event
            // 
            this.add_event.BackColor = System.Drawing.Color.Transparent;
            this.add_event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_event.BackgroundImage")));
            this.add_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_event.FlatAppearance.BorderSize = 0;
            this.add_event.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_event.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_event.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_event.Location = new System.Drawing.Point(706, 12);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(125, 30);
            this.add_event.TabIndex = 12;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = false;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // TeacherCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 461);
            this.Controls.Add(this.Surveys);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.motd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.reception_hours);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.view_contacts_btn);
            this.Controls.Add(this.watch_stundent_schedule);
            this.Controls.Add(this.multi_studnt_event_btn);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.monthCalendar1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherCalander";
            this.Text = "Calander - Teacher";
            this.Load += new System.EventHandler(this.TeacherCalander_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.motd.ResumeLayout(false);
            this.motd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button reception_hours;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button view_contacts_btn;
        private System.Windows.Forms.Button watch_stundent_schedule;
        private System.Windows.Forms.Button multi_studnt_event_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_chklist_btn;
        private System.Windows.Forms.TextBox add_chklist_txt;
        private System.Windows.Forms.CheckedListBox checklist;
        private System.Windows.Forms.Button clear_done_btn;
        private System.Windows.Forms.GroupBox motd;
        private System.Windows.Forms.Label motd_txt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Starts;
        private System.Windows.Forms.ColumnHeader Ends;
        private System.Windows.Forms.Button Surveys;
    }
}