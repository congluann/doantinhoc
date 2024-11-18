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
    public partial class hengio2 : Form
    {
        public hengio2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        hengio a = new hengio();
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (hengio.second <= 0)
            {
                hengio.second = 59;

                if (hengio.minute <= 0)
                {
                    hengio.minute = 59;
                    hengio.hour--;
                    if (hengio.hour < 0)
                    {
                        timer1.Stop();
                        label1.Text = "00";
                        label2.Text = "00";
                        label3.Text = "00";
                        MessageBox.Show("Hú hú hết giờ rồi nè ");
                        System.Media.SystemSounds.Beep.Play();

                        return;
                    }
                }
                else
                {
                    hengio.minute--;
                }
            }
            else
            {
                hengio.second--;
            }
            label1.Text = hengio.hour < 10 ? "0" + hengio.hour.ToString() : hengio.hour.ToString();
            label2.Text = hengio.minute < 10 ? "0" + hengio.minute.ToString() : hengio.minute.ToString();
            label3.Text = hengio.second < 10 ? "0" + hengio.second.ToString() : hengio.second.ToString();
            

        }

        private void tong_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e) 
        {
        
            
            timer1.Start();
        }

        private void hengio2_Load(object sender, EventArgs e)
        {
            tong.Text = "Tổng: " + hengio.hour + " giờ " + hengio.minute + " phút " + hengio.second + " giây";
        }
    }
}
