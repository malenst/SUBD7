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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSet1.Car);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carBindingSource.EndEdit();
            carTableAdapter.Update(dataSet1);
        }
    }
}
