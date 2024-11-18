using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doantinhocreal
{
    public class donghomin
    {

        private int gio;
        private int phut;
        private int giay;

        public int Gio { get => gio; set => gio = value; }
        public int Phut { get => phut; set => phut = value; }
        public int Giay { get => giay; set => giay = value; }

        public donghomin()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }
    }
}
