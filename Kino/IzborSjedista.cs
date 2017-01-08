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
            if (button13.BackColor==Color.LightGreen) {
                button13.BackColor = Color.SkyBlue;
            }
            else if (button13.BackColor == Color.SkyBlue)
            {
                button13.BackColor = Color.LightGreen;
            }
        }
    }
}
