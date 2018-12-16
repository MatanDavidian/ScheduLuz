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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button9 = new System.Windows.Forms.Button();
            this.reception_hours = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.multi_studnt_event_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_event = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_done_btn = new System.Windows.Forms.Button();
            this.add_chklist_btn = new System.Windows.Forms.Button();
            this.add_chklist_txt = new System.Windows.Forms.TextBox();
            this.checklist = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 249);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(547, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // reception_hours
            // 
            this.reception_hours.Location = new System.Drawing.Point(547, 264);
            this.reception_hours.Name = "reception_hours";
            this.reception_hours.Size = new System.Drawing.Size(125, 30);
            this.reception_hours.TabIndex = 19;
            this.reception_hours.Text = "reception hours";
            this.reception_hours.UseVisualStyleBackColor = true;
            this.reception_hours.Click += new System.EventHandler(this.reception_hours_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(547, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // multi_studnt_event_btn
            // 
            this.multi_studnt_event_btn.Location = new System.Drawing.Point(547, 120);
            this.multi_studnt_event_btn.Name = "multi_studnt_event_btn";
            this.multi_studnt_event_btn.Size = new System.Drawing.Size(125, 30);
            this.multi_studnt_event_btn.TabIndex = 15;
            this.multi_studnt_event_btn.Text = "MultiStudent Event";
            this.multi_studnt_event_btn.UseVisualStyleBackColor = true;
            this.multi_studnt_event_btn.Click += new System.EventHandler(this.multi_studnt_event_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Location = new System.Drawing.Point(547, 84);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(125, 30);
            this.profile_btn.TabIndex = 14;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Send Mail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_event
            // 
            this.add_event.Location = new System.Drawing.Point(547, 12);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(125, 30);
            this.add_event.TabIndex = 12;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = true;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_done_btn);
            this.groupBox1.Controls.Add(this.add_chklist_btn);
            this.groupBox1.Controls.Add(this.add_chklist_txt);
            this.groupBox1.Controls.Add(this.checklist);
            this.groupBox1.Location = new System.Drawing.Point(251, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 435);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checklist";
            // 
            // clear_done_btn
            // 
            this.clear_done_btn.Location = new System.Drawing.Point(6, 406);
            this.clear_done_btn.Name = "clear_done_btn";
            this.clear_done_btn.Size = new System.Drawing.Size(223, 23);
            this.clear_done_btn.TabIndex = 3;
            this.clear_done_btn.Text = "Clear Checked";
            this.clear_done_btn.UseVisualStyleBackColor = true;
            this.clear_done_btn.Click += new System.EventHandler(this.clear_done_btn_Click);
            // 
            // add_chklist_btn
            // 
            this.add_chklist_btn.Location = new System.Drawing.Point(174, 32);
            this.add_chklist_btn.Name = "add_chklist_btn";
            this.add_chklist_btn.Size = new System.Drawing.Size(55, 23);
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
            this.add_chklist_txt.Size = new System.Drawing.Size(162, 20);
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
            this.checklist.Size = new System.Drawing.Size(223, 330);
            this.checklist.TabIndex = 0;
            // 
            // TeacherCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.reception_hours);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.multi_studnt_event_btn);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherCalander";
            this.Text = "Calander - Teacher";
            this.Load += new System.EventHandler(this.TeacherCalander_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button reception_hours;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
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
    }
}