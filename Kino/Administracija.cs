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
            List<string> korisnici = Login.pocetniKorisnici.Values.ToList();
            listBoxKorisnici.DataSource = korisnici;
            //listBoxKorisnici.DisplayMember = korisnici;
            //listBoxKorisnici.SelectedValue = korisnici;
            //this.ControlBox = false;
            listBoxKorisnici.SelectedIndex = 0;

            if (Projekcije.sveProjekcije.Count() == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Projekcija p = new Projekcija();
                    p.datumVrijeme = DateTime.Now;
                    p.Cijena = "7 KM";
                    p.Sala = "Sala " + (i + 1).ToString();
                    Projekcije.sveProjekcije.Add(p);
                }
                for (int i = 0; i < 5; i++)
                {
                    Projekcija p = new Projekcija();
                    p.datumVrijeme = DateTime.Now.AddHours(2);
                    p.Cijena = "7 KM";
                    p.Sala = "Sala " + (i + 1).ToString();
                    Projekcije.sveProjekcije.Add(p);
                }

                //var source = new BindingSource();
                //source.DataSource = projekcije;
                //this.dataGridView1.DataSource = source;
                //this.dataGridView1.DataSource = projekcije;
            }
            Projekcije.projekcije = Projekcije.sveProjekcije;
            this.dataGridView1.DataSource = Projekcije.projekcije;

            this.CancelButton = buttonIzlazAdmin;
        }

        private void buttonIzlazAdmin_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            Form1 f1 = new Form1(true);
            f1.Closed += (s, args) => this.Close();
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
            //if(listBoxKorisnici.SelectedIndex != -1)
            //    listBoxKorisnici.Items.RemoveAt(listBoxKorisnici.SelectedIndex);
            //listBoxKorisnici.DataSource = null;
            if (!String.IsNullOrWhiteSpace(listBoxKorisnici.SelectedItem.ToString()))
            {
                Login.pocetniKorisnici.Remove(listBoxKorisnici.SelectedItem.ToString());
                Login.privilegije.Remove(listBoxKorisnici.SelectedItem.ToString());
            }
            listBoxKorisnici.DataSource = null;
            List<string> korisnici = Login.pocetniKorisnici.Values.ToList();
            listBoxKorisnici.DataSource = korisnici;
        }

        private void buttonDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxKorisničkoIme.Text) && !string.IsNullOrWhiteSpace(textBoxSifra.Text))
            {
                //listBoxKorisnici.Items.Add(textBoxKorisničkoIme.Text);
                try
                {
                    Login.pocetniKorisnici.Add(textBoxKorisničkoIme.Text, textBoxSifra.Text);
                    Login.privilegije.Add(textBoxKorisničkoIme.Text, checkBoxAdmin.Checked);

                    listBoxKorisnici.DataSource = null;
                    List<string> korisnici = Login.pocetniKorisnici.Values.ToList();
                    listBoxKorisnici.DataSource = korisnici;

                    //MessageBox.Show("uspješno ste dodali novog korisnika!", "Novi korisnik je dodan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Korisničko ime već postoji!", "Greška prilikom dodavanja korisnika!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            Form1 f1 = new Form1(true);
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }
    }
}
