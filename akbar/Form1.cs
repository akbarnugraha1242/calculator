using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilaia;
            int nilaib;
            int hasil;

            nilaia = Convert.ToInt16(textBox1.Text);
            nilaib = Convert.ToInt16(textBox2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    hasil = nilaia + nilaib;
                    textBox3.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = nilaia - nilaib;
                    textBox3.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = nilaia * nilaib;
                    textBox3.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = nilaia / nilaib;
                    textBox3.Text = Convert.ToString(hasil);
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
