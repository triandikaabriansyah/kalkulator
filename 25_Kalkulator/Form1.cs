using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Angka 1 dan Angka 2 harus diisi terlebih dahulu");
            }
            else
            {
                decimal a, b, c;
                a = decimal.Parse(textBox1.Text);
                b = decimal.Parse(textBox2.Text);
                c = a + b;
                this.LBLHasil.Text = c.ToString();
            }         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Angka 1 dan Angka 2 harus diisi terlebih dahulu");
            }
            else
            {
                decimal a, b, c;
                a = decimal.Parse(textBox1.Text);
                b = decimal.Parse(textBox2.Text);
                c = a - b;
                LBLHasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 harus diisi terlebih dahulu");
            }
            else
            {
                decimal a, b, c;
                a = decimal.Parse(textBox1.Text);
                b = decimal.Parse(textBox2.Text);
                c = a * b;
                LBLHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Angka 1 dan Angka 2 harus diisi terlebih dahulu");
            }
            else 
            {
                decimal a, b, c;
                a = decimal.Parse(textBox1.Text);
                b = decimal.Parse(textBox2.Text);
                c = a / b;
                LBLHasil.Text = c.ToString();
            }
        }
    }
}
