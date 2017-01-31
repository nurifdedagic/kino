using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kino
{
    public partial class Login : Form
    {
        public static Dictionary<string, string> pocetniKorisnici = new Dictionary<string, string>(20);
        public static Dictionary<string, bool> privilegije = new Dictionary<string, bool>(20);

        public Login()
        {
            InitializeComponent();

            try
            {
                if (!(pocetniKorisnici.Count > 0))
                {
                    pocetniKorisnici.Add("admin", "admin");
                    privilegije.Add("admin", true);

                    pocetniKorisnici.Add("test", "test");
                    privilegije.Add("test", false);
                }
            }
            catch (Exception ex)
            {
                // za svaki slucaj...
                // vec postoje, ne treba nista raditi
            }

            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var pocetniKorisnici = new Dictionary<string, string>(20);
            //var privilegije = new Dictionary<string, bool>(20);

            //key -> username, value -> password
            //try
            //{
            //    pocetniKorisnici.Add("admin", "admin");
            //    privilegije.Add("admin", true);

            //    pocetniKorisnici.Add("test", "test");
            //    privilegije.Add("test", false);
            //}
            //catch(Exception ex)
            //{
            //    // vec postoje, ne treba nista raditi
            //}

            //pocetniKorisnici.Add("", "");

            string username = textBoxIme.Text, password = textBoxSifra.Text;
            var user = new KeyValuePair<string, string>(username, password);

            if (pocetniKorisnici.Contains(user))
            {                
                this.Hide();
                bool isAdmin = false;

                //if (username == "admin" && password == "admin")
                //    isAdmin = true;
                var postoji = privilegije.TryGetValue(username, out isAdmin);
                isAdmin &= postoji;

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
