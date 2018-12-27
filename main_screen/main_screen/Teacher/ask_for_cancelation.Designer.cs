namespace main_screen.Teacher
{
    partial class ask_for_cancelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ask_for_cancelation));
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Choose the hours you wish to cancel:";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(19, 9);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(437, 52);
            this.title.TabIndex = 79;
            this.title.Text = "Cancel lessons request";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = global::main_screen.Properties.Resources.greenbtn;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Submit.Location = new System.Drawing.Point(536, 476);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(84, 34);
            this.Submit.TabIndex = 81;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Return.Location = new System.Drawing.Point(7, 476);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(84, 34);
            this.Return.TabIndex = 80;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(545, 56);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(181, 20);
            this.reason.TabIndex = 83;
            // 
            // ask_for_cancelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.ClientSize = new System.Drawing.Size(901, 522);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ask_for_cancelation";
            this.Text = "Cancel Request";
            this.Load += new System.EventHandler(this.ask_for_cancelation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox reason;
    }
}