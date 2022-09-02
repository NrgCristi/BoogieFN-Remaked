using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BoogieFN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "//FortniteGame//Binaries//Win64//FortniteClient-Win64-Shipping.exe");
            string FNExeName = "FortniteClient-Win64-Shipping.exe";
            string LaunchArgs = "-AUTH_LOGIN=, -AUTH_PASSWORD= -AUTH_TYPE=epic -noeac -fromfl=be -fltoken=h1h4370717422124b232eFac -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
            System.Diagnostics.Process.Start("FNExePath, FNExeName, LaunchArgs");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/sQTxyUqdCa");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
