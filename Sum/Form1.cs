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

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int birinciSayi, ikinciSayi, toplam;
            birinciSayi = Convert.ToInt32(textBoxFirstNumber.Text);
            ikinciSayi = Convert.ToInt32(textBoxSecondNumber.Text);
            toplam = birinciSayi + ikinciSayi;
            MessageBox.Show("Girilen Sayıların Toplamı : \n" + toplam);
        }
    }
}
