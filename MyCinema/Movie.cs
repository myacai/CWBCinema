using System;
using System.Collections.Generic;
using System.Text;

namespace MyCinema
{
    //�����Ӱ���ͣ�ö�٣�
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

        //������
        private string actor;
        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        //������
        private string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        //��Ӱ��
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        //��Ӱ����
        private MovieType movieType;
        public MovieType MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }

        //����ͼƬ��
        private string poster;
        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }

        //����
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
