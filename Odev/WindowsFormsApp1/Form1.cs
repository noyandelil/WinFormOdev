using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGoruntule_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(TxtAd.Text);
            lstSoyad.Items.Add(TxtSoyad.Text);
            lstDersler.Items.Add(cmbDers.Text);
            lstSoru.Items.Add(rtxtSoru.Text);
            lstCevap.Items.Add(label8.Text+""+label9.Text);
            lstDurum.Items.Add(label5.Text + " " + label6.Text + " " + label7.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDers.SelectedItem = "Matematik";
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbDers.Text == "Matematik")
            {
                rtxtSoru.Text = " 0 bir rakamdır ";
                
            }
            if (cmbDers.Text == "Cografya")
            {
                rtxtSoru.Text = "Ankara Turkıyenın Baskentidir ";

            }
            if (cmbDers.Text == "Fizik")
            {
                rtxtSoru.Text = "Suyun Kaldırma Kuvvetini Arşimed Bulmustur ";

            }
            if (cmbDers.Text == "Tarih")
            {
                rtxtSoru.Text = "İstanbulu Fetheden İkinci Selimdir ";

            }
        }

        private void chkMatematik_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = chkMatematik.Text;
        }

        private void chkFizik_CheckedChanged(object sender, EventArgs e)
        {
             label6.Text=chkFizik.Text ;

        }

        private void chkKimya_CheckedChanged(object sender, EventArgs e)
        {
          label7.Text =chkKimya.Text ;
        }

        private void rdDogru_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = rdDogru.Text;
        }

        private void rdYanlis_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = rdYanlis.Text;
        }
    }
}
