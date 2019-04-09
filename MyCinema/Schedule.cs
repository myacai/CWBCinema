using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MyCinema
{
    public class Schedule
    {
        public Schedule()
        {
            items = new Dictionary<string, ScheduleItem>();
        }

        //获取初始路径
        public string path = AppDomain.CurrentDomain.BaseDirectory;

        //放映场次
        private Dictionary<string, ScheduleItem> items;
        public Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        //读取XML文件获取放映计划集合方法
        public void LoadItem()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(path + "ShowList.xml");

            XmlNode film = myXml.DocumentElement;
            foreach (XmlNode node in film.ChildNodes)
            {
                if (node.Name == "Movie")
                {
                    Movie movie = new Movie();
                    foreach (XmlNode subNode in node.ChildNodes)
                    {
                        switch (subNode.Name)
                        {
                            case "Name":
                                movie.MovieName = subNode.InnerText;
                                break;
                            case "Poster":
                                movie.Poster = subNode.InnerText;
                                break;
                            case "Director":
                                movie.Director = subNode.InnerText;
                                break;
                            case "Actor":
                                movie.Actor = subNode.InnerText;
                                break;
                            case "Type":
                                movie.MovieType = (MovieType)(Enum.Parse(typeof(MovieType), subNode.InnerText));
                                break;
                            case "Price":
                                movie.Price = Convert.ToInt32(subNode.InnerText);
                                break;
                            case "Schedule":
                                foreach (XmlNode xd in subNode.ChildNodes)
                                {
                                    ScheduleItem item = new ScheduleItem();
                                    if (xd.Name == "Item")
                                    {
                                        item.Movie = movie;
                                        item.Time = xd.InnerText;
                                        this.items.Add(item.Time, item);
                                    }
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
