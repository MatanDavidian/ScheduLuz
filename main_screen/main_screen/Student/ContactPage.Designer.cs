namespace main_screen.Student
{
    partial class ContactPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactPage));
            this.return_btn = new System.Windows.Forms.Button();
            this.contacts_lv = new System.Windows.Forms.ListView();
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.private_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.profilePic_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic_img)).BeginInit();
            this.SuspendLayout();
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
            this.return_btn.Location = new System.Drawing.Point(12, 416);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 13;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // contacts_lv
            // 
            this.contacts_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.last_name,
            this.private_name,
            this.phone_num,
            this.Email,
            this.address});
            this.contacts_lv.FullRowSelect = true;
            this.contacts_lv.Location = new System.Drawing.Point(22, 41);
            this.contacts_lv.Name = "contacts_lv";
            this.contacts_lv.Size = new System.Drawing.Size(611, 333);
            this.contacts_lv.TabIndex = 12;
            this.contacts_lv.UseCompatibleStateImageBehavior = false;
            this.contacts_lv.View = System.Windows.Forms.View.Details;
            this.contacts_lv.SelectedIndexChanged += new System.EventHandler(this.contacts_lv_SelectedIndexChanged);
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
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 155;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.profilePic_img);
            this.groupBox2.Location = new System.Drawing.Point(639, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // profilePic_img
            // 
            this.profilePic_img.Location = new System.Drawing.Point(12, 19);
            this.profilePic_img.Name = "profilePic_img";
            this.profilePic_img.Size = new System.Drawing.Size(137, 150);
            this.profilePic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic_img.TabIndex = 0;
            this.profilePic_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search:";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(73, 14);
            this.search_txt.MaxLength = 20;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(190, 20);
            this.search_txt.TabIndex = 20;
            this.search_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContactPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_student;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.contacts_lv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactPage";
            this.Text = "ContactPage";
            this.Load += new System.EventHandler(this.ContactPage_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.ListView contacts_lv;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader private_name;
        private System.Windows.Forms.ColumnHeader phone_num;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox profilePic_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
    }
}