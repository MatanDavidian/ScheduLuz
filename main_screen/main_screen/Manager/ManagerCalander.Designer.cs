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
            ManagerCalander managerCalander = this;
            managerCalander.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            managerCalander.add_user = new System.Windows.Forms.Button();
            managerCalander.Add_event = new System.Windows.Forms.Button();
            managerCalander.Profile_btn = new System.Windows.Forms.Button();
            managerCalander.BBorad_btn = new System.Windows.Forms.Button();
            managerCalander.fixed_btn = new System.Windows.Forms.Button();
            managerCalander.contact_page_btn = new System.Windows.Forms.Button();
            managerCalander.public_event_btn = new System.Windows.Forms.Button();
            managerCalander.button8 = new System.Windows.Forms.Button();
            managerCalander.button9 = new System.Windows.Forms.Button();
            managerCalander.motd = new System.Windows.Forms.GroupBox();
            managerCalander.motd_txt = new System.Windows.Forms.Label();
            managerCalander.listView1 = new System.Windows.Forms.ListView();
            managerCalander.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            managerCalander.Starts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            managerCalander.Ends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            managerCalander.motd.SuspendLayout();
            managerCalander.SuspendLayout();
            // 
            // monthCalendar1
            // 
            managerCalander.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            managerCalander.monthCalendar1.Name = "monthCalendar1";
            managerCalander.monthCalendar1.TabIndex = 0;
            managerCalander.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(managerCalander.monthCalendar1_DateChanged);
            // 
            // add_user
            // 
            managerCalander.add_user.BackColor = System.Drawing.Color.Transparent;
            managerCalander.add_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_user.BackgroundImage")));
            managerCalander.add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.add_user.FlatAppearance.BorderSize = 0;
            managerCalander.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.add_user.Location = new System.Drawing.Point(547, 12);
            managerCalander.add_user.Name = "add_user";
            managerCalander.add_user.Size = new System.Drawing.Size(125, 30);
            managerCalander.add_user.TabIndex = 1;
            managerCalander.add_user.Text = "Add user";
            managerCalander.add_user.UseVisualStyleBackColor = false;
            managerCalander.add_user.Click += new System.EventHandler(managerCalander.button1_Click);
            // 
            // Add_event
            // 
            managerCalander.Add_event.BackColor = System.Drawing.Color.Transparent;
            managerCalander.Add_event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_event.BackgroundImage")));
            managerCalander.Add_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.Add_event.FlatAppearance.BorderSize = 0;
            managerCalander.Add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.Add_event.Location = new System.Drawing.Point(547, 48);
            managerCalander.Add_event.Name = "Add_event";
            managerCalander.Add_event.Size = new System.Drawing.Size(125, 30);
            managerCalander.Add_event.TabIndex = 2;
            managerCalander.Add_event.Text = "Add event";
            managerCalander.Add_event.UseVisualStyleBackColor = false;
            managerCalander.Add_event.Click += new System.EventHandler(managerCalander.button2_Click);
            // 
            // Profile_btn
            // 
            managerCalander.Profile_btn.BackColor = System.Drawing.Color.Transparent;
            managerCalander.Profile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profile_btn.BackgroundImage")));
            managerCalander.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.Profile_btn.FlatAppearance.BorderSize = 0;
            managerCalander.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.Profile_btn.Location = new System.Drawing.Point(547, 84);
            managerCalander.Profile_btn.Name = "Profile_btn";
            managerCalander.Profile_btn.Size = new System.Drawing.Size(125, 30);
            managerCalander.Profile_btn.TabIndex = 3;
            managerCalander.Profile_btn.Text = "Profile";
            managerCalander.Profile_btn.UseVisualStyleBackColor = false;
            managerCalander.Profile_btn.Click += new System.EventHandler(managerCalander.Profile_btn_Click);
            // 
            // BBorad_btn
            // 
            managerCalander.BBorad_btn.BackColor = System.Drawing.Color.Transparent;
            managerCalander.BBorad_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBorad_btn.BackgroundImage")));
            managerCalander.BBorad_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.BBorad_btn.FlatAppearance.BorderSize = 0;
            managerCalander.BBorad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.BBorad_btn.Location = new System.Drawing.Point(547, 120);
            managerCalander.BBorad_btn.Name = "BBorad_btn";
            managerCalander.BBorad_btn.Size = new System.Drawing.Size(125, 30);
            managerCalander.BBorad_btn.TabIndex = 4;
            managerCalander.BBorad_btn.Text = "Bulletin Board";
            managerCalander.BBorad_btn.UseVisualStyleBackColor = false;
            managerCalander.BBorad_btn.Click += new System.EventHandler(managerCalander.BBorad_btn_Click);
            // 
            // fixed_btn
            // 
            managerCalander.fixed_btn.BackColor = System.Drawing.Color.Transparent;
            managerCalander.fixed_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fixed_btn.BackgroundImage")));
            managerCalander.fixed_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.fixed_btn.FlatAppearance.BorderSize = 0;
            managerCalander.fixed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.fixed_btn.Location = new System.Drawing.Point(547, 156);
            managerCalander.fixed_btn.Name = "fixed_btn";
            managerCalander.fixed_btn.Size = new System.Drawing.Size(125, 30);
            managerCalander.fixed_btn.TabIndex = 5;
            managerCalander.fixed_btn.Text = "Fixed Schedule";
            managerCalander.fixed_btn.UseVisualStyleBackColor = false;
            managerCalander.fixed_btn.Click += new System.EventHandler(managerCalander.fixed_btn_Click_1);
            // 
            // contact_page_btn
            // 
            managerCalander.contact_page_btn.BackColor = System.Drawing.Color.Transparent;
            managerCalander.contact_page_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact_page_btn.BackgroundImage")));
            managerCalander.contact_page_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.contact_page_btn.FlatAppearance.BorderSize = 0;
            managerCalander.contact_page_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.contact_page_btn.Location = new System.Drawing.Point(547, 192);
            managerCalander.contact_page_btn.Name = "contact_page_btn";
            managerCalander.contact_page_btn.Size = new System.Drawing.Size(125, 30);
            managerCalander.contact_page_btn.TabIndex = 6;
            managerCalander.contact_page_btn.Text = "Contact Page";
            managerCalander.contact_page_btn.UseVisualStyleBackColor = false;
            // 
            // public_event_btn
            // 
            managerCalander.public_event_btn.BackColor = System.Drawing.Color.Transparent;
            managerCalander.public_event_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("public_event_btn.BackgroundImage")));
            managerCalander.public_event_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.public_event_btn.FlatAppearance.BorderSize = 0;
            managerCalander.public_event_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.public_event_btn.Location = new System.Drawing.Point(547, 228);
            managerCalander.public_event_btn.Name = "public_event_btn";
            managerCalander.public_event_btn.Size = new System.Drawing.Size(125, 30);
            managerCalander.public_event_btn.TabIndex = 7;
            managerCalander.public_event_btn.Text = "Public Event";
            managerCalander.public_event_btn.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            managerCalander.button8.BackColor = System.Drawing.Color.Transparent;
            managerCalander.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            managerCalander.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.button8.FlatAppearance.BorderSize = 0;
            managerCalander.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.button8.Location = new System.Drawing.Point(547, 264);
            managerCalander.button8.Name = "button8";
            managerCalander.button8.Size = new System.Drawing.Size(125, 30);
            managerCalander.button8.TabIndex = 8;
            managerCalander.button8.Text = "Login Report";
            managerCalander.button8.UseVisualStyleBackColor = false;
            managerCalander.button8.Click += new System.EventHandler(managerCalander.button8_Click);
            // 
            // button9
            // 
            managerCalander.button9.BackColor = System.Drawing.Color.Transparent;
            managerCalander.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            managerCalander.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.button9.FlatAppearance.BorderSize = 0;
            managerCalander.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            managerCalander.button9.Location = new System.Drawing.Point(547, 419);
            managerCalander.button9.Name = "button9";
            managerCalander.button9.Size = new System.Drawing.Size(125, 30);
            managerCalander.button9.TabIndex = 9;
            managerCalander.button9.Text = "Log out";
            managerCalander.button9.UseVisualStyleBackColor = false;
            managerCalander.button9.Click += new System.EventHandler(managerCalander.button9_Click);
            // 
            // motd
            // 
            managerCalander.motd.BackColor = System.Drawing.Color.Transparent;
            managerCalander.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            managerCalander.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.motd.Controls.Add(managerCalander.motd_txt);
            managerCalander.motd.ForeColor = System.Drawing.Color.AliceBlue;
            managerCalander.motd.Location = new System.Drawing.Point(252, 26);
            managerCalander.motd.Name = "motd";
            managerCalander.motd.Size = new System.Drawing.Size(289, 203);
            managerCalander.motd.TabIndex = 12;
            managerCalander.motd.TabStop = false;
            managerCalander.motd.Text = "Message Of the Day";
            managerCalander.motd.Enter += new System.EventHandler(managerCalander.motd_Enter);
            // 
            // motd_txt
            // 
            managerCalander.motd_txt.AutoSize = true;
            managerCalander.motd_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            managerCalander.motd_txt.Location = new System.Drawing.Point(15, 16);
            managerCalander.motd_txt.Name = "motd_txt";
            managerCalander.motd_txt.Size = new System.Drawing.Size(104, 13);
            managerCalander.motd_txt.TabIndex = 0;
            managerCalander.motd_txt.Text = "Message Of the Day";
            managerCalander.motd_txt.Click += new System.EventHandler(managerCalander.motd_txt_Click);
            // 
            // listView1
            // 
            managerCalander.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            managerCalander.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            managerCalander.Title,
            managerCalander.Starts,
            managerCalander.Ends});
            managerCalander.listView1.Location = new System.Drawing.Point(12, 200);
            managerCalander.listView1.Name = "listView1";
            managerCalander.listView1.Size = new System.Drawing.Size(227, 249);
            managerCalander.listView1.TabIndex = 22;
            managerCalander.listView1.UseCompatibleStateImageBehavior = false;
            managerCalander.listView1.View = System.Windows.Forms.View.Details;
            managerCalander.listView1.SelectedIndexChanged += new System.EventHandler(managerCalander.listView1_SelectedIndexChanged);
            // 
            // Title
            // 
            managerCalander.Title.Text = "Title";
            managerCalander.Title.Width = 110;
            // 
            // Starts
            // 
            managerCalander.Starts.Text = "Starts";
            // 
            // Ends
            // 
            managerCalander.Ends.Text = "Ends";
            managerCalander.Ends.Width = 62;
            // 
            // ManagerCalander
            // 
            managerCalander.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            managerCalander.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            managerCalander.BackgroundImage = global::main_screen.Properties.Resources._1680;
            managerCalander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            managerCalander.ClientSize = new System.Drawing.Size(684, 461);
            managerCalander.Controls.Add(managerCalander.listView1);
            managerCalander.Controls.Add(managerCalander.motd);
            managerCalander.Controls.Add(managerCalander.button9);
            managerCalander.Controls.Add(managerCalander.button8);
            managerCalander.Controls.Add(managerCalander.public_event_btn);
            managerCalander.Controls.Add(managerCalander.contact_page_btn);
            managerCalander.Controls.Add(managerCalander.fixed_btn);
            managerCalander.Controls.Add(managerCalander.BBorad_btn);
            managerCalander.Controls.Add(managerCalander.Profile_btn);
            managerCalander.Controls.Add(managerCalander.Add_event);
            managerCalander.Controls.Add(managerCalander.add_user);
            managerCalander.Controls.Add(managerCalander.monthCalendar1);
            managerCalander.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            managerCalander.Name = "ManagerCalander";
            managerCalander.Text = "Calander - Manager";
            managerCalander.Load += new System.EventHandler(managerCalander.ManagerCalander_Load);
            managerCalander.motd.ResumeLayout(false);
            managerCalander.motd.PerformLayout();
            managerCalander.ResumeLayout(false);

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
    }
}