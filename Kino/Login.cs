using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kino
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pocetniKorisnici = new Dictionary<string, string>(3);

            //key -> username, value -> password
            pocetniKorisnici.Add("admin", "admin");
            pocetniKorisnici.Add("test", "test");
            pocetniKorisnici.Add("", "");

            string username = textBoxIme.Text, password = textBoxSifra.Text;
            var user = new KeyValuePair<string, string>(username, password);

            if (pocetniKorisnici.Contains(user))
            {                
                this.Hide();
                bool isAdmin = false;

                if (username == "admin" && password == "admin")
                    isAdmin = true;

                Form1 f1 = new Form1(isAdmin);
                f1.Closed += (s, args) => this.Close();
                f1.Show();
            }
            else
            {
                labelForErrorProvider.Visible = true;
                errorProviderInvalidUser.SetError(labelForErrorProvider, "Nepostojeći korisnik.");
            }
        }
    }
}
