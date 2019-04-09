using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyCinema
{
    [Serializable]
    public class Ticket : IPrintable
    {
        public Ticket() { }

        public Ticket(ScheduleItem scheduleItems, Seat seat)
        {
            this.ScheduleItems = scheduleItems;
            this.Seat = seat;
        }

        //放映场次
        private ScheduleItem scheduleItems;
        public ScheduleItem ScheduleItems
        {
            get { return scheduleItems; }
            set { scheduleItems = value; }
        }

        //所属座位对象
        private Seat seat;
        internal Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        //票价
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        //计算票价的虚方法
        public virtual void CalcPrice()
        {
            this.price = this.ScheduleItems.Movie.Price;
        }

        //实现接口的打印方法
        public virtual void Print()
        {
            string fileName = this.ScheduleItems.Time + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("********************************");
            sw.WriteLine("       影院");
            sw.WriteLine("--------------------------------");
            sw.WriteLine(" 电影名： \t{0}", this.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" 时间： \t{0}", this.ScheduleItems.Time);
            sw.WriteLine(" 座位号： \t{0}", this.Seat.SeatNum);
            sw.WriteLine(" 价格： \t{0}", this.price.ToString());
            sw.WriteLine("********************************");
            sw.Close();
            fs.Close();
        }
    }
}
