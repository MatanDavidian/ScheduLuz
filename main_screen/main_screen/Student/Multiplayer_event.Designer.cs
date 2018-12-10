namespace main_screen.Student
{
    partial class Multiplayer_event
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
            this.title = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplayer Event";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(22, 78);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(102, 20);
            this.title.TabIndex = 39;
            this.title.Text = "Friend name:";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(147, 78);
            this.text_title.Multiline = true;
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(173, 20);
            this.text_title.TabIndex = 40;
            // 
            // Multiplayer_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 555);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Multiplayer_event";
            this.Text = "Multiplayer_event";
            this.Load += new System.EventHandler(this.Multiplayer_event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox text_title;
    }
}