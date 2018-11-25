namespace main_screen.Manager
{
    partial class add_user
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
            this.Add_user_title = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Choose_Type = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_user_title
            // 
            this.Add_user_title.AutoSize = true;
            this.Add_user_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_user_title.Location = new System.Drawing.Point(367, 26);
            this.Add_user_title.Name = "Add_user_title";
            this.Add_user_title.Size = new System.Drawing.Size(109, 29);
            this.Add_user_title.TabIndex = 0;
            this.Add_user_title.Text = "Add user";
            this.Add_user_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(372, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Choose_Type
            // 
            this.Choose_Type.AutoSize = true;
            this.Choose_Type.Location = new System.Drawing.Point(391, 70);
            this.Choose_Type.Name = "Choose_Type";
            this.Choose_Type.Size = new System.Drawing.Size(73, 13);
            this.Choose_Type.TabIndex = 2;
            this.Choose_Type.Text = "Choose_Type";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(681, 315);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Choose_Type);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Add_user_title);
            this.Name = "add_user";
            this.Text = "add_user";
            this.Load += new System.EventHandler(this.add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Add_user_title;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Choose_Type;
        private System.Windows.Forms.Button Return;
    }
}