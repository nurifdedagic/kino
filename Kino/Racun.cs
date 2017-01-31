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
    public partial class Racun : Form
    {
        public Racun()
        {
            InitializeComponent();
            label7.Text = Form1.brMjesta.ToString();
            label8.Text = (Form1.brMjesta * 7).ToString() + " KM";
            label4.Text += " " + Form1.film;
            this.ControlBox = false;

            //this.AcceptButton = button66;
            this.AcceptButton = button66; // ovo ne radi, klikne button64... zasto?
            this.CancelButton = button65;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Racun_Load(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            Form1.brMjesta = 0;
            for (int i = 0; i < 63; i++)
            {
                if (IzborSjedista.seats.ElementAt(i) == 1)
                    IzborSjedista.seats[i] = 0;
            }

                this.Hide();
            Form1 f1 = new Form1(Form1.admin);
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Form1.brMjesta = 0;
            for (int i = 0; i < 63; i++)
            {
                if (IzborSjedista.seats.ElementAt(i) == 1)
                    IzborSjedista.seats[i] = 2;
            }

            this.Hide();
            Form1 f1 = new Form1(Form1.admin);
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzborSjedista f3 = new IzborSjedista();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }
    }
}
