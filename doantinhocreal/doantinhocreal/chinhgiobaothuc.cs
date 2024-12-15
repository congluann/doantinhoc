using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantinhocreal
{
    public partial class chinhgiobaothuc : Form
    {
        public chinhgiobaothuc()
        {
            InitializeComponent();
        }

        
        hengio a = new hengio();
       
        private void button1_Click(object sender, EventArgs e)
        {
            a.TangGio();
            label1.Text = a.Gio.ToString("D2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.TangPhut();
            label2.Text = a.Phut.ToString("D2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.GiamGio();
            label1.Text = a.Gio.ToString("D2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.GiamPhut();
            label2.Text = a.Phut.ToString("D2");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            hengio.baothucgio=a.Gio;
            hengio.baothucphut = a.Phut;
            this.Close();
          
        }

        private void chinhgiobaothuc_closing(object sender, FormClosingEventArgs e)
        {
            label1.Text = hengio.baothucgio.ToString("D2");
            label2.Text = hengio.baothucphut.ToString("D2");
        }

        private void chinhgiobaothuc_Load(object sender, EventArgs e)
        {

        }
    }
}
