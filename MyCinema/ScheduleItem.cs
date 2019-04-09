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

        //本场所放映电影
        private Movie movie;
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        //放映时间
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
