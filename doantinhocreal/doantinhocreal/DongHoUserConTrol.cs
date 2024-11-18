using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace doantinhocreal
    {
    public partial class DongHoUserConTrol : UserControl
    {
        public DongHoUserConTrol()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.listBox.SelectedItem != null)
            {
                TimeZoneInfo timeZoneInfo = (TimeZoneInfo)this.listBox.SelectedItem;
                DateTime currentTimeInTimeZone = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
                this.label1.Text = currentTimeInTimeZone.ToString("HH:mm:ss");
                label3.Text = currentTimeInTimeZone.ToString("dd/MM/yyyy");
            }
        }
        private void BaoThucUserConTrol_Load(object sender, EventArgs e)
        {
            ReadOnlyCollection<TimeZoneInfo> collection = TimeZoneInfo.GetSystemTimeZones();
            this.listBox.Items.AddRange(collection.ToArray());
            var index = collection.ToList().FindIndex(x => x.Id.Equals("SE Asia Standard Time"));
            if (index >= 0)
            {
                this.listBox.SetSelected(index, true);  
            }
            timer1.Start();
        }

        
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }   
    }
}
