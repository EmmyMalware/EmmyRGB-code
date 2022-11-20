using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmmyRGB
{
    public partial class Class2 : Form
    {
        public Class2()
        {

            this.TransparencyKey = this.BackColor;
            this.TopMost = true;
        }

        Timer t;
        Random r;
        string[] msgs = { "Dumb dude", "Go to hell", "Huh", "im in your walls", "idk what to write now" };
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            t = new Timer();
            r = new Random();

            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int generateNumber = r.Next(10);
            t.Interval = r.Next(100, 2000);

            if (generateNumber == 6)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = this.TransparencyKey;
            }
            switch (generateNumber)
            {
                case 1:
                    MessageBox.Show(msgs[r.Next(msgs.Length)]);
                    break;
            }
        }
    }
}