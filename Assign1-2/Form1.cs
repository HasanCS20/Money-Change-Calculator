using System;
using System.Windows.Forms;

namespace Assign1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Converting the entry text into intger number
            int get = Convert.ToInt32(textBox1.Text);
            int price = Convert.ToInt32(textBox2.Text);

            int last = get - price;
            int hundred = last / 100;

            //Saving the change amount money type
            String total = "";

            if(hundred >= 1)
            {
                for(int i = 0; i < hundred; i++)
                {
                    total += "100 ";
                }
            }

            int fif = last - (hundred*100);
            int fifty = fif / 50;

            if(fifty >= 1)
            {
                for(int i = 0; i < fifty; i++)
                {
                    total += "50 ";
                }
            }

            int twin = fif - (fifty * 50);
            int twinty = twin / 20;

            if(twinty >= 1)
            {
                for(int i = 0; i < twinty; i++)
                {
                    total += "20 ";
                }
            }

            int te = twin - (twinty * 20);
            int ten = te / 10;

            if(ten >= 1)
            {
                for(int i = 0; i < ten; i++)
                {
                    total += "10 ";
                }
            }

            int fiv = te - (ten * 10);
            int five = fiv / 5;

            if(five >= 1)
            {
                for(int i = 0; i < five; i++)
                {
                    total += "5 ";
                }
            }

            int tw = fiv - (five * 5);
            int two = tw / 2;

            if(two >= 1)
            {
                for(int i = 0; i < two; i++)
                {
                    total += "2 ";
                }
            }

            int on = tw - (two * 2);
            int one = on / 1;

            if(one >= 1)
            {
                for(int i =0; i< one; i++)
                {
                    total += "1 ";
                }
            }
            MessageBox.Show("Your Change Is: " + Convert.ToString(last) + "\n:" + total);
            
        }
    }
}
