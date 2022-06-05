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
    public partial class Emp : Form
    {
        public Emp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car_with_defect a = new Car_with_defect();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client a = new Client();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Defect a = new Defect();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Paper a = new Paper();
            a.Show();
        }
    }
}
