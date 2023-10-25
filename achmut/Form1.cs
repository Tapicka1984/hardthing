namespace achmut
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Newgame form = new Newgame();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting settings = new setting();
            settings.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            closing close = new closing();
            close.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader ech = new StreamReader("hra.txt");
            string ehm = "";
            do
            {
                ehm = ech.ReadLine();
                Nacteni nacteni = new Nacteni(ehm);
                nacteni.Show();
            } while (ehm != textBox1.Text);
        }
    }
}