namespace main_screen.general_process
{
    partial class show_edit_event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_edit_event));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.private_B = new System.Windows.Forms.RadioButton();
            this.public_B = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.day_in_week_cb = new System.Windows.Forms.ComboBox();
            this.day_in_week = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.hours_start = new System.Windows.Forms.NumericUpDown();
            this.minutes_start = new System.Windows.Forms.NumericUpDown();
            this.Start_time = new System.Windows.Forms.Label();
            this.hours_end = new System.Windows.Forms.NumericUpDown();
            this.End_time = new System.Windows.Forms.Label();
            this.minutes_end = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.place_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.details_txt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.event_gb = new System.Windows.Forms.GroupBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).BeginInit();
            this.event_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.private_B);
            this.groupBox3.Controls.Add(this.public_B);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 50);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Privacy";
            // 
            // private_B
            // 
            this.private_B.AutoSize = true;
            this.private_B.Checked = true;
            this.private_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.private_B.Location = new System.Drawing.Point(8, 19);
            this.private_B.Name = "private_B";
            this.private_B.Size = new System.Drawing.Size(57, 17);
            this.private_B.TabIndex = 43;
            this.private_B.TabStop = true;
            this.private_B.Text = "private";
            this.private_B.UseVisualStyleBackColor = true;
            // 
            // public_B
            // 
            this.public_B.AutoSize = true;
            this.public_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.public_B.Location = new System.Drawing.Point(71, 19);
            this.public_B.Name = "public_B";
            this.public_B.Size = new System.Drawing.Size(53, 17);
            this.public_B.TabIndex = 44;
            this.public_B.Text = "public";
            this.public_B.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.day_in_week_cb);
            this.groupBox1.Controls.Add(this.day_in_week);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.hours_start);
            this.groupBox1.Controls.Add(this.minutes_start);
            this.groupBox1.Controls.Add(this.Start_time);
            this.groupBox1.Controls.Add(this.hours_end);
            this.groupBox1.Controls.Add(this.End_time);
            this.groupBox1.Controls.Add(this.minutes_end);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 100);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Time";
            // 
            // day_in_week_cb
            // 
            this.day_in_week_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_in_week_cb.FormattingEnabled = true;
            this.day_in_week_cb.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wenedsday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.day_in_week_cb.Location = new System.Drawing.Point(79, 35);
            this.day_in_week_cb.Name = "day_in_week_cb";
            this.day_in_week_cb.Size = new System.Drawing.Size(109, 21);
            this.day_in_week_cb.TabIndex = 60;
            this.day_in_week_cb.Visible = false;
            // 
            // day_in_week
            // 
            this.day_in_week.AutoSize = true;
            this.day_in_week.Location = new System.Drawing.Point(76, 39);
            this.day_in_week.Name = "day_in_week";
            this.day_in_week.Size = new System.Drawing.Size(99, 13);
            this.day_in_week.TabIndex = 59;
            this.day_in_week.Text = "every day_in_week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // date
            // 
            this.date.CustomFormat = "dd-MM-yyyy hh:mm";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(79, 36);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 20);
            this.date.TabIndex = 1;
            // 
            // hours_start
            // 
            this.hours_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_start.Location = new System.Drawing.Point(310, 39);
            this.hours_start.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_start.Name = "hours_start";
            this.hours_start.Size = new System.Drawing.Size(37, 20);
            this.hours_start.TabIndex = 3;
            this.hours_start.ValueChanged += new System.EventHandler(this.hours_start_ValueChanged);
            // 
            // minutes_start
            // 
            this.minutes_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_start.Location = new System.Drawing.Point(368, 39);
            this.minutes_start.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_start.Name = "minutes_start";
            this.minutes_start.Size = new System.Drawing.Size(37, 20);
            this.minutes_start.TabIndex = 49;
            // 
            // Start_time
            // 
            this.Start_time.AutoSize = true;
            this.Start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_time.Location = new System.Drawing.Point(206, 39);
            this.Start_time.Name = "Start_time";
            this.Start_time.Size = new System.Drawing.Size(63, 13);
            this.Start_time.TabIndex = 2;
            this.Start_time.Text = "Start time :  ";
            // 
            // hours_end
            // 
            this.hours_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_end.Location = new System.Drawing.Point(310, 65);
            this.hours_end.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_end.Name = "hours_end";
            this.hours_end.Size = new System.Drawing.Size(37, 20);
            this.hours_end.TabIndex = 7;
            // 
            // End_time
            // 
            this.End_time.AutoSize = true;
            this.End_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_time.Location = new System.Drawing.Point(206, 65);
            this.End_time.Name = "End_time";
            this.End_time.Size = new System.Drawing.Size(57, 13);
            this.End_time.TabIndex = 5;
            this.End_time.Text = "End time  :";
            // 
            // minutes_end
            // 
            this.minutes_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_end.Location = new System.Drawing.Point(368, 65);
            this.minutes_end.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_end.Name = "minutes_end";
            this.minutes_end.Size = new System.Drawing.Size(37, 20);
            this.minutes_end.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // place_txt
            // 
            this.place_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_txt.Location = new System.Drawing.Point(68, 58);
            this.place_txt.Name = "place_txt";
            this.place_txt.Size = new System.Drawing.Size(222, 20);
            this.place_txt.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 64;
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
            this.button1.Location = new System.Drawing.Point(401, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // details_txt
            // 
            this.details_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_txt.Location = new System.Drawing.Point(68, 190);
            this.details_txt.Name = "details_txt";
            this.details_txt.Size = new System.Drawing.Size(343, 95);
            this.details_txt.TabIndex = 59;
            this.details_txt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Details:";
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txt.Location = new System.Drawing.Point(68, 32);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(222, 20);
            this.title_txt.TabIndex = 56;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(30, 13);
            this.title.TabIndex = 62;
            this.title.Text = "Title:";
            // 
            // event_gb
            // 
            this.event_gb.Controls.Add(this.groupBox1);
            this.event_gb.Controls.Add(this.groupBox3);
            this.event_gb.Controls.Add(this.title);
            this.event_gb.Controls.Add(this.title_txt);
            this.event_gb.Controls.Add(this.label3);
            this.event_gb.Controls.Add(this.place_txt);
            this.event_gb.Controls.Add(this.details_txt);
            this.event_gb.Controls.Add(this.label7);
            this.event_gb.Enabled = false;
            this.event_gb.Location = new System.Drawing.Point(12, 12);
            this.event_gb.Name = "event_gb";
            this.event_gb.Size = new System.Drawing.Size(464, 346);
            this.event_gb.TabIndex = 66;
            this.event_gb.TabStop = false;
            this.event_gb.Text = "Event";
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Transparent;
            this.edit_btn.BackgroundImage = global::main_screen.Properties.Resources.greybtn;
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.edit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.edit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(401, 364);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 67;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // show_edit_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.event_gb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "show_edit_event";
            this.Text = "Show or Edit Event";
            this.Load += new System.EventHandler(this.show_edit_event_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).EndInit();
            this.event_gb.ResumeLayout(false);
            this.event_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton private_B;
        private System.Windows.Forms.RadioButton public_B;
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
        private System.Windows.Forms.TextBox place_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox details_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox event_gb;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label day_in_week;
        private System.Windows.Forms.ComboBox day_in_week_cb;
    }
}