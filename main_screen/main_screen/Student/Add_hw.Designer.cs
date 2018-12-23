namespace main_screen.Student
{
    partial class Add_hw_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_hw_form));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.from_hour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.from_minute = new System.Windows.Forms.NumericUpDown();
            this.to_minute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.to_hour = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.profassion_txt = new System.Windows.Forms.TextBox();
            this.details_txt = new System.Windows.Forms.RichTextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.from_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profassion:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do it in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "From:";
            // 
            // from_hour
            // 
            this.from_hour.Location = new System.Drawing.Point(64, 138);
            this.from_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.from_hour.Name = "from_hour";
            this.from_hour.Size = new System.Drawing.Size(38, 20);
            this.from_hour.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // from_minute
            // 
            this.from_minute.Location = new System.Drawing.Point(124, 138);
            this.from_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.from_minute.Name = "from_minute";
            this.from_minute.Size = new System.Drawing.Size(38, 20);
            this.from_minute.TabIndex = 7;
            // 
            // to_minute
            // 
            this.to_minute.Location = new System.Drawing.Point(125, 174);
            this.to_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.to_minute.Name = "to_minute";
            this.to_minute.Size = new System.Drawing.Size(38, 20);
            this.to_minute.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // to_hour
            // 
            this.to_hour.Location = new System.Drawing.Point(65, 174);
            this.to_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.to_hour.Name = "to_hour";
            this.to_hour.Size = new System.Drawing.Size(38, 20);
            this.to_hour.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date to submit:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(95, 200);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // profassion_txt
            // 
            this.profassion_txt.Location = new System.Drawing.Point(96, 22);
            this.profassion_txt.Name = "profassion_txt";
            this.profassion_txt.Size = new System.Drawing.Size(200, 20);
            this.profassion_txt.TabIndex = 14;
            // 
            // details_txt
            // 
            this.details_txt.Location = new System.Drawing.Point(95, 51);
            this.details_txt.Name = "details_txt";
            this.details_txt.Size = new System.Drawing.Size(200, 45);
            this.details_txt.TabIndex = 15;
            this.details_txt.Text = "";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(237, 244);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 16;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(12, 244);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 17;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // Add_hw_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 279);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.details_txt);
            this.Controls.Add(this.profassion_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.to_minute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.to_hour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.from_minute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.from_hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_hw_form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.from_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown from_hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown from_minute;
        private System.Windows.Forms.NumericUpDown to_minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown to_hour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox profassion_txt;
        private System.Windows.Forms.RichTextBox details_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button return_btn;
    }
}