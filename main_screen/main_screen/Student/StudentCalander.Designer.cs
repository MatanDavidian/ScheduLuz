namespace main_screen
{
    partial class StudentCalander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCalander));
            StudentCalander studentCalander = this;
            studentCalander.listView1 = new System.Windows.Forms.ListView();
            studentCalander.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            studentCalander.Starts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            studentCalander.Ends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            studentCalander.button9 = new System.Windows.Forms.Button();
            studentCalander.button8 = new System.Windows.Forms.Button();
            studentCalander.button7 = new System.Windows.Forms.Button();
            studentCalander.my_dear_diary_btn = new System.Windows.Forms.Button();
            studentCalander.mail_btn = new System.Windows.Forms.Button();
            studentCalander.button4 = new System.Windows.Forms.Button();
            studentCalander.Profile_btn = new System.Windows.Forms.Button();
            studentCalander.contact_page = new System.Windows.Forms.Button();
            studentCalander.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            studentCalander.button1 = new System.Windows.Forms.Button();
            studentCalander.button2 = new System.Windows.Forms.Button();
            studentCalander.motd = new System.Windows.Forms.GroupBox();
            studentCalander.motd_txt = new System.Windows.Forms.Label();
            studentCalander.add_event = new System.Windows.Forms.Button();
            studentCalander.motd.SuspendLayout();
            studentCalander.SuspendLayout();
            // 
            // listView1
            // 
            studentCalander.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            studentCalander.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            studentCalander.Title,
            studentCalander.Starts,
            studentCalander.Ends});
            studentCalander.listView1.Location = new System.Drawing.Point(12, 200);
            studentCalander.listView1.Name = "listView1";
            studentCalander.listView1.Size = new System.Drawing.Size(227, 249);
            studentCalander.listView1.TabIndex = 21;
            studentCalander.listView1.UseCompatibleStateImageBehavior = false;
            studentCalander.listView1.View = System.Windows.Forms.View.Details;
            studentCalander.listView1.SelectedIndexChanged += new System.EventHandler(studentCalander.listView1_SelectedIndexChanged);
            // 
            // Title
            // 
            studentCalander.Title.Text = "Title";
            studentCalander.Title.Width = 110;
            // 
            // Starts
            // 
            studentCalander.Starts.Text = "Starts";
            // 
            // Ends
            // 
            studentCalander.Ends.Text = "Ends";
            studentCalander.Ends.Width = 62;
            // 
            // button9
            // 
            studentCalander.button9.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            studentCalander.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button9.FlatAppearance.BorderSize = 0;
            studentCalander.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button9.Location = new System.Drawing.Point(547, 419);
            studentCalander.button9.Name = "button9";
            studentCalander.button9.Size = new System.Drawing.Size(125, 30);
            studentCalander.button9.TabIndex = 20;
            studentCalander.button9.Text = "Log out";
            studentCalander.button9.UseVisualStyleBackColor = false;
            studentCalander.button9.Click += new System.EventHandler(studentCalander.button9_Click);
            // 
            // button8
            // 
            studentCalander.button8.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            studentCalander.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button8.FlatAppearance.BorderSize = 0;
            studentCalander.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button8.Location = new System.Drawing.Point(547, 264);
            studentCalander.button8.Name = "button8";
            studentCalander.button8.Size = new System.Drawing.Size(125, 30);
            studentCalander.button8.TabIndex = 19;
            studentCalander.button8.Text = "Schedule a meeting";
            studentCalander.button8.UseVisualStyleBackColor = false;
            studentCalander.button8.Click += new System.EventHandler(studentCalander.button8_Click);
            // 
            // button7
            // 
            studentCalander.button7.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            studentCalander.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button7.FlatAppearance.BorderSize = 0;
            studentCalander.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button7.Location = new System.Drawing.Point(547, 228);
            studentCalander.button7.Name = "button7";
            studentCalander.button7.Size = new System.Drawing.Size(125, 30);
            studentCalander.button7.TabIndex = 18;
            studentCalander.button7.Text = "button7";
            studentCalander.button7.UseVisualStyleBackColor = false;
            // 
            // my_dear_diary_btn
            // 
            studentCalander.my_dear_diary_btn.BackColor = System.Drawing.Color.Transparent;
            studentCalander.my_dear_diary_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("my_dear_diary_btn.BackgroundImage")));
            studentCalander.my_dear_diary_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.my_dear_diary_btn.FlatAppearance.BorderSize = 0;
            studentCalander.my_dear_diary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.my_dear_diary_btn.Location = new System.Drawing.Point(547, 192);
            studentCalander.my_dear_diary_btn.Name = "my_dear_diary_btn";
            studentCalander.my_dear_diary_btn.Size = new System.Drawing.Size(125, 30);
            studentCalander.my_dear_diary_btn.TabIndex = 17;
            studentCalander.my_dear_diary_btn.Text = "My Dear Diary";
            studentCalander.my_dear_diary_btn.UseVisualStyleBackColor = false;
            studentCalander.my_dear_diary_btn.Click += new System.EventHandler(studentCalander.my_dear_diary_btn_Click);
            // 
            // mail_btn
            // 
            studentCalander.mail_btn.BackColor = System.Drawing.Color.Transparent;
            studentCalander.mail_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mail_btn.BackgroundImage")));
            studentCalander.mail_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.mail_btn.FlatAppearance.BorderSize = 0;
            studentCalander.mail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.mail_btn.Location = new System.Drawing.Point(547, 156);
            studentCalander.mail_btn.Name = "mail_btn";
            studentCalander.mail_btn.Size = new System.Drawing.Size(125, 30);
            studentCalander.mail_btn.TabIndex = 16;
            studentCalander.mail_btn.Text = "Mail";
            studentCalander.mail_btn.UseVisualStyleBackColor = false;
            studentCalander.mail_btn.Click += new System.EventHandler(studentCalander.mail_btn_Click);
            // 
            // button4
            // 
            studentCalander.button4.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button4.BackgroundImage = global::main_screen.Properties.Resources.small_button_hi;
            studentCalander.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button4.FlatAppearance.BorderSize = 0;
            studentCalander.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button4.Location = new System.Drawing.Point(547, 120);
            studentCalander.button4.Name = "button4";
            studentCalander.button4.Size = new System.Drawing.Size(125, 30);
            studentCalander.button4.TabIndex = 15;
            studentCalander.button4.Text = "Multiplayer event";
            studentCalander.button4.UseVisualStyleBackColor = false;
            studentCalander.button4.Click += new System.EventHandler(studentCalander.button4_Click);
            // 
            // Profile_btn
            // 
            studentCalander.Profile_btn.BackColor = System.Drawing.Color.Transparent;
            studentCalander.Profile_btn.BackgroundImage = global::main_screen.Properties.Resources.small_button_hi;
            studentCalander.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.Profile_btn.FlatAppearance.BorderSize = 0;
            studentCalander.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.Profile_btn.Location = new System.Drawing.Point(547, 84);
            studentCalander.Profile_btn.Name = "Profile_btn";
            studentCalander.Profile_btn.Size = new System.Drawing.Size(125, 30);
            studentCalander.Profile_btn.TabIndex = 14;
            studentCalander.Profile_btn.Text = "Profile";
            studentCalander.Profile_btn.UseVisualStyleBackColor = false;
            studentCalander.Profile_btn.Click += new System.EventHandler(studentCalander.Profile_btn_Click);
            // 
            // contact_page
            // 
            studentCalander.contact_page.BackColor = System.Drawing.Color.Transparent;
            studentCalander.contact_page.BackgroundImage = global::main_screen.Properties.Resources.small_button_hi;
            studentCalander.contact_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.contact_page.FlatAppearance.BorderSize = 0;
            studentCalander.contact_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.contact_page.Location = new System.Drawing.Point(547, 48);
            studentCalander.contact_page.Name = "contact_page";
            studentCalander.contact_page.Size = new System.Drawing.Size(125, 30);
            studentCalander.contact_page.TabIndex = 13;
            studentCalander.contact_page.Text = "Contact Page";
            studentCalander.contact_page.UseVisualStyleBackColor = false;
            studentCalander.contact_page.Click += new System.EventHandler(studentCalander.contact_page_Click);
            // 
            // monthCalendar1
            // 
            studentCalander.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            studentCalander.monthCalendar1.Name = "monthCalendar1";
            studentCalander.monthCalendar1.TabIndex = 11;
            studentCalander.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(studentCalander.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            studentCalander.button1.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            studentCalander.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button1.FlatAppearance.BorderSize = 0;
            studentCalander.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button1.Location = new System.Drawing.Point(547, 300);
            studentCalander.button1.Name = "button1";
            studentCalander.button1.Size = new System.Drawing.Size(125, 30);
            studentCalander.button1.TabIndex = 23;
            studentCalander.button1.Text = "Answer Surveys";
            studentCalander.button1.UseVisualStyleBackColor = false;
            studentCalander.button1.Click += new System.EventHandler(studentCalander.button1_Click);
            // 
            // button2
            // 
            studentCalander.button2.BackColor = System.Drawing.Color.Transparent;
            studentCalander.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            studentCalander.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.button2.FlatAppearance.BorderSize = 0;
            studentCalander.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.button2.Location = new System.Drawing.Point(547, 336);
            studentCalander.button2.Name = "button2";
            studentCalander.button2.Size = new System.Drawing.Size(125, 30);
            studentCalander.button2.TabIndex = 24;
            studentCalander.button2.Text = "My schedule";
            studentCalander.button2.UseVisualStyleBackColor = false;
            studentCalander.button2.Click += new System.EventHandler(studentCalander.button2_Click);
            // 
            // motd
            // 
            studentCalander.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            studentCalander.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.motd.Controls.Add(studentCalander.motd_txt);
            studentCalander.motd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentCalander.motd.ForeColor = System.Drawing.Color.AliceBlue;
            studentCalander.motd.Location = new System.Drawing.Point(251, 26);
            studentCalander.motd.Name = "motd";
            studentCalander.motd.Size = new System.Drawing.Size(290, 211);
            studentCalander.motd.TabIndex = 22;
            studentCalander.motd.TabStop = false;
            studentCalander.motd.Text = "Message Of the Day";
            // 
            // motd_txt
            // 
            studentCalander.motd_txt.AutoSize = true;
            studentCalander.motd_txt.BackColor = System.Drawing.Color.Transparent;
            studentCalander.motd_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            studentCalander.motd_txt.Location = new System.Drawing.Point(19, 17);
            studentCalander.motd_txt.Name = "motd_txt";
            studentCalander.motd_txt.Size = new System.Drawing.Size(104, 13);
            studentCalander.motd_txt.TabIndex = 0;
            studentCalander.motd_txt.Text = "Message Of the Day";
            studentCalander.motd_txt.Click += new System.EventHandler(studentCalander.motd_txt_Click);
            // 
            // add_event
            // 
            studentCalander.add_event.BackColor = System.Drawing.Color.Transparent;
            studentCalander.add_event.BackgroundImage = global::main_screen.Properties.Resources.small_button_hi;
            studentCalander.add_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.add_event.FlatAppearance.BorderSize = 0;
            studentCalander.add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentCalander.add_event.Location = new System.Drawing.Point(547, 12);
            studentCalander.add_event.Name = "add_event";
            studentCalander.add_event.Size = new System.Drawing.Size(125, 30);
            studentCalander.add_event.TabIndex = 12;
            studentCalander.add_event.Text = "Add event";
            studentCalander.add_event.UseVisualStyleBackColor = false;
            studentCalander.add_event.Click += new System.EventHandler(studentCalander.add_event_Click);
            // 
            // StudentCalander
            // 
            studentCalander.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            studentCalander.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            studentCalander.BackgroundImage = global::main_screen.Properties.Resources._1680;
            studentCalander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            studentCalander.ClientSize = new System.Drawing.Size(684, 461);
            studentCalander.Controls.Add(studentCalander.button2);
            studentCalander.Controls.Add(studentCalander.button1);
            studentCalander.Controls.Add(studentCalander.motd);
            studentCalander.Controls.Add(studentCalander.listView1);
            studentCalander.Controls.Add(studentCalander.button9);
            studentCalander.Controls.Add(studentCalander.button8);
            studentCalander.Controls.Add(studentCalander.button7);
            studentCalander.Controls.Add(studentCalander.my_dear_diary_btn);
            studentCalander.Controls.Add(studentCalander.mail_btn);
            studentCalander.Controls.Add(studentCalander.button4);
            studentCalander.Controls.Add(studentCalander.Profile_btn);
            studentCalander.Controls.Add(studentCalander.contact_page);
            studentCalander.Controls.Add(studentCalander.add_event);
            studentCalander.Controls.Add(studentCalander.monthCalendar1);
            studentCalander.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            studentCalander.Name = "StudentCalander";
            studentCalander.Text = "Calander - Student";
            studentCalander.Load += new System.EventHandler(studentCalander.StudentCalander_Load);
            studentCalander.motd.ResumeLayout(false);
            studentCalander.motd.PerformLayout();
            studentCalander.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button my_dear_diary_btn;
        private System.Windows.Forms.Button mail_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button contact_page;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox motd;
        private System.Windows.Forms.Label motd_txt;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Starts;
        private System.Windows.Forms.ColumnHeader Ends;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}