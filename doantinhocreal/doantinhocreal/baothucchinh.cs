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
    public partial class baothucchinh : UserControl
    {
        public baothucchinh()
        {
            InitializeComponent();
        
        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newAlarm = new thebaothucUserControl();
            newAlarm.RemoveRequested += RemoveAlarm; 
            flowLayoutPanel.Controls.Add(newAlarm);
        }
        private void RemoveAlarm(object sender, EventArgs e)
        {
            if (sender is thebaothucUserControl alarmControl)
            {
                flowLayoutPanel.Controls.Remove(alarmControl);
                alarmControl.Dispose();
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel.Controls.OfType<thebaothucUserControl>().ToList())
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void baothucchinh_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
           
        }
    }
}
