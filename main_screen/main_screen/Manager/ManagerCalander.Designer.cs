namespace main_screen
{
    partial class ManagerCalander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCalander));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.add_user = new System.Windows.Forms.Button();
            this.Add_event = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.BBorad_btn = new System.Windows.Forms.Button();
            this.fixed_btn = new System.Windows.Forms.Button();
            this.contact_page_btn = new System.Windows.Forms.Button();
            this.public_event_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.motd = new System.Windows.Forms.GroupBox();
            this.motd_txt = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.motd.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.Transparent;
            this.add_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_user.BackgroundImage")));
            this.add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_user.FlatAppearance.BorderSize = 0;
            this.add_user.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Location = new System.Drawing.Point(547, 12);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(125, 30);
            this.add_user.TabIndex = 1;
            this.add_user.Text = "Add user";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_event
            // 
            this.Add_event.BackColor = System.Drawing.Color.Transparent;
            this.Add_event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_event.BackgroundImage")));
            this.Add_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_event.FlatAppearance.BorderSize = 0;
            this.Add_event.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Add_event.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Add_event.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_event.Location = new System.Drawing.Point(547, 48);
            this.Add_event.Name = "Add_event";
            this.Add_event.Size = new System.Drawing.Size(125, 30);
            this.Add_event.TabIndex = 2;
            this.Add_event.Text = "Add event";
            this.Add_event.UseVisualStyleBackColor = false;
            this.Add_event.Click += new System.EventHandler(this.button2_Click);
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
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_btn.Location = new System.Drawing.Point(547, 84);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(125, 30);
            this.Profile_btn.TabIndex = 3;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.UseVisualStyleBackColor = false;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // BBorad_btn
            // 
            this.BBorad_btn.BackColor = System.Drawing.Color.Transparent;
            this.BBorad_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBorad_btn.BackgroundImage")));
            this.BBorad_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBorad_btn.FlatAppearance.BorderSize = 0;
            this.BBorad_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BBorad_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BBorad_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBorad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorad_btn.Location = new System.Drawing.Point(547, 120);
            this.BBorad_btn.Name = "BBorad_btn";
            this.BBorad_btn.Size = new System.Drawing.Size(125, 30);
            this.BBorad_btn.TabIndex = 4;
            this.BBorad_btn.Text = "Bulletin Board";
            this.BBorad_btn.UseVisualStyleBackColor = false;
            this.BBorad_btn.Click += new System.EventHandler(this.BBorad_btn_Click);
            // 
            // fixed_btn
            // 
            this.fixed_btn.BackColor = System.Drawing.Color.Transparent;
            this.fixed_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fixed_btn.BackgroundImage")));
            this.fixed_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fixed_btn.FlatAppearance.BorderSize = 0;
            this.fixed_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fixed_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fixed_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fixed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixed_btn.Location = new System.Drawing.Point(547, 156);
            this.fixed_btn.Name = "fixed_btn";
            this.fixed_btn.Size = new System.Drawing.Size(125, 30);
            this.fixed_btn.TabIndex = 5;
            this.fixed_btn.Text = "Fixed Schedule";
            this.fixed_btn.UseVisualStyleBackColor = false;
            this.fixed_btn.Click += new System.EventHandler(this.fixed_btn_Click_1);
            // 
            // contact_page_btn
            // 
            this.contact_page_btn.BackColor = System.Drawing.Color.Transparent;
            this.contact_page_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact_page_btn.BackgroundImage")));
            this.contact_page_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contact_page_btn.FlatAppearance.BorderSize = 0;
            this.contact_page_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.contact_page_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.contact_page_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.contact_page_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact_page_btn.Location = new System.Drawing.Point(547, 192);
            this.contact_page_btn.Name = "contact_page_btn";
            this.contact_page_btn.Size = new System.Drawing.Size(125, 30);
            this.contact_page_btn.TabIndex = 6;
            this.contact_page_btn.Text = "Contact Page";
            this.contact_page_btn.UseVisualStyleBackColor = false;
            // 
            // public_event_btn
            // 
            this.public_event_btn.BackColor = System.Drawing.Color.Transparent;
            this.public_event_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("public_event_btn.BackgroundImage")));
            this.public_event_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.public_event_btn.FlatAppearance.BorderSize = 0;
            this.public_event_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.public_event_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.public_event_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.public_event_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.public_event_btn.Location = new System.Drawing.Point(547, 228);
            this.public_event_btn.Name = "public_event_btn";
            this.public_event_btn.Size = new System.Drawing.Size(125, 30);
            this.public_event_btn.TabIndex = 7;
            this.public_event_btn.Text = "Public Event";
            this.public_event_btn.UseVisualStyleBackColor = false;
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
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(547, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "Login Report";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            this.button9.Location = new System.Drawing.Point(547, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 9;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // motd
            // 
            this.motd.BackColor = System.Drawing.Color.Transparent;
            this.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            this.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motd.Controls.Add(this.motd_txt);
            this.motd.ForeColor = System.Drawing.Color.AliceBlue;
            this.motd.Location = new System.Drawing.Point(245, 246);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(289, 203);
            this.motd.TabIndex = 12;
            this.motd.TabStop = false;
            this.motd.Text = "Message Of the Day";
            this.motd.Enter += new System.EventHandler(this.motd_Enter);
            // 
            // motd_txt
            // 
            this.motd_txt.AutoSize = true;
            this.motd_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motd_txt.Location = new System.Drawing.Point(15, 16);
            this.motd_txt.Name = "motd_txt";
            this.motd_txt.Size = new System.Drawing.Size(104, 13);
            this.motd_txt.TabIndex = 0;
            this.motd_txt.Text = "Message Of the Day";
            this.motd_txt.Click += new System.EventHandler(this.motd_txt_Click);
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
            this.listView1.TabIndex = 22;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(547, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "approve cancellation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ManagerCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.motd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.public_event_btn);
            this.Controls.Add(this.contact_page_btn);
            this.Controls.Add(this.fixed_btn);
            this.Controls.Add(this.BBorad_btn);
            this.Controls.Add(this.Profile_btn);
            this.Controls.Add(this.Add_event);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.monthCalendar1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerCalander";
            this.Text = "Calander - Manager";
            this.Load += new System.EventHandler(this.ManagerCalander_Load);
            this.motd.ResumeLayout(false);
            this.motd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Button Add_event;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button BBorad_btn;
        private System.Windows.Forms.Button fixed_btn;
        private System.Windows.Forms.Button contact_page_btn;
        private System.Windows.Forms.Button public_event_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox motd;
        private System.Windows.Forms.Label motd_txt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Starts;
        private System.Windows.Forms.ColumnHeader Ends;
        private System.Windows.Forms.Button button1;
    }
}