using System;
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.dataSet1.Manager);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerBindingSource.EndEdit();
            managerTableAdapter.Update(dataSet1);
        }
    }
}
