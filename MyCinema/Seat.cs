using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MyCinema
{
    [Serializable]
    public class Seat
    {
        public Seat(string seatNum, Color color)
        {
            this.Color = color;
            this.SeatNum = seatNum;
        }

        
        private Color color;//×ùÎ»Âô³ö×´Ì¬ÑÕÉ«
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        
        private string seatNum;//×ùÎ»ºÅ
        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
    }
}
