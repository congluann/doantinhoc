using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doantinhocreal
{
    public class hengio
    {

        private int gio;
        private int phut;
        private int giay;
         
        public int Gio { get => gio; set => gio = value; }
        public int Phut { get => phut; set => phut = value; }
        public  int  Giay { get => giay; set => giay = value; }

        public hengio()
        {
            gio = 0;
            phut = 0;
            giay = 0;
          }

        public static int hour=0;
        public static int minute=0;
        public static int second=0;
        public static int baothucphut=0;
        public static int baothucgio = 0;
        public void TangGio() => Gio = (Gio + 1) % 24;
        public void GiamGio() => Gio = (Gio - 1 + 24) % 24;
        public void TangPhut() => Phut = (Phut + 1) % 60;
        public void GiamPhut() => Phut = (Phut - 1 + 60) % 60;
        public void TangGiay() => Giay = (Giay + 1) % 60;
        public void GiamGiay() => Giay = (Giay - 1 + 60) % 60;
    }

    public class AlarmTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public DateTime GetAlarmDateTime()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Hour, Minute, 0);
        }
    }
}
