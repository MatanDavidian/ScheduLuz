namespace main_screen.Student
{
    partial class Mail_form
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
            this.new_msg_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.msg_lst = new System.Windows.Forms.ListView();
            this.user_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sub_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // new_msg_btn
            // 
            this.new_msg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_msg_btn.FlatAppearance.BorderSize = 0;
            this.new_msg_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.new_msg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.new_msg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.new_msg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_msg_btn.Location = new System.Drawing.Point(12, 31);
            this.new_msg_btn.Name = "new_msg_btn";
            this.new_msg_btn.Size = new System.Drawing.Size(118, 23);
            this.new_msg_btn.TabIndex = 0;
            this.new_msg_btn.Text = "New Message";
            this.new_msg_btn.UseVisualStyleBackColor = true;
            this.new_msg_btn.Click += new System.EventHandler(this.new_msg_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Location = new System.Drawing.Point(12, 415);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // msg_lst
            // 
            this.msg_lst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.msg_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_header,
            this.sub_header,
            this.time,
            this.msg});
            this.msg_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lst.GridLines = true;
            this.msg_lst.Location = new System.Drawing.Point(165, 31);
            this.msg_lst.Name = "msg_lst";
            this.msg_lst.Size = new System.Drawing.Size(593, 394);
            this.msg_lst.TabIndex = 2;
            this.msg_lst.UseCompatibleStateImageBehavior = false;
            this.msg_lst.View = System.Windows.Forms.View.Details;
            this.msg_lst.SelectedIndexChanged += new System.EventHandler(this.msg_lst_SelectedIndexChanged);
            // 
            // user_header
            // 
            this.user_header.Text = "User";
            this.user_header.Width = 96;
            // 
            // sub_header
            // 
            this.sub_header.Text = "Subject";
            this.sub_header.Width = 118;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 110;
            // 
            // msg
            // 
            this.msg.Text = "Message";
            this.msg.Width = 500;
            // 
            // Mail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg_lst);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.new_msg_btn);
            this.Name = "Mail_form";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_msg_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.ListView msg_lst;
        private System.Windows.Forms.ColumnHeader sub_header;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader msg;
        public System.Windows.Forms.ColumnHeader user_header;
    }
}