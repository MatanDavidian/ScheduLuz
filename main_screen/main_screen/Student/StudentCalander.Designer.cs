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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contact_page = new System.Windows.Forms.Button();
            this.add_event = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(27, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 350);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(317, 344);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 50);
            this.button9.TabIndex = 20;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(317, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 50);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(480, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 50);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(639, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contact_page
            // 
            this.contact_page.Location = new System.Drawing.Point(639, 112);
            this.contact_page.Name = "contact_page";
            this.contact_page.Size = new System.Drawing.Size(125, 50);
            this.contact_page.TabIndex = 13;
            this.contact_page.Text = "contact page";
            this.contact_page.UseVisualStyleBackColor = true;
            this.contact_page.Click += new System.EventHandler(this.contact_page_Click);
            // 
            // add_event
            // 
            this.add_event.Location = new System.Drawing.Point(639, 41);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(125, 50);
            this.add_event.TabIndex = 12;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = true;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(317, 74);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // StudentCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.contact_page);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "StudentCalander";
            this.Text = "Calander - Student";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button contact_page;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}