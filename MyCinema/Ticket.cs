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

        //��ӳ����
        private ScheduleItem scheduleItems;
        public ScheduleItem ScheduleItems
        {
            get { return scheduleItems; }
            set { scheduleItems = value; }
        }

        //������λ����
        private Seat seat;
        internal Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        //Ʊ��
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        //����Ʊ�۵��鷽��
        public virtual void CalcPrice()
        {
            this.price = this.ScheduleItems.Movie.Price;
        }

        //ʵ�ֽӿڵĴ�ӡ����
        public virtual void Print()
        {
            string fileName = this.ScheduleItems.Time + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("********************************");
            sw.WriteLine("       ӰԺ");
            sw.WriteLine("--------------------------------");
            sw.WriteLine(" ��Ӱ���� \t{0}", this.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" ʱ�䣺 \t{0}", this.ScheduleItems.Time);
            sw.WriteLine(" ��λ�ţ� \t{0}", this.Seat.SeatNum);
            sw.WriteLine(" �۸� \t{0}", this.price.ToString());
            sw.WriteLine("********************************");
            sw.Close();
            fs.Close();
        }
    }
}
