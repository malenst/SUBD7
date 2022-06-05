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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            clientTableAdapter.Update(dataSet1);
        }
    }
}
