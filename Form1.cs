using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADİO_BUTTON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked ==true)
            {
                label2.Text = "iLKOĞRETİM";
            }
            else if (radioButton8.Checked ==true)
            {
                label2.Text = "ORTAOĞREİM";
            }
            else if (radioButton6.Checked ==true)
            {
                label2.Text = "Lise";
            }
            else if (radioButton10.Checked==true)
            {
                label2.Text = "Önlisans";
            }
            else if (radioButton9.Checked==true)
            {
                label2.Text = "Lisans";
            }
            else
            {
                label2.Text = "Yükseklisans";
            }
        }

        private void txtMezuniyeti_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked==true)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked==true) //BİRİNCİSİ SEÇİLDİYSE BU KOD ÇALIŞSSIN // SEÇİLDİĞİNDE YAPICAK
            {

            }
            this.BackColor = Color.Black; // this formemektir bunu için kullanırız. Form siyah nesnesine tıklıyken arka plan siyah olsun dedim..
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true) ;
            {
                this.BackColor = Color.Red;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked==true) // yeşili seçince o rengi vercek
            {
                this.BackColor = Color.Green;//this form demektir. yeşili seçtiğimde arka planın yeşil olmasooiçin gereekn kodu yaz dedim
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked==true)
            {
                this.BackColor = Color.Orange;
            }
        }
    }
}
