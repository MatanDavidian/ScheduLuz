namespace main_screen.Manager
{
    partial class public_event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(public_event));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.hours_start = new System.Windows.Forms.NumericUpDown();
            this.minutes_start = new System.Windows.Forms.NumericUpDown();
            this.Start_time = new System.Windows.Forms.Label();
            this.hours_end = new System.Windows.Forms.NumericUpDown();
            this.End_time = new System.Windows.Forms.Label();
            this.minutes_end = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.Place = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.hours_start);
            this.groupBox1.Controls.Add(this.minutes_start);
            this.groupBox1.Controls.Add(this.Start_time);
            this.groupBox1.Controls.Add(this.hours_end);
            this.groupBox1.Controls.Add(this.End_time);
            this.groupBox1.Controls.Add(this.minutes_end);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(624, 154);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // date
            // 
            this.date.CustomFormat = "dd-MM-yyyy hh:mm";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(118, 55);
            this.date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(140, 26);
            this.date.TabIndex = 1;
            // 
            // hours_start
            // 
            this.hours_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_start.Location = new System.Drawing.Point(465, 60);
            this.hours_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hours_start.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_start.Name = "hours_start";
            this.hours_start.Size = new System.Drawing.Size(56, 26);
            this.hours_start.TabIndex = 3;
            // 
            // minutes_start
            // 
            this.minutes_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_start.Location = new System.Drawing.Point(552, 60);
            this.minutes_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minutes_start.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_start.Name = "minutes_start";
            this.minutes_start.Size = new System.Drawing.Size(56, 26);
            this.minutes_start.TabIndex = 49;
            // 
            // Start_time
            // 
            this.Start_time.AutoSize = true;
            this.Start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_time.Location = new System.Drawing.Point(309, 60);
            this.Start_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Start_time.Name = "Start_time";
            this.Start_time.Size = new System.Drawing.Size(102, 20);
            this.Start_time.TabIndex = 2;
            this.Start_time.Text = "Start time :  ";
            // 
            // hours_end
            // 
            this.hours_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_end.Location = new System.Drawing.Point(465, 100);
            this.hours_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hours_end.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_end.Name = "hours_end";
            this.hours_end.Size = new System.Drawing.Size(56, 26);
            this.hours_end.TabIndex = 7;
            // 
            // End_time
            // 
            this.End_time.AutoSize = true;
            this.End_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_time.Location = new System.Drawing.Point(309, 100);
            this.End_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.End_time.Name = "End_time";
            this.End_time.Size = new System.Drawing.Size(90, 20);
            this.End_time.TabIndex = 5;
            this.End_time.Text = "End time  :";
            // 
            // minutes_end
            // 
            this.minutes_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_end.Location = new System.Drawing.Point(552, 100);
            this.minutes_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minutes_end.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_end.Name = "minutes_end";
            this.minutes_end.Size = new System.Drawing.Size(56, 26);
            this.minutes_end.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(44, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 66;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Place
            // 
            this.Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place.Location = new System.Drawing.Point(111, 92);
            this.Place.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Place.MaxLength = 20;
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(331, 26);
            this.Place.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Place:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::main_screen.Properties.Resources.greenbtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(555, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(111, 295);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 144);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Details:";
            // 
            // text_title
            // 
            this.text_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_title.Location = new System.Drawing.Point(111, 52);
            this.text_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_title.MaxLength = 20;
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(331, 26);
            this.text_title.TabIndex = 56;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(14, 52);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 20);
            this.title.TabIndex = 63;
            this.title.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Add Event";
            // 
            // public_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "public_event";
            this.Text = "Public Event";
            this.Load += new System.EventHandler(this.public_event_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown hours_start;
        private System.Windows.Forms.NumericUpDown minutes_start;
        private System.Windows.Forms.Label Start_time;
        private System.Windows.Forms.NumericUpDown hours_end;
        private System.Windows.Forms.Label End_time;
        private System.Windows.Forms.NumericUpDown minutes_end;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
    }
}