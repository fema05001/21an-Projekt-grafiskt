

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
      
        //Variablar f�r andra forms (inst�llningar)

         
        //Senast vinnare
            public static string xx ="Ingen vinnare";

        //Vem vinner om det �r lika?
        public static int pp = 0;
        public static int nn = 0;

        //sv�righetsgrad
        //l�tt
        int uu =12;
        public static int mm = 0;
        //Medel
        int w = 15;
        public static int �� = 0;
        //Sv�rt
        int ee = 18;
        public static int zz = 0;
         
        
         
        
        
      
        Form2 ac = new Form2();
      
       

        //Max v�rde variabel
        int o = 21;

        //Random varaiblar
      public static  int a = 11;
       public static int b = 1;
        Random random = new Random();

        //Spelet
        private void button1_Click(object sender, EventArgs e)
        {
            
            int s = random.Next(b, a);
            int p = random.Next(b, a);
            int y = random.Next(b, a);
            int g = random.Next(b, a);
            int j = s + p;
            int k = g + y;
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
                    result2 = MessageBox.Show("                                             Spelare: " + j + "            Dator: " + k + "                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Vill du dra ett kort till?", "Fler kort?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result2 == DialogResult.Yes)
                    {
                        int u = random.Next(b, a);
                        j = j + u;
                        MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick �ver gr�nsen f�r max antal po�ng, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }

                        u = 0;
                    }
                    //Datorns tur
                    if (result2 != DialogResult.Yes)
                    {
                        //Kollar ifall du eller datorn redan har vunnit
                        if (k > o)
                        {
                            MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                            w = 0;
                            var myformm = new Form4();
                            myformm.ShowDialog();
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

                            //Datorn drar kort

                            int v = random.Next(b, a);
                            k = v + k;
                            MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);



                            //Kollar ifal du eller datorn har vunnit
                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                // visar form f�r att skriva in sitt namn
                                var myformm = new Form4();
                                myformm.ShowDialog();
                                break;

                            }
                            //Datorn f�r mer po�ng �n dig
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer po�ng �n dig, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                                w = 0;
                                break; 
                                
                            }
                            //vem vinner om det �r lika

                            //Datorn
                            else if (k == j && pp == 1)
                            {
                                MessageBox.Show("B�da spelare har lika mycket po�ng, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                                w = 0;
                                break;
                            }
                            //Spelaren
                            else if (k == j & nn == 1)
                            {
                                MessageBox.Show("B�da spelare har lika mycket po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                var myformm = new Form4();
                                myformm.ShowDialog();
                                w = 0; 
                                break;
                            }
                            //vinnarmedelande f�r l�tt
                           else if (k >= uu  && mm == 1 && k < j)
                            {
                                MessageBox.Show("Datorn f�r inte dra fler kort, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                var myformm = new Form4();
                                myformm.ShowDialog();
                                w = 0;
                                break;
                            }
                            //vinnarmedelande f�r medel
                            else if (k >= w && �� == 1 && k < j)
                            {
                                MessageBox.Show("Datorn f�r inte dra fler kort, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                var myformm = new Form4();
                                myformm.ShowDialog();
                                w = 0;
                                break;
                               
                            }
                            //vinnarmedelande f�r sv�rt
                            else if (k >= ee && zz == 1 && k < j)
                            {
                                MessageBox.Show("Datorn f�r inte dra fler kort, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                var myformm = new Form4();
                                myformm.ShowDialog();
                                w = 0;
                                break;
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

        //test
        
    }
    
    
}