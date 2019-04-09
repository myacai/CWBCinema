using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyCinema
{
    [Serializable]
    public class StudentTicket : Ticket,IPrintable
    {
        public StudentTicket() { }

        public StudentTicket(ScheduleItem scheduleItems, Seat seat, int discount)
            : base(scheduleItems, seat)
        {
            this.Discount = discount;
        }

        //指定学生票的折扣价
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        //实现继承虚方法
        public override void CalcPrice()
        {
            base.Price = (base.ScheduleItems.Movie.Price * this.Discount) / 10;
        }

        //实现接口的方法
        public override void Print()
        {
            string fileName = base.ScheduleItems.Time + " " + base.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("**********************************");
            sw.WriteLine("      影院 （学生）");
            sw.WriteLine("----------------------------------");
            sw.WriteLine(" 电影名： \t{0}", base.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" 时间： \t{0}", base.ScheduleItems.Time);
            sw.WriteLine(" 座位号： \t{0}", base.Seat.SeatNum);
            sw.WriteLine(" 价格： \t{0}", base.Price.ToString());
            sw.WriteLine("**********************************");
            sw.Close();
            fs.Close();
        }
    }
}
