namespace _21an_Projekt_grafiskt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        //Max v�rde variabel
        int o = 21;

        //Random varaiblar
        int a = 1;
        int b = 11;
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int s = random.Next(a, b);
            int p = random.Next(a, b);
            int y = random.Next(a, b);
            int g = random.Next(a, b);
            int j = s + p;
            int k = g + j;
            DialogResult result;
           result = MessageBox.Show("      Spelare: " + j + "        Dator: " + k,"Po�ng"  , MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                //avbrytningsvariabel
                int w = 1;

                while (w ==1)
                {
                    
                    DialogResult result2;
                    result2 = MessageBox.Show("Vill du dra ett kort till?", "Fler kort?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result2 == DialogResult.Yes)
                    {
                        int u = random.Next(a, b);
                        j = j + u;
                        MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick �ver gr�nsen f�r max antal po�ng", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }

                        u = 0;
                    }
                    if (result2 != DialogResult.No)
                    {
                       
                        MessageBox.Show("Nu �r det datorns tur att dra kort", "Datorns tur", MessageBoxButtons.OK, MessageBoxIcon.None);
                        while (true)
                        {
                            int v = random.Next(a, b);
                            k = v + k;
                            MessageBox.Show("      Spelare: " + j + "        Dator: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);

                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                break;

                            }
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer po�ng �n dig", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                                w = 0;
                                break;
                                
                            }
                           
                        }
                    }
                

                   
                   
                }
            }
        }
    }
}