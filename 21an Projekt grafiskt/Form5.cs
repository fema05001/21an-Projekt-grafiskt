using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21an_Projekt_grafiskt
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Tillbaka
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //verification av max/min värde på korten
        private void button1_Click(object sender, EventArgs e)
        {
            int cc =int.Parse(textBox1.Text);
            int bb =int.Parse(textBox2.Text);
            Form1.b = cc;
            Form1.a = bb;
        }
    }
}
