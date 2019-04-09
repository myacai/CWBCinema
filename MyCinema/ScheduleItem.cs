using System;
using System.Collections.Generic;
using System.Text;

namespace MyCinema
{
    [Serializable]
    public class ScheduleItem
    {
        public ScheduleItem() 
        {
            this.Movie = new Movie();            
        }

        //��������ӳ��Ӱ
        private Movie movie;
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        //��ӳʱ��
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
