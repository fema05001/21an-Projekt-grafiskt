

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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
      
            public static int yy = 0;
           
        
        
           
        
       
      
        Form2 ac = new Form2();
      
       

        //Max v�rde variabel
        int o = 21;

        //Random varaiblar
        int a = 1;
        int b = 11;
        Random random = new Random();

        //Spelet
        private void button1_Click(object sender, EventArgs e)
        {
            
            int s = random.Next(a, b);
            int p = random.Next(a, b);
            int y = random.Next(a, b);
            int g = random.Next(a, b);
            int j = s + p;
            int k = g + j;
            DialogResult result;
           result = MessageBox.Show( "      Spelare: " + j + "        Dator: " + k,"Po�ng"  , MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                //avbrytningsvariabel
                int w = 1;

                while (w ==1)
                {
                    //Dragning av fler kort

                    DialogResult result2;
                    result2 = MessageBox.Show("Vill du dra ett kort till?", "Fler kort?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result2 == DialogResult.Yes)
                    {
                        int u = random.Next(a, b);
                        j = j + u;
                        MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick �ver gr�nsen f�r max antal po�ng, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }

                        u = 0;
                    }
                    //Datorn drar kort
                    if (result2 != DialogResult.Yes)
                    {
                        //Kollar ifall du eller datorn redan har vunnit
                        if (k > o)
                        {
                            MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                            w = 0;
                            break;

                        }
                        else if (k > j)
                        {
                            MessageBox.Show("Datorn fick mer po�ng �n dig, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                            w = 0;
                            break; 

                        }

                        MessageBox.Show("Nu �r det datorns tur att dra kort", "Datorns tur", MessageBoxButtons.OK, MessageBoxIcon.None);
                        while (true)
                        {
                            int v = random.Next(a, b);
                            k = v + k;
                            MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);


                            //Kollar ifal du eller datorn har vunnit
                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                break;

                            }
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer po�ng �n dig, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                                w = 0;
                                break; //
                                
                            }
                           
                        }
                    }
                

                   
                   
                }
            }
        }
        //Regler
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du och datorn kommer att f� tv� slumpm�siga kort med v�rdena mellan 1 och 10 Efter det f�r du val att dra fler kort med slumpm�siga v�rden mellan 1 och 10 tills du �r n�jd, d� �r det datorns tur att dra kort. M�let �r att ha ett h�gre v�rde �n datorn och vara s� n�ra v�rdet 21 som m�jligt utan att g� �ver.om du g�r �ver v�rdet 21 eller om datorn har ett h�gre number �n dig utan att ha g�tt �ver 21 s� f�rlorar du. datorn kommer att forts�tta dra kort tills den vunnit eller g�tt �ver 21. I inst�llnings alternaivet kan du �ndra saker som sv�righetsgrad och max/min v�rde av korten f�r att g�ra spelet sv�rare eller enklare", "Regler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //variabel f�r inst�llningar
       

        
        //Inst�lningar
        private void button2_Click(object sender, EventArgs e)
        {
            var myform =new Form3();
            myform.ShowDialog();
           
           


        }
        //Senaste vinnare
        private void button3_Click(object sender, EventArgs e)
        {
            var myform = new Form2();
            myform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(yy+ "     h","test");
        }
    }
    
    
}