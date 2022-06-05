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
    public partial class Defect : Form
    {
        public Defect()
        {
            InitializeComponent();
        }

        private void defectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.defectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Defect_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Defect". При необходимости она может быть перемещена или удалена.
            this.defectTableAdapter.Fill(this.dataSet1.Defect);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            defectBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            defectBindingSource.EndEdit();
            defectTableAdapter.Update(dataSet1);
        }
    }
}
