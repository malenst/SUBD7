using LoginLibrary.SecurityClasses.SecurityClasses;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var encryption = new Encryption();
            var userNameBytes = encryption.Encrypt(textBox1.Text, "111");
            var passwordBytes = encryption.Encrypt(textBox2.Text, "111");

            if (textBox1.Text == "Director" && textBox2.Text == "1234")
            {
                this.Hide();
                Direct direct = new Direct(); 
                direct.Show();
            }

            if (textBox1.Text == "administ" && textBox2.Text == "1234")
            {
                this.Hide();
                adm administ = new adm();
                administ.Show();
            }

            if ((textBox1.Text == "Golubkov" || textBox1.Text == "Rokossovskiy" || textBox1.Text == "Eltsin" || textBox1.Text == "Gogol" || textBox1.Text == "Tchaykovskiy" || textBox1.Text == "Kutuzov" || textBox1.Text == "Chehov" || textBox1.Text == "Nevskiy" || textBox1.Text == "Popov" || textBox1.Text == "Vasnetsov" || textBox1.Text == "Chukovskiy" || textBox1.Text == "Habenskiy") && textBox2.Text == "1234")
            {
                this.Hide();
                Emp a = new Emp();
                a.Show();
            }
        }
    }
}
