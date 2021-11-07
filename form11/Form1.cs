using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form11
{
    public partial class Form1 : Form
    {
        public int toplam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Button btn = new Button();
            Random rnd = new Random();
            int sayi = rnd.Next();
            btn.Location = new Point (rnd.Next(25,1000),rnd.Next(25,550));
            btn.Size = new Size(rnd.Next(25,100), rnd.Next(15,100));
            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            btn.Visible = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer3.Stop();
            label2.Text = Convert.ToString(toplam);
            label3.Text = "Süre Doldu";
        }
        int saniye = 0;
        DateTime dt = new DateTime();

    private void timer3_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = dt.AddSeconds(saniye).ToString("HH:mm");
            
        }
    }
}
