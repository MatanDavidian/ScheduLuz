namespace main_screen.Manager
{
    partial class approve_cancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(approve_cancellation));
            this.title = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(19, 18);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(362, 34);
            this.title.TabIndex = 80;
            this.title.Text = "Approve Cancel Requests";
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
            this.Return.Location = new System.Drawing.Point(704, 18);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(84, 34);
            this.Return.TabIndex = 81;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // approve_cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "approve_cancellation";
            this.Text = "Approve Cancel Requests";
            this.Load += new System.EventHandler(this.approve_cancellation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Return;
    }
}