using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achmut
{
    public partial class Nacteni : Form
    {
        string jmeno;
        public Nacteni(string ehm)
        {
            InitializeComponent();
            jmeno = ehm;
            label1.Text = jmeno;
            if (File.Exists("setting.txt"))
            {
                StreamReader readX = new StreamReader("setting.txt");
                string[] SETTINGPOLEMORE = readX.ReadLine().Split(',');
                Font novyfont = new Font(SETTINGPOLEMORE[2], int.Parse(SETTINGPOLEMORE[3]));
                this.Font = novyfont;
                Color barvicka;
                try
                {
                    barvicka = Color.FromName(SETTINGPOLEMORE[1]);
                }
                finally
                {
                    barvicka = Color.Red;
                }
                this.BackColor = barvicka;
                if (bool.Parse(SETTINGPOLEMORE[0]) == true)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                readX.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Nacteni_Load(object sender, EventArgs e)
        {

        }
    }
}
