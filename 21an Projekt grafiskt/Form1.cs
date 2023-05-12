

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
      
       

        //Max värde variabel
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
           result = MessageBox.Show( "      Spelare: " + j + "        Dator: " + k,"Poäng"  , MessageBoxButtons.OK, MessageBoxIcon.None);
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
                        MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Poäng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick över gränsen för max antal poäng, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                            MessageBox.Show("Datorn gick över gränsen för maxantal poäng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                            w = 0;
                            break;

                        }
                        else if (k > j)
                        {
                            MessageBox.Show("Datorn fick mer poäng än dig, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                            w = 0;
                            break; 

                        }

                        MessageBox.Show("Nu är det datorns tur att dra kort", "Datorns tur", MessageBoxButtons.OK, MessageBoxIcon.None);
                        while (true)
                        {
                            int v = random.Next(a, b);
                            k = v + k;
                            MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Poäng", MessageBoxButtons.OK, MessageBoxIcon.None);


                            //Kollar ifal du eller datorn har vunnit
                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick över gränsen för maxantal poäng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                break;

                            }
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer poäng än dig, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

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
            MessageBox.Show("Du och datorn kommer att få två slumpmäsiga kort med värdena mellan 1 och 10 Efter det får du val att dra fler kort med slumpmäsiga värden mellan 1 och 10 tills du är nöjd, då är det datorns tur att dra kort. Målet är att ha ett högre värde än datorn och vara så nära värdet 21 som möjligt utan att gå över.om du går över värdet 21 eller om datorn har ett högre number än dig utan att ha gått över 21 så förlorar du. datorn kommer att fortsätta dra kort tills den vunnit eller gått över 21. I inställnings alternaivet kan du ändra saker som svårighetsgrad och max/min värde av korten för att göra spelet svårare eller enklare", "Regler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //variabel för inställningar
       

        
        //Instälningar
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