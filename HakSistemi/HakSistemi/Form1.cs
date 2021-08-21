using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "" &&  textBox2.Text == "")
            {
                hak--;
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş ! Kalan Hakkınız :" + hak);
            }

            else if (textBox1.Text == "kullaniciadi" && textBox2.Text == "sifre")
            {
                MessageBox.Show("Giriş Başarılı");
                
                
            }

            else
            {
                hak--;
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı ! Kalan Hakkınız :" + hak);
            }

            if( hak == 0)
            {
                MessageBox.Show("Hakkınız Bitmiştir.Program Kapatılıyor");
                Application.Exit();
            }


            
        }
    }
}
