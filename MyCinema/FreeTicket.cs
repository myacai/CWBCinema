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

        //�����Ʊ�ߵ�����
        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        //ʵ�ּ̳��鷽��
        public override void CalcPrice()
        {
            base.Price = 0;
        }

        //ʵ�ֽӿڵķ���
        public override void Print()
        {
            string fileName = base.ScheduleItems.Time + " " + base.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("************************************");
            sw.WriteLine("      ӰԺ ����Ʊ��");
            sw.WriteLine("------------------------------------");
            sw.WriteLine(" ��Ӱ���� \t{0}", base.ScheduleItems.Movie.MovieName);
            sw.WriteLine(" ʱ�䣺 \t{0}", base.ScheduleItems.Time);
            sw.WriteLine(" ��λ�ţ� \t{0}", base.Seat.SeatNum);
            sw.WriteLine(" �۸� \t{0}", base.Price.ToString());
            sw.WriteLine("************************************");
            sw.Close();
            fs.Close();
        }
    }
}
