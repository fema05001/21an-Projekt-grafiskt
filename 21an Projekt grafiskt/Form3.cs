﻿using System;
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
    //Instälningar
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //Avsluta inställningar
        private void button40_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Max/Min värde av kort
        private void button30_Click(object sender, EventArgs e)
        {
            var myyform = new Form5();
             myyform.ShowDialog();

            
           
        }
        //Svårighetsgrad
        private void button10_Click(object sender, EventArgs e)
        {
            var mmyform = new Form7();
            mmyform.ShowDialog();
        }

        //Vem vinner om det är lika
        private void button20_Click(object sender, EventArgs e)
        {
            var mmyyform = new Form6();
            mmyyform.ShowDialog();
        }
        //Stänga ned inställningar



    }
}
