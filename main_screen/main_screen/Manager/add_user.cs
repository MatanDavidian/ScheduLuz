﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_screen.Manager
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduLuzDataSet.connection_details' table. You can move, or remove it, as needed.
            this.connection_detailsTableAdapter1.Fill(this.scheduLuzDataSet.connection_details);
            // TODO: This line of code loads data into the 'scheduLuzDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.scheduLuzDataSet.users);
            // TODO: This line of code loads data into the 'scheduLuzDataSet1.connection_details' table. You can move, or remove it, as needed.
            this.connection_detailsTableAdapter.Fill(this.scheduLuzDataSet1.connection_details);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerCalander frmAEF = new ManagerCalander();
            frmAEF.Show();
            Visible = false;
        }

        private void Choose_Type_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
