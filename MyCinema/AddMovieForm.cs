using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MyCinema
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        //退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加影片信息
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            //获取执行当前工程的路径
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //影片详细信息
            string name = this.txtMovieName.Text.Trim();
            string picName = this.txtPicMovieName.Text.Trim();
            string director = this.txtDirector.Text.Trim();
            string actor = this.txtActor.Text.Trim();
            string movieType = this.cboMovieType.Text;
            string price = this.txtMoviePrice.Text.Trim();
            string timer1 = this.mTxtDateTime1.Text;
            string timer2 = this.mTxtDateTime2.Text;

            //获取图片的路径
            int index = picName.LastIndexOf("\\") + 1;

            if (InitShowVidate())
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load(path + "ShowList.xml");

                //查找 ShowList 节点
                XmlNode root = myXml.SelectSingleNode("ShowList");
                //创建一个Movie节点
                XmlElement xel = myXml.CreateElement("Movie");

                XmlElement xesub1 = myXml.CreateElement("Name");
                xesub1.InnerText = name;
                //添加到 Movie 节点中
                xel.AppendChild(xesub1);

                XmlElement xesub2 = myXml.CreateElement("Poster");
                xesub2.InnerText = picName.Substring(index);
                xel.AppendChild(xesub2);

                XmlElement xesub3 = myXml.CreateElement("Director");
                xesub3.InnerText = director;
                xel.AppendChild(xesub3);

                XmlElement xesub4 = myXml.CreateElement("Actor");
                xesub4.InnerText = actor;
                xel.AppendChild(xesub4);

                XmlElement xesub5 = myXml.CreateElement("Type");
                xesub5.InnerText = movieType;
                xel.AppendChild(xesub5);

                XmlElement xesub6 = myXml.CreateElement("Price");
                xesub6.InnerText = price;
                xel.AppendChild(xesub6);

                //添加时间段
                XmlElement xel1 = myXml.CreateElement("Schedule");

                XmlElement xesub7 = myXml.CreateElement("Item");
                xesub7.InnerText = timer1;
                xel1.AppendChild(xesub7);

                XmlElement xesub8 = myXml.CreateElement("Item");
                xesub8.InnerText = timer2;
                xel1.AppendChild(xesub8);

                //添加到 ShowList 节点中
                xel.AppendChild(xel1);
                root.AppendChild(xel);
                myXml.Save(path + "ShowList.xml");

                if (!File.Exists(path + picName.Substring(index)))
                {
                    File.Copy(txtPicMovieName.Text, path + picName.Substring(index));
                }

                MessageBox.Show("添加成功！");
                this.Hide();
            }
        }

        //有效性验证
        private bool InitShowVidate()
        {
            string message = null;
            if (txtMovieName.Text.Trim() == "")
            {
                message = "影片名不能为空！";
                ShowMessage(message);
                txtMovieName.Focus();
                return false;
            }
            else if (txtPicMovieName.Text.Trim() == "")
            {
                message = "图片名不能为空！";
                ShowMessage(message);
                txtPicMovieName.Focus();
                return false;
            }
            else if (txtDirector.Text.Trim() == "")
            {
                message="导演不能为空！";
                ShowMessage(message);
                txtDirector.Focus();
                return false;
            }
            else if (txtActor.Text.Trim() == "")
            {
                message="主演不能为空！";
                ShowMessage(message);
                txtActor.Focus();
                return false;
            }
            else if (cboMovieType.Text == "")
            {
                message="类型不能为空！";
                ShowMessage(message);
                cboMovieType.Focus();
                return false;
            }
            else if (txtMoviePrice.Text.Trim() == "")
            {
                message="价格不能为空！";
                ShowMessage(message);
                txtMoviePrice.Focus();
                return false;
            }
            else if (mTxtDateTime1.Text.Equals("  -     -"))
            {
                message="时间段1不能为空！";
                ShowMessage(message);
                mTxtDateTime1.Focus();
                return false;
            }
            else if (mTxtDateTime2.Text.Equals("  -     -"))
            {
                message="时间段2不能为空！";
                ShowMessage(message);
                mTxtDateTime2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //浏览图片
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //获取或设置文件对话框显示的初始目录
            openFileDialog1.InitialDirectory = "D:\\";

            //获取或设置指示对话框在关闭前是否还原当前目录
            openFileDialog1.RestoreDirectory = false;

            //限定可见的文件
            openFileDialog1.Filter = "GIF files(*.gif)|*.gif|JPG files(*.jpg)|*.jpg|ICO files(*.ico)|*.ico|All files(*.*)|*.*";

            //单击打开按钮
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPicMovieName.Text = openFileDialog1.FileName;
            }
        }

        //价格的验证输入
        private void txtMoviePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) || e.KeyChar != 13)
            //{
            //    MessageBox.Show("价格只能输入数字！");
            //    e.Handled = true;
            //}
        }

        private void txtMoviePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}