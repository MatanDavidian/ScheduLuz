namespace main_screen.Manager
{
    partial class delete_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_user));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.class_num_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grade_cb = new System.Windows.Forms.ComboBox();
            this.student_lst = new System.Windows.Forms.ListBox();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.detele_lst = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.class_num_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.grade_cb);
            this.groupBox1.Controls.Add(this.student_lst);
            this.groupBox1.Controls.Add(this.to_txt);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.detele_lst);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Class>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Class Number:";
            // 
            // class_num_cb
            // 
            this.class_num_cb.FormattingEnabled = true;
            this.class_num_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "ALL"});
            this.class_num_cb.Location = new System.Drawing.Point(216, 15);
            this.class_num_cb.Name = "class_num_cb";
            this.class_num_cb.Size = new System.Drawing.Size(75, 21);
            this.class_num_cb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grade:";
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
            this.grade_cb.Location = new System.Drawing.Point(52, 15);
            this.grade_cb.Name = "grade_cb";
            this.grade_cb.Size = new System.Drawing.Size(75, 21);
            this.grade_cb.TabIndex = 11;
            this.grade_cb.SelectedIndexChanged += new System.EventHandler(this.grade_cb_SelectedIndexChanged);
            // 
            // student_lst
            // 
            this.student_lst.FormattingEnabled = true;
            this.student_lst.Location = new System.Drawing.Point(52, 59);
            this.student_lst.Name = "student_lst";
            this.student_lst.Size = new System.Drawing.Size(239, 82);
            this.student_lst.Sorted = true;
            this.student_lst.TabIndex = 7;
            this.student_lst.SelectedIndexChanged += new System.EventHandler(this.student_lst_SelectedIndexChanged);
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(52, 42);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(239, 20);
            this.to_txt.TabIndex = 6;
            this.to_txt.TextChanged += new System.EventHandler(this.to_txt_TextChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_btn.BackgroundImage")));
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Location = new System.Drawing.Point(297, 75);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // detele_lst
            // 
            this.detele_lst.FormattingEnabled = true;
            this.detele_lst.Location = new System.Drawing.Point(378, 46);
            this.detele_lst.Name = "detele_lst";
            this.detele_lst.Size = new System.Drawing.Size(193, 95);
            this.detele_lst.TabIndex = 8;
            this.detele_lst.SelectedIndexChanged += new System.EventHandler(this.send_to_lst_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(297, 46);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add>>";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
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
            this.return_btn.Location = new System.Drawing.Point(12, 246);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 16;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackgroundImage = global::main_screen.Properties.Resources.greenbtn;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Location = new System.Drawing.Point(545, 246);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 301);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_user";
            this.Text = "delete_user";
            this.Load += new System.EventHandler(this.delete_user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox class_num_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox grade_cb;
        private System.Windows.Forms.ListBox student_lst;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.ListBox detele_lst;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}