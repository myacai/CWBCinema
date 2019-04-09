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

        //ָ��ѧ��Ʊ���ۿۼ�
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        //ʵ�ּ̳��鷽��
        public override void CalcPrice()
        {
            base.Price = (base.ScheduleItems.Movie.Price * this.Discount) / 10;
        }

        //ʵ�ֽӿڵķ���
        public override void Print()
        {
            string fileName = base.ScheduleItems.Time + " " + base.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("**********************************");
            sw.WriteLine("      ӰԺ ��ѧ����");
            sw.WriteLine("----------------------------------");
            sw.WriteLine(" ��Ӱ���� \t{0}", base.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" ʱ�䣺 \t{0}", base.ScheduleItems.Time);
            sw.WriteLine(" ��λ�ţ� \t{0}", base.Seat.SeatNum);
            sw.WriteLine(" �۸� \t{0}", base.Price.ToString());
            sw.WriteLine("**********************************");
            sw.Close();
            fs.Close();
        }
    }
}
