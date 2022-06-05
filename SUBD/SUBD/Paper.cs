﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD
{
    public partial class Paper : Form
    {
        public Paper()
        {
            InitializeComponent();
        }

        private void paperBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paperBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Paper_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Paper". При необходимости она может быть перемещена или удалена.
            this.paperTableAdapter.Fill(this.dataSet1.Paper);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paperBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paperBindingSource.EndEdit();
            paperTableAdapter.Update(dataSet1);
        }
    }
}
