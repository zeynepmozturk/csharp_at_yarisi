using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int oyuncu_sayisi_212701008=Convert.ToInt32(maskedTextBox1.Text);
            if (oyuncu_sayisi_212701008 == 2 || oyuncu_sayisi_212701008 == 3 || oyuncu_sayisi_212701008 == 4)
            {
                Form1 yeniform = new Form1();
                yeniform.Show();

            }
            else if (oyuncu_sayisi_212701008 <= 1)
                MessageBox.Show("En az 2 oyuncu giriniz!!!");
            else if(oyuncu_sayisi_212701008>=5)
            {
                MessageBox.Show("En fazla 4 oyuncu giriniz!!!");
            }

            

            

        }
    }
}
