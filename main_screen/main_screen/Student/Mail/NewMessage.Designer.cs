namespace main_screen.Student.Mail
{
    partial class NewMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.subject_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.student_lst = new System.Windows.Forms.ListBox();
            this.msg_txt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // subject_txt
            // 
            this.subject_txt.Location = new System.Drawing.Point(69, 29);
            this.subject_txt.Name = "subject_txt";
            this.subject_txt.Size = new System.Drawing.Size(250, 20);
            this.subject_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(69, 55);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(250, 20);
            this.to_txt.TabIndex = 4;
            this.to_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // student_lst
            // 
            this.student_lst.FormattingEnabled = true;
            this.student_lst.Location = new System.Drawing.Point(69, 72);
            this.student_lst.Name = "student_lst";
            this.student_lst.Size = new System.Drawing.Size(250, 95);
            this.student_lst.Sorted = true;
            this.student_lst.TabIndex = 5;
            this.student_lst.SelectedIndexChanged += new System.EventHandler(this.student_lst_SelectedIndexChanged);
            // 
            // msg_txt
            // 
            this.msg_txt.Location = new System.Drawing.Point(69, 204);
            this.msg_txt.Name = "msg_txt";
            this.msg_txt.Size = new System.Drawing.Size(371, 195);
            this.msg_txt.TabIndex = 6;
            this.msg_txt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(365, 415);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 8;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(13, 415);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 9;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msg_txt);
            this.Controls.Add(this.student_lst);
            this.Controls.Add(this.to_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject_txt);
            this.Controls.Add(this.label1);
            this.Name = "NewMessage";
            this.Text = "NewMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subject_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.ListBox student_lst;
        private System.Windows.Forms.RichTextBox msg_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button return_btn;
    }
}