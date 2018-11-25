namespace main_screen.general_process
{
    partial class Add_event_form
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.Place = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.RadioButton();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.minutes_start = new System.Windows.Forms.NumericUpDown();
            this.hours_start = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.public_B = new System.Windows.Forms.RadioButton();
            this.private_B = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.privacy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_time = new System.Windows.Forms.Label();
            this.End_time = new System.Windows.Forms.Label();
            this.minutes_end = new System.Windows.Forms.NumericUpDown();
            this.hours_end = new System.Windows.Forms.NumericUpDown();
            this.time_before = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scheduLuzDataSet2 = new main_screen.ScheduLuzDataSet2();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new main_screen.ScheduLuzDataSet2TableAdapters.EventsTableAdapter();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventkindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventprivacyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upforcancellationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutesstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutesendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(335, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 54);
            this.button2.TabIndex = 55;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(254, 460);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(159, 20);
            this.Place.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Place:";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(314, 419);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(39, 17);
            this.No.TabIndex = 52;
            this.No.TabStop = true;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.No_CheckedChanged);
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(261, 419);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(43, 17);
            this.Yes.TabIndex = 51;
            this.Yes.TabStop = true;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.CheckedChanged += new System.EventHandler(this.Yes_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "reminder:";
            // 
            // minutes_start
            // 
            this.minutes_start.Location = new System.Drawing.Point(322, 216);
            this.minutes_start.Name = "minutes_start";
            this.minutes_start.Size = new System.Drawing.Size(37, 20);
            this.minutes_start.TabIndex = 49;
            // 
            // hours_start
            // 
            this.hours_start.Location = new System.Drawing.Point(264, 216);
            this.hours_start.Name = "hours_start";
            this.hours_start.Size = new System.Drawing.Size(37, 20);
            this.hours_start.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(102, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 47;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(121, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Date:";
            // 
            // date
            // 
            this.date.CustomFormat = "dd-MM-yyyy hh:mm";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(261, 169);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 20);
            this.date.TabIndex = 45;
            // 
            // public_B
            // 
            this.public_B.AutoSize = true;
            this.public_B.Location = new System.Drawing.Point(265, 537);
            this.public_B.Name = "public_B";
            this.public_B.Size = new System.Drawing.Size(53, 17);
            this.public_B.TabIndex = 44;
            this.public_B.TabStop = true;
            this.public_B.Text = "public";
            this.public_B.UseVisualStyleBackColor = true;
            // 
            // private_B
            // 
            this.private_B.AutoSize = true;
            this.private_B.Location = new System.Drawing.Point(265, 503);
            this.private_B.Name = "private_B";
            this.private_B.Size = new System.Drawing.Size(57, 17);
            this.private_B.TabIndex = 43;
            this.private_B.TabStop = true;
            this.private_B.Text = "private";
            this.private_B.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(261, 296);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 95);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "";
            // 
            // privacy
            // 
            this.privacy.AutoSize = true;
            this.privacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.privacy.Location = new System.Drawing.Point(121, 495);
            this.privacy.Name = "privacy";
            this.privacy.Size = new System.Drawing.Size(87, 25);
            this.privacy.TabIndex = 41;
            this.privacy.Text = "privacy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(121, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Details:";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(261, 114);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(161, 20);
            this.text_title.TabIndex = 39;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(121, 109);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 25);
            this.title.TabIndex = 38;
            this.title.Text = "title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(291, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 73);
            this.label1.TabIndex = 37;
            this.label1.Text = "הוספת אירוע";
            // 
            // Start_time
            // 
            this.Start_time.AutoSize = true;
            this.Start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Start_time.Location = new System.Drawing.Point(121, 211);
            this.Start_time.Name = "Start_time";
            this.Start_time.Size = new System.Drawing.Size(115, 25);
            this.Start_time.TabIndex = 56;
            this.Start_time.Text = "Start time: ";
            // 
            // End_time
            // 
            this.End_time.AutoSize = true;
            this.End_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.End_time.Location = new System.Drawing.Point(121, 248);
            this.End_time.Name = "End_time";
            this.End_time.Size = new System.Drawing.Size(102, 25);
            this.End_time.TabIndex = 57;
            this.End_time.Text = "End time:";
            // 
            // minutes_end
            // 
            this.minutes_end.Location = new System.Drawing.Point(322, 255);
            this.minutes_end.Name = "minutes_end";
            this.minutes_end.Size = new System.Drawing.Size(37, 20);
            this.minutes_end.TabIndex = 58;
            // 
            // hours_end
            // 
            this.hours_end.Location = new System.Drawing.Point(261, 255);
            this.hours_end.Name = "hours_end";
            this.hours_end.Size = new System.Drawing.Size(37, 20);
            this.hours_end.TabIndex = 59;
            // 
            // time_before
            // 
            this.time_before.FormattingEnabled = true;
            this.time_before.Location = new System.Drawing.Point(466, 416);
            this.time_before.Name = "time_before";
            this.time_before.Size = new System.Drawing.Size(45, 21);
            this.time_before.TabIndex = 61;
            this.time_before.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(383, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "remind me: ";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(517, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "before the event.";
            this.label4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.eventnameDataGridViewTextBoxColumn,
            this.eventdetailsDataGridViewTextBoxColumn,
            this.eventkindDataGridViewTextBoxColumn,
            this.eventplaceDataGridViewTextBoxColumn,
            this.eventprivacyDataGridViewTextBoxColumn,
            this.upforcancellationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.hoursstartDataGridViewTextBoxColumn,
            this.minutesstartDataGridViewTextBoxColumn,
            this.hoursendDataGridViewTextBoxColumn,
            this.minutesendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(386, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 101);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.Visible = false;
            // 
            // scheduLuzDataSet2
            // 
            this.scheduLuzDataSet2.DataSetName = "ScheduLuzDataSet2";
            this.scheduLuzDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.scheduLuzDataSet2;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "Event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "Event_id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            // 
            // eventnameDataGridViewTextBoxColumn
            // 
            this.eventnameDataGridViewTextBoxColumn.DataPropertyName = "Event_name";
            this.eventnameDataGridViewTextBoxColumn.HeaderText = "Event_name";
            this.eventnameDataGridViewTextBoxColumn.Name = "eventnameDataGridViewTextBoxColumn";
            // 
            // eventdetailsDataGridViewTextBoxColumn
            // 
            this.eventdetailsDataGridViewTextBoxColumn.DataPropertyName = "Event_details";
            this.eventdetailsDataGridViewTextBoxColumn.HeaderText = "Event_details";
            this.eventdetailsDataGridViewTextBoxColumn.Name = "eventdetailsDataGridViewTextBoxColumn";
            // 
            // eventkindDataGridViewTextBoxColumn
            // 
            this.eventkindDataGridViewTextBoxColumn.DataPropertyName = "event_kind";
            this.eventkindDataGridViewTextBoxColumn.HeaderText = "event_kind";
            this.eventkindDataGridViewTextBoxColumn.Name = "eventkindDataGridViewTextBoxColumn";
            // 
            // eventplaceDataGridViewTextBoxColumn
            // 
            this.eventplaceDataGridViewTextBoxColumn.DataPropertyName = "event_place";
            this.eventplaceDataGridViewTextBoxColumn.HeaderText = "event_place";
            this.eventplaceDataGridViewTextBoxColumn.Name = "eventplaceDataGridViewTextBoxColumn";
            // 
            // eventprivacyDataGridViewTextBoxColumn
            // 
            this.eventprivacyDataGridViewTextBoxColumn.DataPropertyName = "event_privacy";
            this.eventprivacyDataGridViewTextBoxColumn.HeaderText = "event_privacy";
            this.eventprivacyDataGridViewTextBoxColumn.Name = "eventprivacyDataGridViewTextBoxColumn";
            // 
            // upforcancellationDataGridViewTextBoxColumn
            // 
            this.upforcancellationDataGridViewTextBoxColumn.DataPropertyName = "up_for_cancellation";
            this.upforcancellationDataGridViewTextBoxColumn.HeaderText = "up_for_cancellation";
            this.upforcancellationDataGridViewTextBoxColumn.Name = "upforcancellationDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // hoursstartDataGridViewTextBoxColumn
            // 
            this.hoursstartDataGridViewTextBoxColumn.DataPropertyName = "hours_start";
            this.hoursstartDataGridViewTextBoxColumn.HeaderText = "hours_start";
            this.hoursstartDataGridViewTextBoxColumn.Name = "hoursstartDataGridViewTextBoxColumn";
            // 
            // minutesstartDataGridViewTextBoxColumn
            // 
            this.minutesstartDataGridViewTextBoxColumn.DataPropertyName = "minutes_start";
            this.minutesstartDataGridViewTextBoxColumn.HeaderText = "minutes_start";
            this.minutesstartDataGridViewTextBoxColumn.Name = "minutesstartDataGridViewTextBoxColumn";
            // 
            // hoursendDataGridViewTextBoxColumn
            // 
            this.hoursendDataGridViewTextBoxColumn.DataPropertyName = "hours_end";
            this.hoursendDataGridViewTextBoxColumn.HeaderText = "hours_end";
            this.hoursendDataGridViewTextBoxColumn.Name = "hoursendDataGridViewTextBoxColumn";
            // 
            // minutesendDataGridViewTextBoxColumn
            // 
            this.minutesendDataGridViewTextBoxColumn.DataPropertyName = "minutes_end";
            this.minutesendDataGridViewTextBoxColumn.HeaderText = "minutes_end";
            this.minutesendDataGridViewTextBoxColumn.Name = "minutesendDataGridViewTextBoxColumn";
            // 
            // Add_event_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_before);
            this.Controls.Add(this.hours_end);
            this.Controls.Add(this.minutes_end);
            this.Controls.Add(this.End_time);
            this.Controls.Add(this.Start_time);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minutes_start);
            this.Controls.Add(this.hours_start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.public_B);
            this.Controls.Add(this.private_B);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.privacy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "Add_event_form";
            this.Text = "Add_event_form";
            this.Load += new System.EventHandler(this.Add_event_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minutes_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minutes_start;
        private System.Windows.Forms.NumericUpDown hours_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton public_B;
        private System.Windows.Forms.RadioButton private_B;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label privacy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start_time;
        private System.Windows.Forms.Label End_time;
        private System.Windows.Forms.NumericUpDown minutes_end;
        private System.Windows.Forms.NumericUpDown hours_end;
        private System.Windows.Forms.ComboBox time_before;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ScheduLuzDataSet2 scheduLuzDataSet2;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private ScheduLuzDataSet2TableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventkindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventprivacyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upforcancellationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutesstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutesendDataGridViewTextBoxColumn;
    }
}