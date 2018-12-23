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
            this.add_user.Location = new System.Drawing.Point(547, 12);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(125, 30);
            this.add_user.TabIndex = 1;
            this.add_user.Text = "Add user";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_event
            // 
            this.Add_event.Location = new System.Drawing.Point(547, 48);
            this.Add_event.Name = "Add_event";
            this.Add_event.Size = new System.Drawing.Size(125, 30);
            this.Add_event.TabIndex = 2;
            this.Add_event.Text = "Add event";
            this.Add_event.UseVisualStyleBackColor = true;
            this.Add_event.Click += new System.EventHandler(this.button2_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.Location = new System.Drawing.Point(547, 84);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(125, 30);
            this.Profile_btn.TabIndex = 3;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.UseVisualStyleBackColor = true;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // BBorad_btn
            // 
            this.BBorad_btn.Location = new System.Drawing.Point(547, 120);
            this.BBorad_btn.Name = "BBorad_btn";
            this.BBorad_btn.Size = new System.Drawing.Size(125, 30);
            this.BBorad_btn.TabIndex = 4;
            this.BBorad_btn.Text = "Bulletin Board";
            this.BBorad_btn.UseVisualStyleBackColor = true;
            this.BBorad_btn.Click += new System.EventHandler(this.BBorad_btn_Click);
            // 
            // fixed_btn
            // 
            this.fixed_btn.Location = new System.Drawing.Point(547, 156);
            this.fixed_btn.Name = "fixed_btn";
            this.fixed_btn.Size = new System.Drawing.Size(125, 30);
            this.fixed_btn.TabIndex = 5;
            this.fixed_btn.Text = "Fixed Schedule";
            this.fixed_btn.UseVisualStyleBackColor = true;
            this.fixed_btn.Click += new System.EventHandler(this.fixed_btn_Click_1);
            // 
            // contact_page_btn
            // 
            this.contact_page_btn.Location = new System.Drawing.Point(547, 192);
            this.contact_page_btn.Name = "contact_page_btn";
            this.contact_page_btn.Size = new System.Drawing.Size(125, 30);
            this.contact_page_btn.TabIndex = 6;
            this.contact_page_btn.Text = "Contact Page";
            this.contact_page_btn.UseVisualStyleBackColor = true;
            // 
            // public_event_btn
            // 
            this.public_event_btn.Location = new System.Drawing.Point(547, 228);
            this.public_event_btn.Name = "public_event_btn";
            this.public_event_btn.Size = new System.Drawing.Size(125, 30);
            this.public_event_btn.TabIndex = 7;
            this.public_event_btn.Text = "Public Event";
            this.public_event_btn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(547, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "Login Report";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(547, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 9;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // motd
            // 
            this.motd.BackColor = System.Drawing.Color.Transparent;
            this.motd.BackgroundImage = global::main_screen.Properties.Resources.bBoard;
            this.motd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motd.Controls.Add(this.motd_txt);
            this.motd.ForeColor = System.Drawing.Color.AliceBlue;
            this.motd.Location = new System.Drawing.Point(252, 228);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(289, 221);
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
            // ManagerCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
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
    }
}