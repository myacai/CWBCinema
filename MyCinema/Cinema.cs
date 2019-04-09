using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyCinema
{
    [Serializable]
    public class Cinema
    {
        public Cinema()
        {
            Seats = new Dictionary<string, Seat>();
            SoldTickets = new List<Ticket>();
        }

        //放映计划
        private Schedule schedule;
        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        //座位集合
        private Dictionary<string, Seat> seats;
        public Dictionary<string, Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        //已售出电影票的集合
        private List<Ticket> soldTickets;
        public List<Ticket> SoldTickets
        {
            get { return soldTickets; }
            set { soldTickets = value; }
        }

        //序列化保存售票信息
        public void Save()
        {
            //定义文件流
            FileStream fs = new FileStream("SoldTickets.bin", FileMode.Create);

            //二进制格式化
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.SoldTickets);
            fs.Close();
        }

        //反序列化读取售票信息继续售票
        public void Load()
        {
            //定义文件流
            try
            {
                FileStream fs = new FileStream("SoldTickets.bin", FileMode.Open);

                BinaryFormatter bf = new BinaryFormatter();
                soldTickets = (List<Ticket>)bf.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
