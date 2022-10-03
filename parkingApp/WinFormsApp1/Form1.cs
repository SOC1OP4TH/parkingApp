namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }
        int i = 10;
        int j;
      
        Random eded = new Random();
        Random eded2 = new Random();

        
            
        List<int> list = new List<int>();

        public void enter_Click(object sender, EventArgs e)
        {
            int girencar = eded.Next(1, 10);

            j = int.Parse(eplace.Text);
            if ( listBox1.Items.Contains(girencar))
                {
                    MessageBox.Show("bu masin artiq qarajdadir");
                  
                }
            else
            {
                listBox1.Items.Add(girencar);
                --j;
            }    

   
            
            eplace.Text = j.ToString();
            if (j == 0)
            {
                MessageBox.Show("Butun yerlər doludur");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void empty_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            int cixancar = eded2.Next(1, 10);

            list.Add(cixancar);



            j = int.Parse(eplace.Text);

            if (listBox1.Items.Contains(cixancar))
                {
                    listBox1.Items.Remove(cixancar);
                        ++j;
            }
              

           

                   
                eplace.Text = j.ToString();
            
            if (j == 10)
            {
                MessageBox.Show("Butun yerler bosdur");
            }
        }
    }
}