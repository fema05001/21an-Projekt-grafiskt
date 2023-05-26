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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //Lätt
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.mm = 1;
        }
        //Medel
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.åå = 1;
        }
        //Svårt
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.zz = 1;
        }
        //Helvete
        private void button4_Click(object sender, EventArgs e)
        {
            Form1.mm = 0;
            Form1.åå = 0;
            Form1.zz = 0;
        }
        //Tillbaka
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
