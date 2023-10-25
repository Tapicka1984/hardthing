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
    public partial class closing : Form
    {
        public closing()
        {
            InitializeComponent();
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

        bool ano = false;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (ano == false)
            {
                int delka = this.Size.Width;
                int vyska = this.Size.Height;
                Random rng = new Random();
                delka = (int)rng.Next(0, delka);
                vyska = (int)rng.Next(0, vyska);
                button1.Location = new Point(delka, vyska);
                ano = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
