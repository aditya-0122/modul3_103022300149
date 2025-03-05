using System.CodeDom.Compiler;

namespace Modul3_103022300149_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int angka = 0;
        int hasil = 0;
        private void Nomor1_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 1;
            label1.Text = hasil.ToString();
        }

        private void Nomor2_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 2;
            label1.Text = hasil.ToString();
        }

        private void Nomor3_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 3;
            label1.Text = hasil.ToString();
        }

        private void Nomor4_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 4;
            label1.Text = hasil.ToString();
        }

        private void Nomor5_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 5;
            label1.Text = hasil.ToString();
        }

        private void Nomor6_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 6;
            label1.Text = hasil.ToString();
        }

        private void Nomor7_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 7;
            label1.Text = hasil.ToString();
        }

        private void Nomor8_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 8;
            label1.Text = hasil.ToString();
        }

        private void Nomor9_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 9;
            label1.Text = hasil.ToString();
        }

        private void Nomor0_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10;
            label1.Text = hasil.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            angka = angka + hasil;
            label1.Text = hasil.ToString();
            hasil = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            angka = angka + hasil;
            label1.Text = angka.ToString();
            hasil = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
