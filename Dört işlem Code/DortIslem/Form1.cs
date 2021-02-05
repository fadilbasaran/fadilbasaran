using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       
        private void btnTopla_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100);
            int sayi2 = rastgele.Next(100);
            int sonuc = sayi + sayi2;
            lblSonuc.Visible = false;
            lblSonuc.Text = (Convert.ToInt64(sayi) + Convert.ToInt64(sayi2)).ToString();
            lblIsaret.Text = "+";
            lblGoster1.Text = sayi.ToString();
            lblGoster2.Text = sayi2.ToString() + "  = ";
            txtboxCevap.Enabled = true;
            btnTemizle.Enabled = true;

        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100);
            int sayi2 = rastgele.Next(100);
            int sonuc = sayi + sayi2;
            lblSonuc.Visible = false;
            lblSonuc.Text = (Convert.ToInt64(sayi) - Convert.ToInt64(sayi2)).ToString();
            lblIsaret.Text = "-";
            lblGoster1.Text = sayi.ToString();
            lblGoster2.Text = sayi2.ToString() + "  = ";
            txtboxCevap.Enabled = true;
            btnTemizle.Enabled = true;
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100);
            int sayi2 = rastgele.Next(100);
            int sonuc = sayi + sayi2;
            lblSonuc.Visible = false;
            lblSonuc.Text = (Convert.ToDouble(sayi) / Convert.ToDouble(sayi2)).ToString();
            lblIsaret.Text = "/";
            lblGoster1.Text = sayi.ToString();
            lblGoster2.Text = sayi2.ToString() + "  = ";
            txtboxCevap.Enabled = true;
            btnTemizle.Enabled = true;
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100);
            int sayi2 = rastgele.Next(100);
            int sonuc = sayi + sayi2;
            lblSonuc.Visible = false;
            lblSonuc.Text = (Convert.ToInt64(sayi) * Convert.ToInt64(sayi2)).ToString();
            lblIsaret.Text = "*";
            lblGoster1.Text = sayi.ToString();
            lblGoster2.Text = sayi2.ToString() + "  = ";
            txtboxCevap.Enabled = true;
            btnTemizle.Enabled = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            txtboxCevap.Clear();
            lblGoster1.Text = "";
            lblGoster2.Text = "";
            lblIsaret.Text = "";
            lblSonuc.Text = "";
            lblCevap.Text = "";
            btnKontrol.Enabled = false;
            txtboxCevap.Enabled = false;
            lblCevapGoster.Visible = false;
            btnTemizle.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {



            btnTemizle.Enabled = false;
            btnKontrol.Enabled = false;
            txtboxCevap.Enabled = false;
            lblCevapGoster.Visible = false;

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //Boş girdi yapmasını engellemek için...
            if (String.IsNullOrEmpty(txtboxCevap.Text))
            {
                MessageBox.Show("Lütfen Cevabınızı Giriniz...","Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            else
            {
                if (Convert.ToUInt32(txtboxCevap.Text) == Convert.ToUInt32(lblSonuc.Text))
                {
                    lblCevapGoster.Visible = false;
                    lblCevap.Text = "Tebrikler Doğru Cevap Verdiniz...";
                    lblSonuc.Visible = false;
                    btnKontrol.Enabled = false;

                }
                else
                {
                    lblCevapGoster.Visible = true;
                    lblCevap.Text = "Yanlış Cevap Verdiniz...";
                    lblSonuc.Visible = true;
                    btnKontrol.Enabled = false;
                }

            }


        }

        private void txtboxCevap_TextChanged(object sender, EventArgs e)
        {
            btnKontrol.Enabled = true;
        }
        

        //Sadece Sayı girmesini sağlamak için
        private void txtboxCevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
