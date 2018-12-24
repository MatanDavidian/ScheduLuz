namespace main_screen.general_process
{
    partial class ManagerAndTeacher_view_contacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerAndTeacher_view_contacts));
            this.grade_cb = new System.Windows.Forms.ComboBox();
            this.class_num_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_btn = new System.Windows.Forms.Button();
            this.contacts_lv = new System.Windows.Forms.ListView();
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.private_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parent_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grade_cb
            // 
            this.grade_cb.FormattingEnabled = true;
            this.grade_cb.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.grade_cb.Location = new System.Drawing.Point(100, 35);
            this.grade_cb.Name = "grade_cb";
            this.grade_cb.Size = new System.Drawing.Size(57, 21);
            this.grade_cb.TabIndex = 0;
            // 
            // class_num_cb
            // 
            this.class_num_cb.FormattingEnabled = true;
            this.class_num_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "ALL"});
            this.class_num_cb.Location = new System.Drawing.Point(244, 35);
            this.class_num_cb.Name = "class_num_cb";
            this.class_num_cb.Size = new System.Drawing.Size(57, 21);
            this.class_num_cb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(163, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class Number:";
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.Transparent;
            this.view_btn.BackgroundImage = global::main_screen.Properties.Resources.greybtn;
            this.view_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_btn.FlatAppearance.BorderSize = 0;
            this.view_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.view_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Location = new System.Drawing.Point(370, 32);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 23);
            this.view_btn.TabIndex = 4;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // contacts_lv
            // 
            this.contacts_lv.BackColor = System.Drawing.SystemColors.Control;
            this.contacts_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.last_name,
            this.private_name,
            this.phone_num,
            this.Email,
            this.parent_Email,
            this.address});
            this.contacts_lv.Location = new System.Drawing.Point(22, 61);
            this.contacts_lv.Name = "contacts_lv";
            this.contacts_lv.Size = new System.Drawing.Size(766, 333);
            this.contacts_lv.TabIndex = 5;
            this.contacts_lv.UseCompatibleStateImageBehavior = false;
            this.contacts_lv.View = System.Windows.Forms.View.Details;
            // 
            // last_name
            // 
            this.last_name.Text = "Last Name";
            this.last_name.Width = 100;
            // 
            // private_name
            // 
            this.private_name.Text = "Private Name";
            this.private_name.Width = 100;
            // 
            // phone_num
            // 
            this.phone_num.Text = "Phone Number";
            this.phone_num.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 150;
            // 
            // parent_Email
            // 
            this.parent_Email.Text = "Parent Email";
            this.parent_Email.Width = 150;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 155;
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Transparent;
            this.return_btn.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Location = new System.Drawing.Point(12, 436);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 6;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // ManagerAndTeacher_view_contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.contacts_lv);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class_num_cb);
            this.Controls.Add(this.grade_cb);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerAndTeacher_view_contacts";
            this.Text = "ManagerAndTeacher_view_contacts";
            this.Load += new System.EventHandler(this.ManagerAndTeacher_view_contacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox grade_cb;
        private System.Windows.Forms.ComboBox class_num_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.ListView contacts_lv;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader private_name;
        private System.Windows.Forms.ColumnHeader phone_num;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader parent_Email;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.Button return_btn;
    }
}