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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Racun_Load(object sender, EventArgs e)
        {

        }
    }
}
