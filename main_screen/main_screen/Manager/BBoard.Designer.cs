namespace main_screen.Manager
{
    partial class BBoard
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
            this.msg_txt = new System.Windows.Forms.RichTextBox();
            this.edit_last_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(13, 415);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 0;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click_1);
            // 
            // msg_txt
            // 
            this.msg_txt.Location = new System.Drawing.Point(13, 63);
            this.msg_txt.Name = "msg_txt";
            this.msg_txt.Size = new System.Drawing.Size(258, 254);
            this.msg_txt.TabIndex = 1;
            this.msg_txt.Text = "";
            // 
            // edit_last_btn
            // 
            this.edit_last_btn.Location = new System.Drawing.Point(13, 324);
            this.edit_last_btn.Name = "edit_last_btn";
            this.edit_last_btn.Size = new System.Drawing.Size(119, 23);
            this.edit_last_btn.TabIndex = 2;
            this.edit_last_btn.Text = "Edit Last Message";
            this.edit_last_btn.UseVisualStyleBackColor = true;
            this.edit_last_btn.Click += new System.EventHandler(this.edit_last_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_last_btn);
            this.Controls.Add(this.msg_txt);
            this.Controls.Add(this.return_btn);
            this.Name = "BBoard";
            this.Text = "Bulletin Board";
            this.Load += new System.EventHandler(this.BBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.RichTextBox msg_txt;
        private System.Windows.Forms.Button edit_last_btn;
        private System.Windows.Forms.Button button1;
    }
}