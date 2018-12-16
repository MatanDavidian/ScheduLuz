namespace main_screen.Student
{
    partial class MyDearDairy
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
            this.return_btn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.day_txt = new System.Windows.Forms.RichTextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.date_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(12, 415);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 0;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // day_txt
            // 
            this.day_txt.Enabled = false;
            this.day_txt.Location = new System.Drawing.Point(12, 49);
            this.day_txt.Name = "day_txt";
            this.day_txt.Size = new System.Drawing.Size(389, 298);
            this.day_txt.TabIndex = 2;
            this.day_txt.Text = "";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(326, 353);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(326, 398);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 23);
            this.print_btn.TabIndex = 4;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(12, 353);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(555, 193);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 23);
            this.view_btn.TabIndex = 6;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(13, 18);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(35, 13);
            this.date_lbl.TabIndex = 7;
            this.date_lbl.Text = "label1";
            // 
            // MyDearDairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.day_txt);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.return_btn);
            this.Name = "MyDearDairy";
            this.Text = "MyDearDairy";
            this.Load += new System.EventHandler(this.MyDearDairy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox day_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Label date_lbl;
    }
}