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
    public partial class bamgio : UserControl
    {
        public bamgio()
        {
            InitializeComponent();
        }

        private void dongHoUserConTrol1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        donghomin a=new donghomin();
        private void timer1_Tick(object sender, EventArgs e)
            
        {
           
            a.Giay++;
            if (a.Giay < 10)
                label3.Text = "0" + a.Giay.ToString();
            else
            {
                label3.Text = a.Giay.ToString();
            }
            if (a.Giay >=60)
            {
                a.Giay = 0;
                a.Phut++;
                if (a.Phut < 10)
                    label2.Text = "0" + a.Phut.ToString();
                else
                {
                    label2.Text = a.Phut.ToString();
                }
                if (a.Phut >=60)
                {
                    a.Phut = 0;
                    a.Gio++;
                    if (a.Giay < 10)
                        label1.Text = "0" + a.Gio.ToString();
                    else
                    {
                        label1.Text = a.Gio.ToString();
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Gio = 0;
            a.Phut = 0;
            a.Giay = 0;
            label2.Text = "0" + a.Phut.ToString();
            label1.Text = "0" + a.Gio.ToString();
            label3.Text = "0" + a.Giay.ToString();
        }
    }
}
