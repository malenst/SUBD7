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
    public partial class Car_with_defect : Form
    {
        public Car_with_defect()
        {
            InitializeComponent();
        }

        private void car_with_defectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.car_with_defectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Car_with_defect_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Car_with_defects". При необходимости она может быть перемещена или удалена.
            this.car_with_defectsTableAdapter.Fill(this.dataSet1.Car_with_defects);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            car_with_defectsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car_with_defectsBindingSource.EndEdit();
            car_with_defectsTableAdapter.Update(dataSet1);
        }
    }
}
