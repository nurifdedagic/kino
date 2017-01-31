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
    public partial class Form1 : Form
    {
        public static string film = "";
        public static int brMjesta = 0;
        public static bool admin = false;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(bool isAdmin)
        {
            InitializeComponent();
            admin = isAdmin;
            if(isAdmin) buttonAdminPanel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mechanic
            film = "Mechanic";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administracija admn = new Administracija();
            admn.Closed += (s, args) => this.Close();
            admn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Batman v Superman
            film = "Batman v Superman";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tarzan
            film = "Tarzan";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Finding Nemo
            film = "Finding Nemo";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // The revenant
            film = "The revenant";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Star Wars: The force awakens
            film = "Star Wars: The force awakens";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Ant-man
            film = "Ant-man";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Rise guardians
            film = "Rise guardians";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // The jungle book
            film = "The jungle book";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Civil wars
            film = "Civil wars";
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            film = "";
            this.Hide();
            Login f0 = new Login();
            Form1.admin = false;
            f0.Closed += (s, args) => this.Close();
            f0.Show();
        }
    }
}
