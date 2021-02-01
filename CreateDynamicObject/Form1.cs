using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDynamicObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Tanım:Dinamik olarak label, textbox ve butonların oluşturulması. Textbox’a 
         * girilen, max 4 basamaklı rakamın, label da okunuşunun gösterilmesi:*/


        //Label ve Textbox'ı Global Olarak Oluşturduk.
        TextBox txtSayigir = new TextBox();
        Label lblSayi = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Çıkış Butonu Oluşturma
            Button btnCik = new Button();
            //buton özellikleri
            btnCik.Height = 30;
            btnCik.Width = 100;
            btnCik.Top = 160;
            btnCik.Left = 160;
            btnCik.Text = "Çıkış";
            //buton gösterildi
            this.Controls.Add(btnCik);
            //tiklaninca calistir
            btnCik.Click += new EventHandler(btnCik_click);

            //textbox özellikleri
            txtSayigir.Height = 30;
            txtSayigir.Width = 210;
            txtSayigir.Top = 60;
            txtSayigir.Left = 50;
            //textbox göster
            this.Controls.Add(txtSayigir);
            //max 4 basamak girilsin
            txtSayigir.MaxLength = 4;
            // sadece nümerik değer girilebilsin
            txtSayigir.KeyPress += degerkontrol;
            //label özellikleri
            lblSayi.Height = 20;
            lblSayi.Width = 210;
            lblSayi.Top = 110;
            lblSayi.Left = 50;
            lblSayi.AutoSize = false;
            lblSayi.BackColor = Color.AliceBlue; // şekil olsun :)
            lblSayi.BorderStyle = BorderStyle.Fixed3D;
            //label göster
            this.Controls.Add(lblSayi);
            //buton oluşturuldu
            Button btnHesapla = new Button();
            //buton özellikleri belirlendi
            btnHesapla.Height = 30;
            btnHesapla.Width = 100;
            btnHesapla.Top = 160;
            btnHesapla.Left = 50;
            btnHesapla.Text = ("Hesapla");
            //buton gösterildi
            this.Controls.Add(btnHesapla);
            //tıklanınca butonatik
            btnHesapla.Click += butonatik_click;
            //label oluştur
            Label lblSayigir = new Label();
            //label özellikleri
            lblSayigir.Height = 30;
            lblSayigir.Width = 210;
            lblSayigir.Top = 40;
            lblSayigir.Left = 50;
            lblSayigir.AutoSize = false;
            lblSayigir.ForeColor = Color.BurlyWood;
            lblSayigir.Text = ("Dört Basamaklı Bir Sayı Giriniz");
            //label göster
            this.Controls.Add(lblSayigir);
            //label oluştur
            Label lblOku = new Label();
            //label özellikleri
            lblOku.Height = 30;
            lblOku.Width = 210;
            lblOku.Top = 90;
            lblOku.Left = 50;
            lblOku.AutoSize = false;
            lblOku.ForeColor = Color.BurlyWood;
            lblOku.Text = ("Girdiğiniz Sayının Okunuşu: ");
            //label göster
            this.Controls.Add(lblOku);
        }
        private void degerkontrol(object sender, KeyPressEventArgs e)
        {
            // sadece integer değer girilsin
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void btnCik_click(object sender, EventArgs e)
        {
            Close();
        }

        string binler, yuzler, onlar, birler;
        int sayi, basamak4, basamak3, basamak2, basamak1;
        private void butonatik_click(object sender, EventArgs e)
        {
            if (txtSayigir.Text != "") // boş değilse devam
            {
                if (txtSayigir.Text == "0" || txtSayigir.Text == "00" || txtSayigir.Text == "000" || txtSayigir.Text == "0000")
                {
                    lblSayi.Text = "Sıfır"; //sıfırın her türlüsü sıfır olsun:)
                }
                else
                {
                    //sayıyı okuma olayı
                    sayi = Convert.ToInt32(txtSayigir.Text);
                    basamak4 = sayi / 1000;
                    sayi = sayi % 1000;
                    switch (basamak4)
                    {
                        case 1: binler = "bin "; break;
                        case 2: binler = "ikibin "; break;
                        case 3: binler = "üçbin "; break;
                        case 4: binler = "dörtbin "; break;
                        case 5: binler = "beşbin "; break;
                        case 6: binler = "altıbin "; break;
                        case 7: binler = "yedibin "; break;
                        case 8: binler = "sekizbin "; break;
                        case 9: binler = "dokuzbin "; break;
                    }
                    basamak3 = sayi / 100;
                    sayi = sayi % 100;
                    switch (basamak3)
                    {
                        case 1: yuzler = "yüz "; break;
                        case 2: yuzler = "ikiyüz "; break;
                        case 3: yuzler = "üçyüz "; break;
                        case 4: yuzler = "dörtyüz "; break;
                        case 5: yuzler = "beşyüz "; break;
                        case 6: yuzler = "altıyüz "; break;
                        case 7: yuzler = "yediyüz "; break;
                        case 8: yuzler = "sekizyüz "; break;
                        case 9: yuzler = "dokuzyüz "; break;
                    }
                    basamak2 = sayi / 10;
                    sayi = sayi % 10;
                    switch (basamak2)
                    {
                        case 1: onlar = "on "; break;
                        case 2: onlar = "yirmi "; break;
                        case 3: onlar = "otuz "; break;
                        case 4: onlar = "kırk "; break;
                        case 5: onlar = "elli "; break;
                        case 6: onlar = "altmış "; break;
                        case 7: onlar = "yetmiş "; break;
                        case 8: onlar = "seksen "; break;
                        case 9: onlar = "doksan "; break;
                    }
                    basamak1 = sayi / 1;
                    sayi = sayi % 1;
                    switch (basamak1)
                    {
                        case 1: birler = "bir"; break;
                        case 2: birler = "iki"; break;
                        case 3: birler = "üç"; break;
                        case 4: birler = "dört"; break;
                        case 5: birler = "beş"; break;
                        case 6: birler = "altı"; break;
                        case 7: birler = "yedi"; break;
                        case 8: birler = "sekiz"; break;
                        case 9: birler = "dokuz"; break;
                    }
                    //okunuşu göster
                    lblSayi.Text = binler + yuzler + onlar + birler;
                    onlar = ""; binler = ""; yuzler = ""; binler = ""; // değerleri sıfırla
                }
            }
            else MessageBox.Show("Lütfen okunacak değeri giriniz");
        }
    }
}

