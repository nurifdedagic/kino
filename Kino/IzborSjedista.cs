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
        public void setColors()
        {
            if (seats.Count == 0)
                for (int i = 0; i < 63; i++)
                    seats.Add(0);

            if (buttons.Count == 0)
            {
                buttons.Add(button1);
                buttons.Add(button2);
                buttons.Add(button3);
                buttons.Add(button4);
                buttons.Add(button5);
                buttons.Add(button6);
                buttons.Add(button7);
                buttons.Add(button8);
                buttons.Add(button9);
                buttons.Add(button10);
                buttons.Add(button11);
                buttons.Add(button12);
                buttons.Add(button13);
                buttons.Add(button14);
                buttons.Add(button15);
                buttons.Add(button16);
                buttons.Add(button17);
                buttons.Add(button18);
                buttons.Add(button19);
                buttons.Add(button20);
                buttons.Add(button21);
                buttons.Add(button22);
                buttons.Add(button23);
                buttons.Add(button24);
                buttons.Add(button25);
                buttons.Add(button26);
                buttons.Add(button27);
                buttons.Add(button28);
                buttons.Add(button29);
                buttons.Add(button30);
                buttons.Add(button31);
                buttons.Add(button32);
                buttons.Add(button33);
                buttons.Add(button34);
                buttons.Add(button35);
                buttons.Add(button36);
                buttons.Add(button37);
                buttons.Add(button38);
                buttons.Add(button39);
                buttons.Add(button40);
                buttons.Add(button41);
                buttons.Add(button42);
                buttons.Add(button43);
                buttons.Add(button44);
                buttons.Add(button45);
                buttons.Add(button46);
                buttons.Add(button47);
                buttons.Add(button48);
                buttons.Add(button49);
                buttons.Add(button50);
                buttons.Add(button51);
                buttons.Add(button52);
                buttons.Add(button53);
                buttons.Add(button54);
                buttons.Add(button55);
                buttons.Add(button56);
                buttons.Add(button57);
                buttons.Add(button58);
                buttons.Add(button59);
                buttons.Add(button60);
                buttons.Add(button61);
                buttons.Add(button62);
                buttons.Add(button63);
            }

            for (int i = 0; i < 63; i++)
            {
                if (seats.ElementAt(i) == 0)
                    buttons.ElementAt(i).BackColor = System.Drawing.Color.PaleGreen;
                else if (seats.ElementAt(i) == 1)
                    buttons.ElementAt(i).BackColor = System.Drawing.Color.SkyBlue;
                else if (seats.ElementAt(i) == 2)
                    buttons.ElementAt(i).BackColor = System.Drawing.Color.LightCoral;
            }
        }

        public static List<int> seats = new List<int>(63);
        public static List<Button> buttons = new List<Button>(63);
        public IzborSjedista()
        {
            InitializeComponent();
            //Form1.brMjesta = 0;
            this.ControlBox = false;

            if (seats.Count == 0)
                for (int i = 0; i < 63; i++)
                    seats.Add(0);

            //if (seats.ElementAt(0) == 0)
            //    button1.BackColor = System.Drawing.Color.PaleGreen;
            //else if (seats.ElementAt(0) == 1)
            //    button1.BackColor = System.Drawing.Color.SkyBlue;
            //else if (seats.ElementAt(0) == 2)
            //    button1.BackColor = System.Drawing.Color.LightCoral;

            while (buttons.Count > 0)
                buttons.RemoveAt(0);
            if (buttons.Count == 0)
            {
                buttons.Add(button1);
                buttons.Add(button2);
                buttons.Add(button3);
                buttons.Add(button4);
                buttons.Add(button5);
                buttons.Add(button6);
                buttons.Add(button7);
                buttons.Add(button8);
                buttons.Add(button9);
                buttons.Add(button10);
                buttons.Add(button11);
                buttons.Add(button12);
                buttons.Add(button13);
                buttons.Add(button14);
                buttons.Add(button15);
                buttons.Add(button16);
                buttons.Add(button17);
                buttons.Add(button18);
                buttons.Add(button19);
                buttons.Add(button20);
                buttons.Add(button21);
                buttons.Add(button22);
                buttons.Add(button23);
                buttons.Add(button24);
                buttons.Add(button25);
                buttons.Add(button26);
                buttons.Add(button27);
                buttons.Add(button28);
                buttons.Add(button29);
                buttons.Add(button30);
                buttons.Add(button31);
                buttons.Add(button32);
                buttons.Add(button33);
                buttons.Add(button34);
                buttons.Add(button35);
                buttons.Add(button36);
                buttons.Add(button37);
                buttons.Add(button38);
                buttons.Add(button39);
                buttons.Add(button40);
                buttons.Add(button41);
                buttons.Add(button42);
                buttons.Add(button43);
                buttons.Add(button44);
                buttons.Add(button45);
                buttons.Add(button46);
                buttons.Add(button47);
                buttons.Add(button48);
                buttons.Add(button49);
                buttons.Add(button50);
                buttons.Add(button51);
                buttons.Add(button52);
                buttons.Add(button53);
                buttons.Add(button54);
                buttons.Add(button55);
                buttons.Add(button56);
                buttons.Add(button57);
                buttons.Add(button58);
                buttons.Add(button59);
                buttons.Add(button60);
                buttons.Add(button61);
                buttons.Add(button62);
                buttons.Add(button63);
            }

            for (int i = 0; i < 63; i++)
            {
                if (seats.ElementAt(i) == 0)
                    buttons.ElementAt(i).BackColor = Color.PaleGreen;
                else if (seats.ElementAt(i) == 1)
                    buttons.ElementAt(i).BackColor = Color.SkyBlue;
                else if (seats.ElementAt(i) == 2)
                    buttons.ElementAt(i).BackColor = Color.LightCoral;
            }

            this.CancelButton = button65;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor==Color.PaleGreen) {
                button13.BackColor = Color.SkyBlue;
                seats[12] = 1;
                Form1.brMjesta++;
            }
            else if (button13.BackColor == Color.SkyBlue)
            {
                button13.BackColor = Color.PaleGreen;
                seats[12] = 0;
                Form1.brMjesta--;
            }
            else if (button13.BackColor == Color.LightCoral)
            {
                button13.BackColor = Color.PaleGreen;
                seats[12] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            this.Hide();
            Racun f5 = new Racun();
            f5.Closed += (s, args) => this.Close();
            f5.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.PaleGreen)
            {
                button12.BackColor = Color.SkyBlue;
                seats[11] = 1;
                Form1.brMjesta++;
            }
            else if (button12.BackColor == Color.SkyBlue)
            {
                button12.BackColor = Color.PaleGreen;
                seats[11] = 0;
                Form1.brMjesta--;
            }
            else if (button12.BackColor == Color.LightCoral)
            {
                button12.BackColor = Color.SkyBlue;
                seats[11] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.PaleGreen)
            {
                button11.BackColor = Color.SkyBlue;
                seats[10] = 1;
                Form1.brMjesta++;
            }
            else if (button11.BackColor == Color.SkyBlue)
            {
                button11.BackColor = Color.PaleGreen;
                seats[10] = 0;
                Form1.brMjesta--;
            }
            else if (button11.BackColor == Color.LightCoral)
            {
                button11.BackColor = Color.PaleGreen;
                seats[10] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.PaleGreen)
            {
                button10.BackColor = Color.SkyBlue;
                seats[9] = 1;
                Form1.brMjesta++;
            }
            else if (button10.BackColor == Color.SkyBlue)
            {
                button10.BackColor = Color.PaleGreen;
                seats[9] = 0;
                Form1.brMjesta--;
            }
            else if (button10.BackColor == Color.LightCoral)
            {
                button10.BackColor = Color.PaleGreen;
                seats[9] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.PaleGreen)
            {
                button9.BackColor = Color.SkyBlue;
                seats[8] = 1;
                Form1.brMjesta++;
            }
            else if (button9.BackColor == Color.SkyBlue)
            {
                button9.BackColor = Color.PaleGreen;
                seats[8] = 0;
                Form1.brMjesta--;
            }
            else if (button9.BackColor == Color.LightCoral)
            {
                button9.BackColor = Color.PaleGreen;
                seats[8] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.PaleGreen)
            {
                button8.BackColor = Color.SkyBlue;
                seats[7] = 1;
                Form1.brMjesta++;
            }
            else if (button8.BackColor == Color.SkyBlue)
            {
                button8.BackColor = Color.PaleGreen;
                seats[7] = 0;
                Form1.brMjesta--;
            }
            else if (button8.BackColor == Color.LightCoral)
            {
                button8.BackColor = Color.PaleGreen;
                seats[7] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.PaleGreen)
            {
                button7.BackColor = Color.SkyBlue;
                seats[6] = 1;
                Form1.brMjesta++;
            }
            else if (button7.BackColor == Color.SkyBlue)
            {
                button7.BackColor = Color.PaleGreen;
                seats[6] = 0;
                Form1.brMjesta--;
            }
            else if (button7.BackColor == Color.LightCoral)
            {
                button7.BackColor = Color.PaleGreen;
                seats[6] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.PaleGreen)
            {
                button6.BackColor = Color.SkyBlue;
                seats[5] = 1;
                Form1.brMjesta++;
            }
            else if (button6.BackColor == Color.SkyBlue)
            {
                button6.BackColor = Color.PaleGreen;
                seats[5] = 0;
                Form1.brMjesta--;
            }
            else if (button6.BackColor == Color.LightCoral)
            {
                button6.BackColor = Color.PaleGreen;
                seats[5] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.PaleGreen)
            {
                button5.BackColor = Color.SkyBlue;
                seats[4] = 1;
                Form1.brMjesta++;
            }
            else if (button5.BackColor == Color.SkyBlue)
            {
                button5.BackColor = Color.PaleGreen;
                seats[4] = 0;
                Form1.brMjesta--;
            }
            else if (button5.BackColor == Color.LightCoral)
            {
                button5.BackColor = Color.PaleGreen;
                seats[4] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.PaleGreen)
            {
                button4.BackColor = Color.SkyBlue;
                seats[3] = 1;
                Form1.brMjesta++;
            }
            else if (button4.BackColor == Color.SkyBlue)
            {
                button4.BackColor = Color.PaleGreen;
                seats[3] = 0;
                Form1.brMjesta--;
            }
            else if (button4.BackColor == Color.LightCoral)
            {
                button4.BackColor = Color.PaleGreen;
                seats[3] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.PaleGreen)
            {
                button3.BackColor = Color.SkyBlue;
                seats[2] = 1;
                Form1.brMjesta++;
            }
            else if (button3.BackColor == Color.SkyBlue)
            {
                button3.BackColor = Color.PaleGreen;
                seats[2] = 0;
                Form1.brMjesta--;
            }
            else if (button3.BackColor == Color.LightCoral)
            {
                button3.BackColor = Color.PaleGreen;
                seats[2] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.PaleGreen)
            {
                button2.BackColor = Color.SkyBlue;
                seats[1] = 1;
                Form1.brMjesta++;
            }
            else if (button2.BackColor == Color.SkyBlue)
            {
                button2.BackColor = Color.PaleGreen;
                seats[1] = 0;
                Form1.brMjesta--;
            }
            else if (button2.BackColor == Color.LightCoral)
            {
                button2.BackColor = Color.PaleGreen;
                seats[1] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.PaleGreen)
            {
                button14.BackColor = Color.SkyBlue;
                seats[13] = 1;
                Form1.brMjesta++;
            }
            else if (button14.BackColor == Color.SkyBlue)
            {
                button14.BackColor = Color.PaleGreen;
                seats[13] = 0;
                Form1.brMjesta--;
            }
            else if (button14.BackColor == Color.LightCoral)
            {
                button14.BackColor = Color.PaleGreen;
                seats[13] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.PaleGreen)
            {
                button15.BackColor = Color.SkyBlue;
                seats[14] = 1;
                Form1.brMjesta++;
            }
            else if (button15.BackColor == Color.SkyBlue)
            {
                button15.BackColor = Color.PaleGreen;
                seats[14] = 0;
                Form1.brMjesta--;
            }
            else if (button15.BackColor == Color.LightCoral)
            {
                button15.BackColor = Color.PaleGreen;
                seats[14] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.PaleGreen)
            {
                button1.BackColor = Color.SkyBlue;
                seats[0] = 1;
                Form1.brMjesta++;
            }
            else if (button1.BackColor == Color.SkyBlue)
            {
                button1.BackColor = Color.PaleGreen;
                seats[0] = 0;
                Form1.brMjesta--;
            }
            else if (button1.BackColor == Color.LightCoral)
            {
                button1.BackColor = Color.PaleGreen;
                seats[0] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.PaleGreen)
            {
                button16.BackColor = Color.SkyBlue;
                seats[15] = 1;
                Form1.brMjesta++;
            }
            else if (button16.BackColor == Color.SkyBlue)
            {
                button16.BackColor = Color.PaleGreen;
                seats[15] = 0;
                Form1.brMjesta--;
            }
            else if (button16.BackColor == Color.LightCoral)
            {
                button16.BackColor = Color.PaleGreen;
                seats[15] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.PaleGreen)
            {
                button17.BackColor = Color.SkyBlue;
                seats[16] = 1;
                Form1.brMjesta++;
            }
            else if (button17.BackColor == Color.SkyBlue)
            {
                button17.BackColor = Color.PaleGreen;
                seats[16] = 0;
                Form1.brMjesta--;
            }
            else if (button17.BackColor == Color.LightCoral)
            {
                button17.BackColor = Color.PaleGreen;
                seats[16] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (button54.BackColor == Color.PaleGreen)
            {
                button54.BackColor = Color.SkyBlue;
                seats[53] = 1;
                Form1.brMjesta++;
            }
            else if (button54.BackColor == Color.SkyBlue)
            {
                button54.BackColor = Color.PaleGreen;
                seats[53] = 0;
                Form1.brMjesta--;
            }
            else if (button54.BackColor == Color.LightCoral)
            {
                button54.BackColor = Color.PaleGreen;
                seats[53] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (button55.BackColor == Color.PaleGreen)
            {
                button55.BackColor = Color.SkyBlue;
                seats[54] = 1;
                Form1.brMjesta++;
            }
            else if (button55.BackColor == Color.SkyBlue)
            {
                button55.BackColor = Color.PaleGreen;
                seats[54] = 0;
                Form1.brMjesta--;
            }
            else if (button55.BackColor == Color.LightCoral)
            {
                button55.BackColor = Color.PaleGreen;
                seats[54] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (button56.BackColor == Color.PaleGreen)
            {
                button56.BackColor = Color.SkyBlue;
                seats[55] = 1;
                Form1.brMjesta++;
            }
            else if (button56.BackColor == Color.SkyBlue)
            {
                button56.BackColor = Color.PaleGreen;
                seats[55] = 0;
                Form1.brMjesta--;
            }
            else if (button56.BackColor == Color.LightCoral)
            {
                button56.BackColor = Color.PaleGreen;
                seats[55] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (button57.BackColor == Color.PaleGreen)
            {
                button57.BackColor = Color.SkyBlue;
                seats[56] = 1;
                Form1.brMjesta++;
            }
            else if (button57.BackColor == Color.SkyBlue)
            {
                button57.BackColor = Color.PaleGreen;
                seats[56] = 0;
                Form1.brMjesta--;
            }
            else if (button57.BackColor == Color.LightCoral)
            {
                button57.BackColor = Color.PaleGreen;
                seats[56] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (button58.BackColor == Color.PaleGreen)
            {
                button58.BackColor = Color.SkyBlue;
                seats[57] = 1;
                Form1.brMjesta++;
            }
            else if (button58.BackColor == Color.SkyBlue)
            {
                button58.BackColor = Color.PaleGreen;
                seats[57] = 0;
                Form1.brMjesta--;
            }
            else if (button58.BackColor == Color.LightCoral)
            {
                button58.BackColor = Color.PaleGreen;
                seats[57] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (button59.BackColor == Color.PaleGreen)
            {
                button59.BackColor = Color.SkyBlue;
                seats[58] = 1;
                Form1.brMjesta++;
            }
            else if (button59.BackColor == Color.SkyBlue)
            {
                button59.BackColor = Color.PaleGreen;
                seats[58] = 0;
                Form1.brMjesta--;
            }
            else if (button59.BackColor == Color.SkyBlue)
            {
                button59.BackColor = Color.PaleGreen;
                seats[58] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (button60.BackColor == Color.PaleGreen)
            {
                button60.BackColor = Color.SkyBlue;
                seats[59] = 1;
                Form1.brMjesta++;
            }
            else if (button60.BackColor == Color.SkyBlue)
            {
                button60.BackColor = Color.PaleGreen;
                seats[59] = 0;
                Form1.brMjesta--;
            }
            else if (button60.BackColor == Color.LightCoral)
            {
                button60.BackColor = Color.PaleGreen;
                seats[59] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (button61.BackColor == Color.PaleGreen)
            {
                button61.BackColor = Color.SkyBlue;
                seats[60] = 1;
                Form1.brMjesta++;
            }
            else if (button61.BackColor == Color.SkyBlue)
            {
                button61.BackColor = Color.PaleGreen;
                seats[60] = 0;
                Form1.brMjesta--;
            }
            else if (button61.BackColor == Color.LightCoral)
            {
                button61.BackColor = Color.PaleGreen;
                seats[60] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (button62.BackColor == Color.PaleGreen)
            {
                button62.BackColor = Color.SkyBlue;
                seats[61] = 1;
                Form1.brMjesta++;
            }
            else if (button62.BackColor == Color.SkyBlue)
            {
                button62.BackColor = Color.PaleGreen;
                seats[61] = 0;
                Form1.brMjesta--;
            }
            else if (button62.BackColor == Color.LightCoral)
            {
                button62.BackColor = Color.PaleGreen;
                seats[61] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.BackColor == Color.PaleGreen)
            {
                button63.BackColor = Color.SkyBlue;
                seats[62] = 1;
                Form1.brMjesta++;
            }
            else if (button63.BackColor == Color.SkyBlue)
            {
                button63.BackColor = Color.PaleGreen;
                seats[62] = 0;
                Form1.brMjesta--;
            }
            else if (button63.BackColor == Color.LightCoral)
            {
                button63.BackColor = Color.PaleGreen;
                seats[62] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.PaleGreen)
            {
                button20.BackColor = Color.SkyBlue;
                seats[19] = 1;
                Form1.brMjesta++;
            }
            else if (button20.BackColor == Color.SkyBlue)
            {
                button20.BackColor = Color.PaleGreen;
                seats[19] = 0;
                Form1.brMjesta--;
            }
            else if (button20.BackColor == Color.LightCoral)
            {
                button20.BackColor = Color.PaleGreen;
                seats[19] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.PaleGreen)
            {
                button19.BackColor = Color.SkyBlue;
                seats[18] = 1;
                Form1.brMjesta++;
            }
            else if (button19.BackColor == Color.SkyBlue)
            {
                button19.BackColor = Color.PaleGreen;
                seats[18] = 0;
                Form1.brMjesta--;
            }
            else if (button19.BackColor == Color.LightCoral)
            {
                button19.BackColor = Color.PaleGreen;
                seats[18] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.PaleGreen)
            {
                button18.BackColor = Color.SkyBlue;
                seats[17] = 1;
                Form1.brMjesta++;
            }
            else if (button18.BackColor == Color.SkyBlue)
            {
                button18.BackColor = Color.PaleGreen;
                seats[17] = 0;
                Form1.brMjesta--;
            }
            else if (button18.BackColor == Color.LightCoral)
            {
                button18.BackColor = Color.PaleGreen;
                seats[17] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.PaleGreen)
            {
                button23.BackColor = Color.SkyBlue;
                seats[22] = 1;
                Form1.brMjesta++;
            }
            else if (button23.BackColor == Color.SkyBlue)
            {
                button23.BackColor = Color.PaleGreen;
                seats[22] = 0;
                Form1.brMjesta--;
            }
            else if (button23.BackColor == Color.LightCoral)
            {
                button23.BackColor = Color.PaleGreen;
                seats[22] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.PaleGreen)
            {
                button22.BackColor = Color.SkyBlue;
                seats[21] = 1;
                Form1.brMjesta++;
            }
            else if (button22.BackColor == Color.SkyBlue)
            {
                button22.BackColor = Color.PaleGreen;
                seats[21] = 0;
                Form1.brMjesta--;
            }
            else if (button22.BackColor == Color.LightCoral)
            {
                button22.BackColor = Color.PaleGreen;
                seats[21] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.PaleGreen)
            {
                button21.BackColor = Color.SkyBlue;
                seats[20] = 1;
                Form1.brMjesta++;
            }
            else if (button21.BackColor == Color.SkyBlue)
            {
                button21.BackColor = Color.PaleGreen;
                seats[20] = 0;
                Form1.brMjesta--;
            }
            else if (button21.BackColor == Color.LightCoral)
            {
                button21.BackColor = Color.PaleGreen;
                seats[20] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.PaleGreen)
            {
                button26.BackColor = Color.SkyBlue;
                seats[25] = 1;
                Form1.brMjesta++;
            }
            else if (button26.BackColor == Color.SkyBlue)
            {
                button26.BackColor = Color.PaleGreen;
                seats[25] = 0;
                Form1.brMjesta--;
            }
            else if (button26.BackColor == Color.LightCoral)
            {
                button26.BackColor = Color.PaleGreen;
                seats[25] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.PaleGreen)
            {
                button25.BackColor = Color.SkyBlue;
                seats[24] = 1;
                Form1.brMjesta++;
            }
            else if (button25.BackColor == Color.SkyBlue)
            {
                button25.BackColor = Color.PaleGreen;
                seats[24] = 0;
                Form1.brMjesta--;
            }
            else if (button25.BackColor == Color.LightCoral)
            {
                button25.BackColor = Color.PaleGreen;
                seats[24] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.PaleGreen)
            {
                button24.BackColor = Color.SkyBlue;
                seats[23] = 1;
                Form1.brMjesta++;
            }
            else if (button24.BackColor == Color.SkyBlue)
            {
                button24.BackColor = Color.PaleGreen;
                seats[23] = 0;
                Form1.brMjesta--;
            }
            else if (button24.BackColor == Color.LightCoral)
            {
                button24.BackColor = Color.PaleGreen;
                seats[23] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.PaleGreen)
            {
                button29.BackColor = Color.SkyBlue;
                seats[28] = 1;
                Form1.brMjesta++;
            }
            else if (button29.BackColor == Color.SkyBlue)
            {
                button29.BackColor = Color.PaleGreen;
                seats[28] = 0;
                Form1.brMjesta--;
            }
            else if (button29.BackColor == Color.LightCoral)
            {
                button29.BackColor = Color.PaleGreen;
                seats[28] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.PaleGreen)
            {
                button28.BackColor = Color.SkyBlue;
                seats[27] = 1;
                Form1.brMjesta++;
            }
            else if (button28.BackColor == Color.SkyBlue)
            {
                button28.BackColor = Color.PaleGreen;
                seats[27] = 0;
                Form1.brMjesta--;
            }
            else if (button28.BackColor == Color.LightCoral)
            {
                button28.BackColor = Color.PaleGreen;
                seats[27] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.PaleGreen)
            {
                button27.BackColor = Color.SkyBlue;
                seats[26] = 1;
                Form1.brMjesta++;
            }
            else if (button27.BackColor == Color.SkyBlue)
            {
                button27.BackColor = Color.PaleGreen;
                seats[26] = 0;
                Form1.brMjesta--;
            }
            else if (button27.BackColor == Color.LightCoral)
            {
                button27.BackColor = Color.PaleGreen;
                seats[26] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.PaleGreen)
            {
                button30.BackColor = Color.SkyBlue;
                seats[29] = 1;
                Form1.brMjesta++;
            }
            else if (button30.BackColor == Color.SkyBlue)
            {
                button30.BackColor = Color.PaleGreen;
                seats[29] = 0;
                Form1.brMjesta--;
            }
            else if (button30.BackColor == Color.LightCoral)
            {
                button30.BackColor = Color.PaleGreen;
                seats[29] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == Color.PaleGreen)
            {
                button31.BackColor = Color.SkyBlue;
                seats[30] = 1;
                Form1.brMjesta++;
            }
            else if (button31.BackColor == Color.SkyBlue)
            {
                button31.BackColor = Color.PaleGreen;
                seats[30] = 0;
                Form1.brMjesta--;
            }
            else if (button31.BackColor == Color.LightCoral)
            {
                button31.BackColor = Color.PaleGreen;
                seats[30] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == Color.PaleGreen)
            {
                button32.BackColor = Color.SkyBlue;
                seats[31] = 1;
                Form1.brMjesta++;
            }
            else if (button32.BackColor == Color.SkyBlue)
            {
                button32.BackColor = Color.PaleGreen;
                seats[31] = 0;
                Form1.brMjesta--;
            }
            else if (button32.BackColor == Color.LightCoral)
            {
                button32.BackColor = Color.PaleGreen;
                seats[31] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.PaleGreen)
            {
                button33.BackColor = Color.SkyBlue;
                seats[32] = 1;
                Form1.brMjesta++;
            }
            else if (button33.BackColor == Color.SkyBlue)
            {
                button33.BackColor = Color.PaleGreen;
                seats[32] = 0;
                Form1.brMjesta--;
            }
            else if (button33.BackColor == Color.LightCoral)
            {
                button33.BackColor = Color.PaleGreen;
                seats[32] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.PaleGreen)
            {
                button34.BackColor = Color.SkyBlue;
                seats[33] = 1;
                Form1.brMjesta++;
            }
            else if (button34.BackColor == Color.SkyBlue)
            {
                button34.BackColor = Color.PaleGreen;
                seats[33] = 0;
                Form1.brMjesta--;
            }
            else if (button34.BackColor == Color.LightCoral)
            {
                button34.BackColor = Color.PaleGreen;
                seats[33] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.PaleGreen)
            {
                button35.BackColor = Color.SkyBlue;
                seats[34] = 1;
                Form1.brMjesta++;
            }
            else if (button35.BackColor == Color.SkyBlue)
            {
                button35.BackColor = Color.PaleGreen;
                seats[34] = 0;
                Form1.brMjesta--;
            }
            else if (button35.BackColor == Color.LightCoral)
            {
                button35.BackColor = Color.PaleGreen;
                seats[34] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == Color.PaleGreen)
            {
                button36.BackColor = Color.SkyBlue;
                seats[35] = 1;
                Form1.brMjesta++;
            }
            else if (button36.BackColor == Color.SkyBlue)
            {
                button36.BackColor = Color.PaleGreen;
                seats[35] = 0;
                Form1.brMjesta--;
            }
            else if (button36.BackColor == Color.LightCoral)
            {
                button36.BackColor = Color.PaleGreen;
                seats[35] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.PaleGreen)
            {
                button37.BackColor = Color.SkyBlue;
                seats[36] = 1;
                Form1.brMjesta++;
            }
            else if (button37.BackColor == Color.SkyBlue)
            {
                button37.BackColor = Color.PaleGreen;
                seats[36] = 0;
                Form1.brMjesta--;
            }
            else if (button37.BackColor == Color.LightCoral)
            {
                button37.BackColor = Color.PaleGreen;
                seats[36] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.BackColor == Color.PaleGreen)
            {
                button38.BackColor = Color.SkyBlue;
                seats[37] = 1;
                Form1.brMjesta++;
            }
            else if (button38.BackColor == Color.SkyBlue)
            {
                button38.BackColor = Color.PaleGreen;
                seats[37] = 0;
                Form1.brMjesta--;
            }
            else if (button38.BackColor == Color.LightCoral)
            {
                button38.BackColor = Color.PaleGreen;
                seats[37] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.PaleGreen)
            {
                button39.BackColor = Color.SkyBlue;
                seats[38] = 1;
                Form1.brMjesta++;
            }
            else if (button39.BackColor == Color.SkyBlue)
            {
                button39.BackColor = Color.PaleGreen;
                seats[38] = 0;
                Form1.brMjesta--;
            }
            else if (button39.BackColor == Color.LightCoral)
            {
                button39.BackColor = Color.PaleGreen;
                seats[38] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.PaleGreen)
            {
                button40.BackColor = Color.SkyBlue;
                seats[39] = 1;
                Form1.brMjesta++;
            }
            else if (button40.BackColor == Color.SkyBlue)
            {
                button40.BackColor = Color.PaleGreen;
                seats[38] = 0;
                Form1.brMjesta--;
            }
            else if (button40.BackColor == Color.LightCoral)
            {
                button40.BackColor = Color.PaleGreen;
                seats[39] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.PaleGreen)
            {
                button41.BackColor = Color.SkyBlue;
                seats[40] = 1;
                Form1.brMjesta++;
            }
            else if (button41.BackColor == Color.SkyBlue)
            {
                button41.BackColor = Color.PaleGreen;
                seats[40] = 0;
                Form1.brMjesta--;
            }
            else if (button41.BackColor == Color.LightCoral)
            {
                button41.BackColor = Color.PaleGreen;
                seats[40] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.BackColor == Color.PaleGreen)
            {
                button42.BackColor = Color.SkyBlue;
                seats[41] = 1;
                Form1.brMjesta++;
            }
            else if (button42.BackColor == Color.SkyBlue)
            {
                button42.BackColor = Color.PaleGreen;
                seats[41] = 0;
                Form1.brMjesta--;
            }
            else if (button42.BackColor == Color.LightCoral)
            {
                button42.BackColor = Color.PaleGreen;
                seats[41] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor == Color.PaleGreen)
            {
                button43.BackColor = Color.SkyBlue;
                seats[42] = 1;
                Form1.brMjesta++;
            }
            else if (button43.BackColor == Color.SkyBlue)
            {
                button43.BackColor = Color.PaleGreen;
                seats[42] = 0;
                Form1.brMjesta--;
            }
            else if (button43.BackColor == Color.LightCoral)
            {
                button43.BackColor = Color.PaleGreen;
                seats[42] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.BackColor == Color.PaleGreen)
            {
                button44.BackColor = Color.SkyBlue;
                seats[43] = 1;
                Form1.brMjesta++;
            }
            else if (button44.BackColor == Color.SkyBlue)
            {
                button44.BackColor = Color.PaleGreen;
                seats[43] = 0;
                Form1.brMjesta--;
            }
            else if (button44.BackColor == Color.LightCoral)
            {
                button44.BackColor = Color.PaleGreen;
                seats[43] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.PaleGreen)
            {
                button45.BackColor = Color.SkyBlue;
                seats[44] = 1;
                Form1.brMjesta++;
            }
            else if (button45.BackColor == Color.SkyBlue)
            {
                button45.BackColor = Color.PaleGreen;
                seats[44] = 0;
                Form1.brMjesta--;
            }
            else if (button45.BackColor == Color.LightCoral)
            {
                button45.BackColor = Color.PaleGreen;
                seats[44] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.BackColor == Color.PaleGreen)
            {
                button46.BackColor = Color.SkyBlue;
                seats[45] = 1;
                Form1.brMjesta++;
            }
            else if (button46.BackColor == Color.SkyBlue)
            {
                button46.BackColor = Color.PaleGreen;
                seats[45] = 0;
                Form1.brMjesta--;
            }
            else if (button46.BackColor == Color.LightCoral)
            {
                button46.BackColor = Color.PaleGreen;
                seats[45] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor == Color.PaleGreen)
            {
                button47.BackColor = Color.SkyBlue;
                seats[46] = 1;
                Form1.brMjesta++;
            }
            else if (button47.BackColor == Color.SkyBlue)
            {
                button47.BackColor = Color.PaleGreen;
                seats[46] = 0;
                Form1.brMjesta--;
            }
            else if (button47.BackColor == Color.LightCoral)
            {
                button47.BackColor = Color.PaleGreen;
                seats[46] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button48.BackColor == Color.PaleGreen)
            {
                button48.BackColor = Color.SkyBlue;
                seats[47] = 1;
                Form1.brMjesta++;
            }
            else if (button48.BackColor == Color.SkyBlue)
            {
                button48.BackColor = Color.PaleGreen;
                seats[47] = 0;
                Form1.brMjesta--;
            }
            else if (button48.BackColor == Color.LightCoral)
            {
                button48.BackColor = Color.PaleGreen;
                seats[47] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button49.BackColor == Color.PaleGreen)
            {
                button49.BackColor = Color.SkyBlue;
                seats[48] = 1;
                Form1.brMjesta++;
            }
            else if (button49.BackColor == Color.SkyBlue)
            {
                button49.BackColor = Color.PaleGreen;
                seats[48] = 0;
                Form1.brMjesta--;
            }
            else if (button49.BackColor == Color.LightCoral)
            {
                button49.BackColor = Color.PaleGreen;
                seats[48] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (button50.BackColor == Color.PaleGreen)
            {
                button50.BackColor = Color.SkyBlue;
                seats[49] = 1;
                Form1.brMjesta++;
            }
            else if (button50.BackColor == Color.SkyBlue)
            {
                button50.BackColor = Color.PaleGreen;
                seats[49] = 0;
                Form1.brMjesta--;
            }
            else if (button50.BackColor == Color.LightCoral)
            {
                button50.BackColor = Color.PaleGreen;
                seats[49] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (button51.BackColor == Color.PaleGreen)
            {
                button51.BackColor = Color.SkyBlue;
                seats[50] = 1;
                Form1.brMjesta++;
            }
            else if (button51.BackColor == Color.SkyBlue)
            {
                button51.BackColor = Color.PaleGreen;
                seats[50] = 0;
                Form1.brMjesta--;
            }
            else if (button51.BackColor == Color.LightCoral)
            {
                button51.BackColor = Color.PaleGreen;
                seats[50] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (button52.BackColor == Color.PaleGreen)
            {
                button52.BackColor = Color.SkyBlue;
                seats[51] = 1;
                Form1.brMjesta++;
            }
            else if (button52.BackColor == Color.SkyBlue)
            {
                button52.BackColor = Color.PaleGreen;
                seats[51] = 0;
                Form1.brMjesta--;
            }
            else if (button52.BackColor == Color.LightCoral)
            {
                button52.BackColor = Color.PaleGreen;
                seats[51] = 0;
                //Form1.brMjesta--;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (button53.BackColor == Color.PaleGreen)
            {
                button53.BackColor = Color.SkyBlue;
                seats[52] = 1;
                Form1.brMjesta++;
            }
            else if (button53.BackColor == Color.SkyBlue)
            {
                button53.BackColor = Color.PaleGreen;
                seats[52] = 0;
                Form1.brMjesta--;
            }
            else if (button53.BackColor == Color.LightCoral)
            {
                button53.BackColor = Color.PaleGreen;
                seats[52] = 0;
                //Form1.brMjesta--;
            }
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

        private void button64_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projekcije f2 = new Projekcije();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }
    }
}
