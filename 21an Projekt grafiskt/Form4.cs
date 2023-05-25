using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//senaste vinnare  inskrivning form
namespace _21an_Projekt_grafiskt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             string i =textBox1.Text;
            Form1.xx = i;
            this.Close();
        }
    }
}
