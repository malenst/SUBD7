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
    public partial class adm : Form
    {
        public adm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Brand a = new Brand();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            a.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Car_with_defect a = new Car_with_defect();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client a = new Client();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DealerShip a = new DealerShip();
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Defect a = new Defect();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manager a = new Manager();
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Model a = new Model();
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Paper a = new Paper();
            a.Show();
        }
    }
}
