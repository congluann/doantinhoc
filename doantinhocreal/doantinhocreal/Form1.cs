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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            DongHoUserConTrol a= new DongHoUserConTrol();
            this.panel1.Controls.Add(a);
        }

        private void hẹnGiờToolStripMenuItem_Click(object sender, EventArgs e)
        {   this.panel1.Controls.Clear();
            HenGioControl1 a= new HenGioControl1();
            a.Size=panel1.Size;
            this.panel1.Controls.Add(a);
        }

        private void đếmGiờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            bamgio a= new bamgio();
            a.Size = panel1.Size;
            this.panel1.Controls.Add(a);
        }

        private void đồngHồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
           baothucchinh a= new baothucchinh();
            a.Size=panel1.Size;
            this.panel1.Controls.Add(a);
        }


        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            thebaothucUserControl a = new thebaothucUserControl();
            a.Size = panel1.Size;
            this.panel1.Controls.Add(a);
        }
    }
}
