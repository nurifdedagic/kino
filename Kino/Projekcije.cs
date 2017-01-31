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
    public partial class Projekcije : Form
    {
        public static List<Projekcija> sveProjekcije = new List<Projekcija>();
        public static List<Projekcija> projekcije = new List<Projekcija>();
        public static int index = -1;
        public static string filterDan = "";
        public static string filterSala = "";

        public Projekcije()
        {
            InitializeComponent();
            filterDan = "";
            filterSala = "";
            label1.Text += " " + Form1.film;
            if (sveProjekcije.Count() == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Projekcija p = new Projekcija();
                    p.datumVrijeme = DateTime.Now;
                    p.Cijena = "7 KM";
                    p.Sala = "Sala " + (i + 1).ToString();
                    sveProjekcije.Add(p);
                }
                for (int i = 0; i < 5; i++)
                {
                    Projekcija p = new Projekcija();
                    p.datumVrijeme = DateTime.Now.AddHours(2);
                    p.Cijena = "7 KM";
                    p.Sala = "Sala " + (i + 1).ToString();
                    sveProjekcije.Add(p);
                }

                //var source = new BindingSource();
                //source.DataSource = projekcije;
                //this.dataGridView1.DataSource = source;
                //this.dataGridView1.DataSource = projekcije;
            }
            projekcije = sveProjekcije;
            this.dataGridView1.DataSource = projekcije;
            if (index > -1 && index < projekcije.Count && this.dataGridView1.Rows[index].Selected == false)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
                dataGridView1.Refresh();
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                this.dataGridView1.Rows[index].Selected = true;
                dataGridView1.Refresh();
            }
            //this.dataGridView1.Rows[index].
            this.ControlBox = false;

            this.CancelButton = button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            IzborSjedista f4 = new IzborSjedista();
            f4.Closed += (s, args) => this.Close();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.brMjesta = 0;
            if(IzborSjedista.seats.Count > 0)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            projekcije = new List<Projekcija>(sveProjekcije);
            //foreach (var p in sveProjekcije) projekcije.Add(p);
            if (!String.IsNullOrEmpty((sender as ComboBox).SelectedItem.ToString()))
                filterSala = (sender as ComboBox).SelectedItem.ToString();
            else
                filterSala = "";

            if(filterSala != "")
                projekcije.RemoveAll(p => p.Sala != filterSala);
            if(filterDan != "")
                if(filterDan != "Utorak")
                    projekcije.Clear();

            dataGridView1.DataSource = projekcije;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if ((sender as DataGridView).SelectedRows.Count == 1)
            //    index = (sender as DataGridView).SelectedRows[0].Index;
            //else index = -1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
                index = (sender as DataGridView).SelectedRows[0].Index;
            else index = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            projekcije = new List<Projekcija>(sveProjekcije);
            //foreach (var p in sveProjekcije) projekcije.Add(p);
            if (!String.IsNullOrEmpty((sender as ComboBox).SelectedItem.ToString()))
                filterDan = (sender as ComboBox).SelectedItem.ToString();
            else
                filterDan = "";
            if (filterSala != "")
                projekcije.RemoveAll(p => p.Sala != filterSala);
            if (filterDan != "")
                if (filterDan != "Utorak")
                    projekcije.Clear();
            //if ((sender as ComboBox).SelectedItem.ToString() == "Utorak")
            //        projekcije.Clear();
            //comboBox2.Text = "";
            dataGridView1.DataSource = projekcije;
        }
    }
}
