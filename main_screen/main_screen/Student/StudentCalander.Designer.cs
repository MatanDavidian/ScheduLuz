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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.add_hw_btn = new System.Windows.Forms.Button();
            this.my_dear_diary_btn = new System.Windows.Forms.Button();
            this.mail_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.contact_page = new System.Windows.Forms.Button();
            this.add_event = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.motd = new System.Windows.Forms.GroupBox();
            this.motd_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.motd.SuspendLayout();
            this.SuspendLayout();
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
            this.listView1.TabIndex = 21;
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
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(547, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(547, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 30);
            this.button8.TabIndex = 19;
            this.button8.Text = "Schedule a meeting";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // add_hw_btn
            // 
            this.add_hw_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_hw_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_hw_btn.BackgroundImage")));
            this.add_hw_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_hw_btn.FlatAppearance.BorderSize = 0;
            this.add_hw_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_hw_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_hw_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_hw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_hw_btn.Location = new System.Drawing.Point(547, 228);
            this.add_hw_btn.Name = "add_hw_btn";
            this.add_hw_btn.Size = new System.Drawing.Size(125, 30);
            this.add_hw_btn.TabIndex = 18;
            this.add_hw_btn.Text = "Add H.W";
            this.add_hw_btn.UseVisualStyleBackColor = false;
            this.add_hw_btn.Click += new System.EventHandler(this.add_hw_btn_Click);
            // 
            // my_dear_diary_btn
            // 
            this.my_dear_diary_btn.BackColor = System.Drawing.Color.Transparent;
            this.my_dear_diary_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("my_dear_diary_btn.BackgroundImage")));
            this.my_dear_diary_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.my_dear_diary_btn.FlatAppearance.BorderSize = 0;
            this.my_dear_diary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.my_dear_diary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.my_dear_diary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.my_dear_diary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.my_dear_diary_btn.Location = new System.Drawing.Point(547, 192);
            this.my_dear_diary_btn.Name = "my_dear_diary_btn";
            this.my_dear_diary_btn.Size = new System.Drawing.Size(125, 30);
            this.my_dear_diary_btn.TabIndex = 17;
            this.my_dear_diary_btn.Text = "My Dear Diary";
            this.my_dear_diary_btn.UseVisualStyleBackColor = false;
            this.my_dear_diary_btn.Click += new System.EventHandler(this.my_dear_diary_btn_Click);
            // 
            // mail_btn
            // 
            this.mail_btn.BackColor = System.Drawing.Color.Transparent;
            this.mail_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mail_btn.BackgroundImage")));
            this.mail_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mail_btn.FlatAppearance.BorderSize = 0;
            this.mail_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.mail_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mail_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mail_btn.Location = new System.Drawing.Point(547, 156);
            this.mail_btn.Name = "mail_btn";
            this.mail_btn.Size = new System.Drawing.Size(125, 30);
            this.mail_btn.TabIndex = 16;
            this.mail_btn.Text = "Mail";
            this.mail_btn.UseVisualStyleBackColor = false;
            this.mail_btn.Click += new System.EventHandler(this.mail_btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(547, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Multiplayer event";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.BackColor = System.Drawing.Color.Transparent;
            this.Profile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profile_btn.BackgroundImage")));
            this.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profile_btn.FlatAppearance.BorderSize = 0;
            this.Profile_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Profile_btn.Location = new System.Drawing.Point(547, 84);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(125, 30);
            this.Profile_btn.TabIndex = 14;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.UseVisualStyleBackColor = false;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // contact_page
            // 
            this.contact_page.BackColor = System.Drawing.Color.Transparent;
            this.contact_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact_page.BackgroundImage")));
            this.contact_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contact_page.FlatAppearance.BorderSize = 0;
            this.contact_page.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.contact_page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.contact_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.contact_page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contact_page.Location = new System.Drawing.Point(547, 48);
            this.contact_page.Name = "contact_page";
            this.contact_page.Size = new System.Drawing.Size(125, 30);
            this.contact_page.TabIndex = 13;
            this.contact_page.Text = "Contact Page";
            this.contact_page.UseVisualStyleBackColor = false;
            this.contact_page.Click += new System.EventHandler(this.contact_page_Click);
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
            this.add_event.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_event.Location = new System.Drawing.Point(547, 12);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(125, 30);
            this.add_event.TabIndex = 12;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = false;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // motd
            // 
            this.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            this.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motd.Controls.Add(this.motd_txt);
            this.motd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motd.ForeColor = System.Drawing.Color.AliceBlue;
            this.motd.Location = new System.Drawing.Point(245, 26);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(295, 221);
            this.motd.TabIndex = 22;
            this.motd.TabStop = false;
            this.motd.Text = "Message Of the Day";
            // 
            // motd_txt
            // 
            this.motd_txt.AutoSize = true;
            this.motd_txt.BackColor = System.Drawing.Color.Transparent;
            this.motd_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motd_txt.Location = new System.Drawing.Point(19, 17);
            this.motd_txt.Name = "motd_txt";
            this.motd_txt.Size = new System.Drawing.Size(104, 13);
            this.motd_txt.TabIndex = 0;
            this.motd_txt.Text = "Message Of the Day";
            this.motd_txt.Click += new System.EventHandler(this.motd_txt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(547, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Answer Surveys";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.add_hw_btn);
            this.Controls.Add(this.my_dear_diary_btn);
            this.Controls.Add(this.mail_btn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Profile_btn);
            this.Controls.Add(this.contact_page);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.monthCalendar1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentCalander";
            this.Text = "Calander - Student";
            this.Load += new System.EventHandler(this.StudentCalander_Load);
            this.motd.ResumeLayout(false);
            this.motd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button add_hw_btn;
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
    }
}