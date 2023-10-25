using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achmut
{
    public partial class setting : Form
    {

        string barva = "";
        string fontName = "";
        float fontSize = 0;
        public setting()
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
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color barva2 = colorDialog1.Color;
                barva = barva2.Name;
            }
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font font2 = fontDialog1.Font;
                fontName = font2.Name;
                fontSize = font2.Size;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter setting = new StreamWriter("setting.txt", true);
            bool YesNo = false;
            if (checkBox1.Checked) { YesNo = true; }
            setting.WriteLine(YesNo + "," + barva + "," + fontName + "," + fontSize);
            setting.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
