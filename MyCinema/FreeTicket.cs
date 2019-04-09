using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyCinema
{
    [Serializable]
    public class FreeTicket : Ticket,IPrintable
    {
        public FreeTicket() { }

        public FreeTicket(ScheduleItem scheduleItems, Seat seat, string customerName)
            : base(scheduleItems, seat)
        {
            this.CustomerName = customerName;
        }

        //获得赠票者的名字
        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        //实现继承虚方法
        public override void CalcPrice()
        {
            base.Price = 0;
        }

        //实现接口的方法
        public override void Print()
        {
            string fileName = base.ScheduleItems.Time + " " + base.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("************************************");
            sw.WriteLine("      影院 （赠票）");
            sw.WriteLine("------------------------------------");
            sw.WriteLine(" 电影名： \t{0}", base.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" 时间： \t{0}", base.ScheduleItems.Time);
            sw.WriteLine(" 座位号： \t{0}", base.Seat.SeatNum);
            sw.WriteLine(" 价格： \t{0}", base.Price.ToString());
            sw.WriteLine("************************************");
            sw.Close();
            fs.Close();
        }
    }
}
