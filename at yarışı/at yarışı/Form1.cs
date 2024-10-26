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
    public partial class Form1 : Form
    {
        
        public Form1( )
        {
            InitializeComponent();
            


        }

        int birinci_atın_uzaklıgı, ikinci_atın_uzaklıgı, ucuncu_atın_uzaklıgı,dorduncu_atın_uzaklıgı;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinci_atın_kapladıgıyer=pictureBox1.Width;
            int ikinci_atın_kapladıgıyer=pictureBox2.Width;
            int ucuncu_atın_kapladıgıyer=pictureBox3.Width;
            int dorduncu_atın_kapladıgıyer=pictureBox4.Width;
            int bitis_uzaklıgı = label6.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left=pictureBox2.Left+rastgele.Next(5, 15);
            pictureBox3.Left=pictureBox3.Left+rastgele.Next(5, 15);
            pictureBox4.Left=pictureBox4.Left+rastgele.Next(5, 15);
            if(birinci_atın_kapladıgıyer+pictureBox1.Left>=bitis_uzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numararlı at yarisi kazandi!!!");
            }
            if(ikinci_atın_kapladıgıyer+pictureBox2.Left>=bitis_uzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarisi kazandi!!!");

            }
            if (ucuncu_atın_kapladıgıyer +pictureBox3.Left >= bitis_uzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarisi kazandi!!!");

            }
            if (dorduncu_atın_kapladıgıyer + pictureBox4.Left >= bitis_uzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 numaralı at yarisi kazandi!!!");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            label6.Text =" 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        Random rastgele =new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinci_atın_uzaklıgı = pictureBox1.Left;
            ikinci_atın_uzaklıgı = pictureBox2.Left;
            ucuncu_atın_uzaklıgı = pictureBox3.Left;
            dorduncu_atın_uzaklıgı=pictureBox4.Left;
           
        }

    }
}
