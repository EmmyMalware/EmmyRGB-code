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
    public class Program
    {
     static void Main() {}
    }
    public partial class Class1 : Form
        {
            public Class1()
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Run Malware?", "EmmyRGB.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    MessageBox.Show("Are you sure?");
            }
        }
    }