using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();
        }

        private void buttonIzlazAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonPrikažiDodavanjeKorisnika_Click(object sender, EventArgs e)
        {
            labelKorisnickoIme.Visible = true;
            textBoxKorisničkoIme.Visible = true;
            labelSifra.Visible = true;
            textBoxSifra.Visible = true;
            checkBoxAdmin.Visible = true;
            buttonDodajKorisnika.Visible = true;
            buttonOdustani.Visible = true;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            textBoxKorisničkoIme.Text = "";
            textBoxSifra.Text = "";

            labelKorisnickoIme.Visible = false;
            textBoxKorisničkoIme.Visible = false;
            labelSifra.Visible = false;
            textBoxSifra.Visible = false;
            checkBoxAdmin.Visible = false;
            buttonDodajKorisnika.Visible = false;
            buttonOdustani.Visible = false;
        }

        private void buttonIzbrisiKorisnika_Click(object sender, EventArgs e)
        {
            if(listBoxKorisnici.SelectedIndex != -1)
                listBoxKorisnici.Items.RemoveAt(listBoxKorisnici.SelectedIndex);
        }

        private void buttonDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxKorisničkoIme.Text) && !string.IsNullOrWhiteSpace(textBoxSifra.Text))
            {
                listBoxKorisnici.Items.Add(textBoxKorisničkoIme.Text);
            }
        }
    }
}
