﻿namespace main_screen
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(547, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(547, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 249);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.Location = new System.Drawing.Point(316, 24);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(35, 13);
            this.UserName_lbl.TabIndex = 11;
            this.UserName_lbl.Text = "label1";
            this.UserName_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.UserName_lbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Profile_btn);
            this.Controls.Add(this.Add_event);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerCalander";
            this.Text = "Calander - Manager";
            this.Load += new System.EventHandler(this.ManagerCalander_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Button Add_event;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label UserName_lbl;
    }
}