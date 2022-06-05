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
    public partial class Model : Form
    {
        public Model()
        {
            InitializeComponent();
        }

        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Model_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSet1.Model);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelBindingSource.EndEdit();
            modelTableAdapter.Update(dataSet1);
        }
    }
}
