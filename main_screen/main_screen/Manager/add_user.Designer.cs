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
            this.components = new System.ComponentModel.Container();
            this.Add_user_title = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.scheduLuzDataSet1 = new main_screen.ScheduLuzDataSet1();
            this.connectiondetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connection_detailsTableAdapter = new main_screen.ScheduLuzDataSet1TableAdapters.connection_detailsTableAdapter();
            this.scheduLuzDataSet = new main_screen.ScheduLuzDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new main_screen.ScheduLuzDataSetTableAdapters.usersTableAdapter();
            this.connectiondetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.connection_detailsTableAdapter1 = new main_screen.ScheduLuzDataSetTableAdapters.connection_detailsTableAdapter();
            this.connectiondetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_user_title
            // 
            this.Add_user_title.AutoSize = true;
            this.Add_user_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_user_title.Location = new System.Drawing.Point(341, 9);
            this.Add_user_title.Name = "Add_user_title";
            this.Add_user_title.Size = new System.Drawing.Size(179, 29);
            this.Add_user_title.TabIndex = 0;
            this.Add_user_title.Text = "Add a new user";
            this.Add_user_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(697, 338);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 34);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.button1_Click);
            // 
            // scheduLuzDataSet1
            // 
            this.scheduLuzDataSet1.DataSetName = "ScheduLuzDataSet1";
            this.scheduLuzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connectiondetailsBindingSource
            // 
            this.connectiondetailsBindingSource.DataMember = "connection_details";
            this.connectiondetailsBindingSource.DataSource = this.scheduLuzDataSet1;
            // 
            // connection_detailsTableAdapter
            // 
            this.connection_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // scheduLuzDataSet
            // 
            this.scheduLuzDataSet.DataSetName = "ScheduLuzDataSet";
            this.scheduLuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.scheduLuzDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // connectiondetailsBindingSource1
            // 
            this.connectiondetailsBindingSource1.DataMember = "connection_details";
            this.connectiondetailsBindingSource1.DataSource = this.scheduLuzDataSet;
            // 
            // connection_detailsTableAdapter1
            // 
            this.connection_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // connectiondetailsBindingSource2
            // 
            this.connectiondetailsBindingSource2.DataMember = "connection_details";
            this.connectiondetailsBindingSource2.DataSource = this.scheduLuzDataSet;
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Add_user_title);
            this.Name = "add_user";
            this.Text = "add_user";
            this.Load += new System.EventHandler(this.add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduLuzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectiondetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Add_user_title;
        private System.Windows.Forms.Button Return;
        private ScheduLuzDataSet1 scheduLuzDataSet1;
        private System.Windows.Forms.BindingSource connectiondetailsBindingSource;
        private ScheduLuzDataSet1TableAdapters.connection_detailsTableAdapter connection_detailsTableAdapter;
        private ScheduLuzDataSet scheduLuzDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ScheduLuzDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource connectiondetailsBindingSource1;
        private ScheduLuzDataSetTableAdapters.connection_detailsTableAdapter connection_detailsTableAdapter1;
        private System.Windows.Forms.BindingSource connectiondetailsBindingSource2;
    }
}