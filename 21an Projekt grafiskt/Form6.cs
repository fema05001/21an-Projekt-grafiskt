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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //tillbaka
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Spelaren vinner
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.nn = 1;
        }

        //datorn vinner
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.pp = 1;
        }

        //Ingen vinner
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.nn = 0;
            Form1.pp = 0;
        }
    }
}
