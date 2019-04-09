using System;
using System.Collections.Generic;
using System.Text;

namespace MyCinema
{
    //定义电影类型（枚举）
    public enum MovieType
    {
        Comedy,War,Romance,Action,Cartoon,Thriller
    }

    [Serializable]
    public class Movie
    {
        public Movie() { }

        public Movie(string actor, string director, string movieName, MovieType movieType, string poster, int price)
        {
            this.Actor = actor;
            this.Director = director;
            this.MovieName = movieName;
            this.MovieType = movieType;
            this.Poster = poster;
            this.Price = price;
        }

        //主演名
        private string actor;
        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        //导演名
        private string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        //电影名
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        //电影类型
        private MovieType movieType;
        public MovieType MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }

        //海报图片名
        private string poster;
        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }

        //定价
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
