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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Brand_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.dataSet1.Brand);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brandBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brandBindingSource.EndEdit();
            brandTableAdapter.Update(dataSet1);
        }
    }
}
