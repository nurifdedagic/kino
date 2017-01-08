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
    public partial class IzborSjedista : Form
    {
        public IzborSjedista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor==Color.PaleGreen) {
                button13.BackColor = Color.SkyBlue;
                Form1.brMjesta++;
            }
            else if (button13.BackColor == Color.SkyBlue)
            {
                button13.BackColor = Color.PaleGreen;
                Form1.brMjesta--;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            this.Hide();
            Racun f5 = new Racun();
            f5.Closed += (s, args) => this.Close();
            f5.Show();
        }
    }
}
