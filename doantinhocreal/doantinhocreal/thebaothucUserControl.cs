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
        public event EventHandler RemoveRequested;
        public thebaothucUserControl()
        {
            InitializeComponent();
            Button removeButton = new Button
            {
                Text = "Xóa",
                Dock = DockStyle.Right,
                Width = 50
            };
            removeButton.Click += (s, e) => RemoveRequested?.Invoke(this, EventArgs.Empty);
            this.Controls.Add(removeButton);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.LightGreen;
                timer1.Start();
                timer2.Start();
            }
            else
            {
                checkBox1.BackColor = Color.LightGray;
                timer1.Stop();
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
            if (checkBox1.Checked)
            {
                timer1.Stop();
                timer1.Start();
            }
            
            a.Show();
        }
        
        private void thebaothucUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = hengio.baothucgio.ToString("D2");
            label2.Text = hengio.baothucphut.ToString("D2");

            timer1.Interval = 1000; 
            timer1.Tick += AlarmTimer_Tick;
            timer2.Interval = 1000;
            timer2.Tick += AlarmTimer_Tick2;
            if (checkBox1.Checked)
            {
                timer1.Stop(); 
                timer1.Start();
            }
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
                    alarmTriggered = true;
                    MessageBox.Show("Hú hú, tới giờ rồi nề!!!!!!!");
                    timer1.Stop();
                    timer1.Start();
                }  
            }
        }
        private void AlarmTimer_Tick2(object sender, EventArgs e)
        {
            now = DateTime.Now;
            int gio = int.Parse(label1.Text)+1;
            int phut = int.Parse(label2.Text)+1;
            if (phut >= 60)
            {
                phut = 0;
                gio++;
            }
            if (gio >= 24)
            {
                gio = 0; 
            }
            if (gio == now.Hour && phut == now.Minute) 
            {
                timer1.Stop();
                timer1.Start();
            }
        }
    }


}
