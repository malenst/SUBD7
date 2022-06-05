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
    public partial class DealerShip : Form
    {
        public DealerShip()
        {
            InitializeComponent();
        }

        private void dealershipBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dealershipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void DealerShip_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Dealership". При необходимости она может быть перемещена или удалена.
            this.dealershipTableAdapter.Fill(this.dataSet1.Dealership);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealershipBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dealershipBindingSource.EndEdit();
            dealershipTableAdapter.Update(dataSet1);
        }
    }
}
