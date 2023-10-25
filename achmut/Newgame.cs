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
    public partial class Newgame : Form
    {
        public Newgame()
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ted = DateTime.Now;
            string uzjmeno = textBox1.Text;
            StreamWriter Writer = new StreamWriter("hra.txt", false);
            string final = ted.ToString() + " - " + uzjmeno;
            Writer.Write(ted);
            Writer.Close();
            MessageBox.Show("jméno zapsáno, tento formulář se teď vypne");
            this.Close();
        }
    }
}
