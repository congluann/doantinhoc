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
    public partial class HenGioControl1 : UserControl
    {
        public HenGioControl1()
        {
            InitializeComponent();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            a.GiamPhut();
            label2.Text = a.Phut.ToString("D2");
        }
        hengio a=new hengio();
        
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text= a.Gio.ToString(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text= a.Phut.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text= a.Giay.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.TangGio();
            label1.Text = a.Gio.ToString("D2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.GiamGio();
            label1.Text = a.Gio.ToString("D2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.TangPhut();
            label2.Text = a.Phut.ToString("D2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a.TangGiay();
            label3.Text = a.Giay.ToString(); 
     
   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a.GiamGiay();
            label3.Text = a.Giay.ToString();
        }
       
        private void btnstart_Click(object sender, EventArgs e)
        {
            hengio.hour = a.Gio;
            hengio.minute = a.Phut;
            hengio.second = a.Giay;


           hengio2 hg = new hengio2();
            hg.Show();
           
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(a.Giay <=0)
            {
                a.Giay = 59;
                a.Phut--;

                if(a.Phut<0)
                {
                    a.Phut = 59;
                    a.Gio--;
                    if (a.Gio< 10)

                    {
                        label1.Text = "0" + a.Gio.ToString();
                    }
                    else label1.Text=a.Gio.ToString(); 
                    
                }  
                else if(a.Phut <10)
                {
                    
                    label2.Text="0" + a.Phut.ToString();
                } 
                else if(a.Phut <60)
                {
                    label2.Text=a.Phut.ToString();
                }    
                
                
            }
            else if(a.Giay <10)
            {
                a.Giay--;
                label3.Text="0"+a.Giay.ToString();
            }   
            else if(a.Giay <60)
            {
                a.Giay--;
                label3.Text=a.Giay.ToString();
                             
            }             
        }

        private void btnreset_Click(object sender, EventArgs e)
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
