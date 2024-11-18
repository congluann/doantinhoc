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
    public partial class thebaothucUserControl : UserControl
    {
        private DateTime now;
        private hengio alarmTime = new hengio();
        private bool alarmTriggered = false; 

        public thebaothucUserControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.LightGreen;
                checkBox1.Text = "Tắt Báo Thức";
                timer1.Start();
            }
            else
            {
                checkBox1.BackColor = Color.LightGray;
                checkBox1.Text = "Bật Báo Thức";
            }
        }

        private void btnbutton(object sender, EventArgs e)
        {
            chinhgiobaothuc a = new chinhgiobaothuc();
            a.FormClosed += (s, args) =>
            {
                label1.Text = hengio.baothucgio.ToString("D2");
                label2.Text = hengio.baothucphut.ToString("D2");
            };
            a.Show();
        }

        private void thebaothucUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = hengio.baothucgio.ToString("D2");
            label2.Text = hengio.baothucphut.ToString("D2");

            timer1.Interval = 1000; 
            timer1.Tick += AlarmTimer_Tick;
          timer1.Start();
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (alarmTriggered)  
            {
                return;  
            }
            now = DateTime.Now;  
            int gio = int.Parse(label1.Text);
            int phut = int.Parse(label2.Text);

            
            if (gio == now.Hour && phut == now.Minute)
            {
                if (!alarmTriggered)  
                {
                    MessageBox.Show("Hú hú, tới giờ rồi nề!!!!!!!");
                    alarmTriggered = true;
                    timer1.Stop();
                    timer1.Dispose();
                    
                   
                }

              
               
            }
        }
    }


}
