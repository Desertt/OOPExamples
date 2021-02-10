using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Topla(int sayi1 ,int sayi2)
        {
            return sayi1 + sayi2;
        }

        private Boolean Dogrula() {

            try
            {
                Convert.ToInt32(textBoxFirstNumber.Text);
                Convert.ToInt32(textBoxSecondNumber.Text);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void buttonSum_Click(object sender, EventArgs e)
        {

            if (Dogrula())
            {
                int toplam = Topla(Convert.ToInt32(textBoxFirstNumber.Text), Convert.ToInt32(textBoxSecondNumber.Text));
                MessageBox.Show("Toplam : " + toplam);
            }
            else
            {
                MessageBox.Show("Girdiğiniz Değerlerde Hata Var !");
            }
            //int birinciSayi, ikinciSayi, toplam;
            //birinciSayi = Convert.ToInt32(textBoxFirstNumber.Text);
            //ikinciSayi = Convert.ToInt32(textBoxSecondNumber.Text);
            //toplam = birinciSayi + ikinciSayi;
            //MessageBox.Show("Girilen Sayıların Toplamı : \n" + toplam);
        }
    }
}
