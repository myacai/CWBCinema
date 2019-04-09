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

        //��ӳ�ƻ�
        private Schedule schedule;
        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        //��λ����
        private Dictionary<string, Seat> seats;
        public Dictionary<string, Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        //���۳���ӰƱ�ļ���
        private List<Ticket> soldTickets;
        public List<Ticket> SoldTickets
        {
            get { return soldTickets; }
            set { soldTickets = value; }
        }

        //���л�������Ʊ��Ϣ
        public void Save()
        {
            //�����ļ���
            FileStream fs = new FileStream("SoldTickets.bin", FileMode.Create);

            //�����Ƹ�ʽ��
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.SoldTickets);
            fs.Close();
        }

        //�����л���ȡ��Ʊ��Ϣ������Ʊ
        public void Load()
        {
            //�����ļ���
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
