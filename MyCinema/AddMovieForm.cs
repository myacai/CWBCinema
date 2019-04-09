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

        //�˳�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //���ӰƬ��Ϣ
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            //��ȡִ�е�ǰ���̵�·��
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //ӰƬ��ϸ��Ϣ
            string name = this.txtMovieName.Text.Trim();
            string picName = this.txtPicMovieName.Text.Trim();
            string director = this.txtDirector.Text.Trim();
            string actor = this.txtActor.Text.Trim();
            string movieType = this.cboMovieType.Text;
            string price = this.txtMoviePrice.Text.Trim();
            string timer1 = this.mTxtDateTime1.Text;
            string timer2 = this.mTxtDateTime2.Text;

            //��ȡͼƬ��·��
            int index = picName.LastIndexOf("\\") + 1;

            if (InitShowVidate())
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load(path + "ShowList.xml");

                //���� ShowList �ڵ�
                XmlNode root = myXml.SelectSingleNode("ShowList");
                //����һ��Movie�ڵ�
                XmlElement xel = myXml.CreateElement("Movie");

                XmlElement xesub1 = myXml.CreateElement("Name");
                xesub1.InnerText = name;
                //��ӵ� Movie �ڵ���
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

                //���ʱ���
                XmlElement xel1 = myXml.CreateElement("Schedule");

                XmlElement xesub7 = myXml.CreateElement("Item");
                xesub7.InnerText = timer1;
                xel1.AppendChild(xesub7);

                XmlElement xesub8 = myXml.CreateElement("Item");
                xesub8.InnerText = timer2;
                xel1.AppendChild(xesub8);

                //��ӵ� ShowList �ڵ���
                xel.AppendChild(xel1);
                root.AppendChild(xel);
                myXml.Save(path + "ShowList.xml");

                if (!File.Exists(path + picName.Substring(index)))
                {
                    File.Copy(txtPicMovieName.Text, path + picName.Substring(index));
                }

                MessageBox.Show("��ӳɹ���");
                this.Hide();
            }
        }

        //��Ч����֤
        private bool InitShowVidate()
        {
            string message = null;
            if (txtMovieName.Text.Trim() == "")
            {
                message = "ӰƬ������Ϊ�գ�";
                ShowMessage(message);
                txtMovieName.Focus();
                return false;
            }
            else if (txtPicMovieName.Text.Trim() == "")
            {
                message = "ͼƬ������Ϊ�գ�";
                ShowMessage(message);
                txtPicMovieName.Focus();
                return false;
            }
            else if (txtDirector.Text.Trim() == "")
            {
                message="���ݲ���Ϊ�գ�";
                ShowMessage(message);
                txtDirector.Focus();
                return false;
            }
            else if (txtActor.Text.Trim() == "")
            {
                message="���ݲ���Ϊ�գ�";
                ShowMessage(message);
                txtActor.Focus();
                return false;
            }
            else if (cboMovieType.Text == "")
            {
                message="���Ͳ���Ϊ�գ�";
                ShowMessage(message);
                cboMovieType.Focus();
                return false;
            }
            else if (txtMoviePrice.Text.Trim() == "")
            {
                message="�۸���Ϊ�գ�";
                ShowMessage(message);
                txtMoviePrice.Focus();
                return false;
            }
            else if (mTxtDateTime1.Text.Equals("  -     -"))
            {
                message="ʱ���1����Ϊ�գ�";
                ShowMessage(message);
                mTxtDateTime1.Focus();
                return false;
            }
            else if (mTxtDateTime2.Text.Equals("  -     -"))
            {
                message="ʱ���2����Ϊ�գ�";
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
            MessageBox.Show(message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //���ͼƬ
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //��ȡ�������ļ��Ի�����ʾ�ĳ�ʼĿ¼
            openFileDialog1.InitialDirectory = "D:\\";

            //��ȡ������ָʾ�Ի����ڹر�ǰ�Ƿ�ԭ��ǰĿ¼
            openFileDialog1.RestoreDirectory = false;

            //�޶��ɼ����ļ�
            openFileDialog1.Filter = "GIF files(*.gif)|*.gif|JPG files(*.jpg)|*.jpg|ICO files(*.ico)|*.ico|All files(*.*)|*.*";

            //�����򿪰�ť
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPicMovieName.Text = openFileDialog1.FileName;
            }
        }

        //�۸����֤����
        private void txtMoviePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) || e.KeyChar != 13)
            //{
            //    MessageBox.Show("�۸�ֻ���������֣�");
            //    e.Handled = true;
            //}
        }

        private void txtMoviePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}