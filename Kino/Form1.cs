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
        public static int brMjesta=0;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(bool isAdmin)
        {
            InitializeComponent();
            if(isAdmin) buttonAdminPanel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administracija admin = new Administracija();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f3 = new Projekcije();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
        }
    }
}
