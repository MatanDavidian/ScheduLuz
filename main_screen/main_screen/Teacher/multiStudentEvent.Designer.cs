using System;

namespace main_screen.Teacher
{
    partial class multiStudentEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multiStudentEvent));
            this.student_lst = new System.Windows.Forms.ListBox();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.send_to_lst = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.class_num_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grade_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.place_txt = new System.Windows.Forms.TextBox();
            this.date_pkr = new System.Windows.Forms.DateTimePicker();
            this.details_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hours_start = new System.Windows.Forms.NumericUpDown();
            this.minutes_start = new System.Windows.Forms.NumericUpDown();
            this.hours_end = new System.Windows.Forms.NumericUpDown();
            this.minutes_end = new System.Windows.Forms.NumericUpDown();
            this.return_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).BeginInit();
            this.SuspendLayout();
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
            // send_to_lst
            // 
            this.send_to_lst.FormattingEnabled = true;
            this.send_to_lst.Location = new System.Drawing.Point(378, 46);
            this.send_to_lst.Name = "send_to_lst";
            this.send_to_lst.Size = new System.Drawing.Size(193, 95);
            this.send_to_lst.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(297, 46);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add>>";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(297, 75);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.groupBox1.Controls.Add(this.send_to_lst);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users:";
            // 
            // button1
            // 
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Place:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Details:";
            // 
            // title_txt
            // 
            this.title_txt.Location = new System.Drawing.Point(52, 40);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(204, 20);
            this.title_txt.TabIndex = 17;
            // 
            // place_txt
            // 
            this.place_txt.Location = new System.Drawing.Point(52, 74);
            this.place_txt.Name = "place_txt";
            this.place_txt.Size = new System.Drawing.Size(204, 20);
            this.place_txt.TabIndex = 18;
            // 
            // date_pkr
            // 
            this.date_pkr.CustomFormat = "yyyy-MM-dd";
            this.date_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_pkr.Location = new System.Drawing.Point(52, 111);
            this.date_pkr.Name = "date_pkr";
            this.date_pkr.Size = new System.Drawing.Size(94, 20);
            this.date_pkr.TabIndex = 19;
            // 
            // details_txt
            // 
            this.details_txt.Location = new System.Drawing.Point(52, 140);
            this.details_txt.Name = "details_txt";
            this.details_txt.Size = new System.Drawing.Size(201, 96);
            this.details_txt.TabIndex = 20;
            this.details_txt.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.hours_start);
            this.groupBox2.Controls.Add(this.minutes_start);
            this.groupBox2.Controls.Add(this.hours_end);
            this.groupBox2.Controls.Add(this.minutes_end);
            this.groupBox2.Controls.Add(this.details_txt);
            this.groupBox2.Controls.Add(this.place_txt);
            this.groupBox2.Controls.Add(this.title_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.date_pkr);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 252);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "End:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Start:";
            // 
            // hours_start
            // 
            this.hours_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_start.Location = new System.Drawing.Point(203, 108);
            this.hours_start.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_start.Name = "hours_start";
            this.hours_start.Size = new System.Drawing.Size(37, 20);
            this.hours_start.TabIndex = 60;
            // 
            // minutes_start
            // 
            this.minutes_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_start.Location = new System.Drawing.Point(246, 109);
            this.minutes_start.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_start.Name = "minutes_start";
            this.minutes_start.Size = new System.Drawing.Size(37, 20);
            this.minutes_start.TabIndex = 61;
            // 
            // hours_end
            // 
            this.hours_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_end.Location = new System.Drawing.Point(362, 109);
            this.hours_end.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_end.Name = "hours_end";
            this.hours_end.Size = new System.Drawing.Size(37, 20);
            this.hours_end.TabIndex = 63;
            // 
            // minutes_end
            // 
            this.minutes_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_end.Location = new System.Drawing.Point(405, 109);
            this.minutes_end.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_end.Name = "minutes_end";
            this.minutes_end.Size = new System.Drawing.Size(37, 20);
            this.minutes_end.TabIndex = 62;
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(21, 582);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 26;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(508, 582);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(86, 23);
            this.create_btn.TabIndex = 27;
            this.create_btn.Text = "Create Event";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // multiStudentEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 617);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "multiStudentEvent";
            this.Text = "multiStudentEvent";
            this.Load += new System.EventHandler(this.multiStudentEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.ListBox student_lst;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.ListBox send_to_lst;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.TextBox place_txt;
        private System.Windows.Forms.DateTimePicker date_pkr;
        private System.Windows.Forms.RichTextBox details_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hours_start;
        private System.Windows.Forms.NumericUpDown minutes_start;
        private System.Windows.Forms.NumericUpDown hours_end;
        private System.Windows.Forms.NumericUpDown minutes_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox class_num_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox grade_cb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}