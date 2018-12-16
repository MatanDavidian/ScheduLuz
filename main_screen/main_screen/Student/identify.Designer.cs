namespace main_screen.Student
{
    partial class identify
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
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.submit_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your password:";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(16, 39);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(137, 20);
            this.pass_txt.TabIndex = 1;
            this.pass_txt.UseSystemPasswordChar = true;
            this.pass_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submit_pass
            // 
            this.submit_pass.Location = new System.Drawing.Point(47, 65);
            this.submit_pass.Name = "submit_pass";
            this.submit_pass.Size = new System.Drawing.Size(75, 23);
            this.submit_pass.TabIndex = 2;
            this.submit_pass.Text = "Submit";
            this.submit_pass.UseVisualStyleBackColor = true;
            this.submit_pass.Click += new System.EventHandler(this.submit_pass_Click);
            // 
            // identify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 104);
            this.Controls.Add(this.submit_pass);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label1);
            this.Name = "identify";
            this.Text = "identify";
            this.Load += new System.EventHandler(this.identify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button submit_pass;
    }
}