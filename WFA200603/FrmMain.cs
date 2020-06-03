using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200603
{
    public partial class FrmMain : Form
    {
        int meret = 4;

        public FrmMain()
        {
            InitializeComponent();
            btnPlusz.Click += MeretValtoztatas;
            btnMinusz.Click += MeretValtoztatas;
            txtKezdoallapot.TextChanged += Gepel;
            btnEllenorzes.Click += Ellenorzes;

        }

        private void Ellenorzes(object sender, EventArgs e)
        {
            if (Math.Pow(meret, 2) == txtKezdoallapot.Text.Length)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            }
            else if (Math.Pow(meret, 2) > txtKezdoallapot.Text.Length)
            {
                MessageBox.Show($"A feladvány rövid: kell még {Math.Pow(meret, 2) - txtKezdoallapot.Text.Length} számjegy!");
            }
            else
            {
                MessageBox.Show($"A feladvány hosszú: törlendő {txtKezdoallapot.Text.Length - Math.Pow(meret, 2)} számjegy!");
            }
        }

        private void Gepel(object sender, EventArgs e)
        {
            lblHossz.Text = $"Hossz: {txtKezdoallapot.Text.Length}";
        }

        private void MeretValtoztatas(object sender, EventArgs e)
        {
            if((sender as Button).Text == "-" && int.Parse(txtMeret.Text) > 4)
            {
                meret--;
            }
            if((sender as Button).Text == "+" && int.Parse(txtMeret.Text) < 9)
            {
                meret++;
            }
            txtMeret.Text = $"{meret}";
        }
    }
}
