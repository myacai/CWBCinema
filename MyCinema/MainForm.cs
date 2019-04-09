using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "MacOS.ssk";
        }

        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        Cinema cinema;
        string key = null;

        // ҳ�����ʱ����
        private void MainForm_Load(object sender, EventArgs e)
        {
            //����һ����ӰԺ
            cinema = new Cinema();

            //���ӰƬ������Ϣ
            this.lblName.Text = "";
            this.lblDirector.Text = "";
            this.lblActor.Text = "";
            this.lblMovieType.Text = "";
            this.lblTime.Text = "";
            this.lblPrice.Text = "";
            this.lblPreferentialPrice.Text = "";            

            this.rdoCommon.Checked = true;
            this.lblDisCount.Enabled = false;           
            this.lblPresent.Enabled = false;
            this.txtPresent.Enabled = false;
            this.cboStudentDiscount.Enabled = false;            

            //������Ӷ�̬��λ�ķ���
            InitSeats(7, 5, tbCinemas);
        }

        // ��ʼ�� TreeView �ؼ�
        public void InitTreeView()
        {
            //������ڵ�ļ���
            tvMyXml.Nodes.Clear();

            string movieName = null;
            TreeNode movieNode = null;
            foreach (ScheduleItem item in cinema.Schedule.Items.Values)
            {
                if (movieName != item.Movie.MovieName)
                {
                    movieNode = new TreeNode(item.Movie.MovieName);
                    tvMyXml.Nodes.Add(movieNode);
                }
                TreeNode timeNode = new TreeNode(item.Time);
                movieNode.Nodes.Add(timeNode);
                movieName = item.Movie.MovieName;
                timeNode.ImageIndex = 0;
            }
        }

        // ��Ӷ�̬������λ�ķ���
        private void InitSeats(int seatRow, int seatLine,TabPage tb)
        {
            Label label;
            Seat seat;
            for (int i = 0; i < seatRow; i++)
            {
                for (int j = 0; j < seatLine; j++)
                {
                    label = new Label();
                    label.BackColor = Color.Yellow;
                    label.AutoSize = false;
                    label.Font = new System.Drawing.Font("����", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    label.Location = new System.Drawing.Point(59, 60);
                    label.Name = "lbl" + (j + 1).ToString() + "_" + (i + 1).ToString();
                    label.Size = new System.Drawing.Size(50, 25);
                    //������λ��
                    label.Text = Convert.ToString((j + 1)) + "-" + Convert.ToString((i + 1));
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                    //���еı�ǩ���󶨵�ͬһ�¼�
                    label.Click += new System.EventHandler(lblSeat_Click);
                    tb.Controls.Add(label);
                    labels.Add(label.Text, label);

                    //ʵ����һ����λ
                    seat = new Seat(Convert.ToString((j + 1)) + "-" + Convert.ToString((i + 1)),Color.Yellow);

                    //�������λ����
                    cinema.Seats.Add(seat.SeatNum, seat);
                }
            }
        }

        // ����������ʱˢ�·�ӳ�б�
        private void tsmiNewVendition_Click(object sender, EventArgs e)
        {
            cinema.Schedule = new Schedule();
            cinema.Schedule.LoadItem();
            cinema.SoldTickets.Clear();
            InitTreeView();
        }

        // �����ڵ�ʱ����
        private void tvMyXml_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //��ȡ��ǰѡ�еĽڵ�
            TreeNode node = tvMyXml.SelectedNode;

            //�жϸýڵ��Ƿ�Ϊ��
            if (node == null)
            {
                return;
            }

            //�жϽڵ��Ƿ��Ƿ�ӳʱ��
            if (node.Level != 1)
            {
                return;
            }

            //��ȡ�ڵ����Ϣ
            key = tvMyXml.SelectedNode.Text;

            //��ʾ��ϸ��Ϣ
            this.lblName.Text = cinema.Schedule.Items[key].Movie.MovieName;
            this.lblDirector.Text = cinema.Schedule.Items[key].Movie.Director;
            this.lblActor.Text = cinema.Schedule.Items[key].Movie.Actor;
            this.lblMovieType.Text = cinema.Schedule.Items[key].Movie.MovieType.ToString();
            this.lblTime.Text = cinema.Schedule.Items[key].Time;
            this.lblPrice.Text = cinema.Schedule.Items[key].Movie.Price.ToString();
            this.picTitle.Image = Image.FromFile(cinema.Schedule.Items[key].Movie.Poster);
            this.lblPreferentialPrice.Text = "";

            //��պ͸�����λ��Ϣ
            ClearSeat(key);
        }

        //������λ״̬
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }

        //�˳�
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ȷ��Ҫ�˳���", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //��ѡ��ťѡ���¼�
        private void rdoLargess_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCommon.Checked == true)
            {
                this.lblDisCount.Enabled = false;
                this.lblPresent.Enabled = false;
                this.cboStudentDiscount.Enabled = false;
                this.txtPresent.Enabled = false;
                this.cboStudentDiscount.SelectedIndex = -1;
            }
            else if (rdoLargess.Checked == true)
            {
                this.lblDisCount.Enabled = false;
                this.cboStudentDiscount.Enabled = false;
                this.txtPresent.Enabled = true;
                this.lblPresent.Enabled = true;
                this.cboStudentDiscount.SelectedIndex = -1;
            }
            else if (rdoStudent.Checked == true)
            {
                this.lblPresent.Enabled = false;
                this.txtPresent.Enabled = false;
                this.lblDisCount.Enabled = true;
                this.cboStudentDiscount.Enabled = true;
                this.cboStudentDiscount.SelectedIndex = 0;
            }
        }

        //����һ����λ�������ӰƱ
        private void lblSeat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lblName.Text))
            {
                MessageBox.Show("����û��ѡ���Ӱ��");
                return;
            }

            //��ѡ���senderת��Ϊ��ǩ,��ȡ�ñ�ǩ��Text,��ȡ��λ��
            string seatNum = ((Label)sender).Text.ToString();
            key = tvMyXml.SelectedNode.Text;
            string customer = null;
            int discount = 0;
            string type = null;
            if (cinema.Seats[seatNum].Color == Color.Red)
            {
                MessageBox.Show("�Բ��𣬴�Ʊ���۳���");
                return;
            }
            if (rdoCommon.Checked == true)
            {
                type = "��ͨƱ";
            }
            if (rdoLargess.Checked == true)
            {
                if (this.txtPresent.Text.Trim() == "")
                {
                    MessageBox.Show("��������Ʊ��������");
                    txtPresent.Focus();
                    return;
                }
                type = "��Ʊ";
                customer = txtPresent.Text;
            }
            if (rdoStudent.Checked == true)
            {
                type = "ѧ��Ʊ";
                discount = Convert.ToInt32(this.cboStudentDiscount.Text);
            }
            try
            {
                //���ü򵥹���ģʽ��������ͬ���͵ĵ�ӰƱ
                Ticket ticket = TicketFactory.CreateTicket(cinema.Schedule.Items[key], cinema.Seats[seatNum], customer, discount, type);
                DialogResult result = MessageBox.Show("�Ƿ���", "ѯ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //�������õ�Ʊ��ӵ����۳�Ʊ�ļ�����
                    cinema.SoldTickets.Add(ticket);

                    //�����Żݼ۸�
                    ticket.CalcPrice();

                    //��ʾ���Żݼ۱�ǩ
                    this.lblPreferentialPrice.Text = ticket.Price.ToString();
                    this.lblPreferentialPrice.ForeColor = System.Drawing.Color.Red;

                    //���ô�ӡ���� 
                    ticket.Print();

                    //��պ͸�����λ��Ϣ
                    ClearSeat(key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("����ʧ�ܣ�" + ex.Message.ToString());
            }
        }

        //�����λ
        private void ClearSeat(string key)
        {
            foreach (Seat seat in cinema.Seats.Values)
            {
                seat.Color = Color.Yellow;
            }

            //�����ó���Ӱ����λ�������
            foreach (Ticket ticket in cinema.SoldTickets)
            {
                foreach (Seat seat in cinema.Seats.Values)
                {
                    if ((ticket.ScheduleItems.Time == key) && (ticket.Seat.SeatNum == seat.SeatNum))
                    {
                        seat.Color = Color.Red;
                    }
                }
            }

            //������λ״̬
            UpdateSeat();
        }

        //��������
        private void tsmiContinueCinema_Click(object sender, EventArgs e)
        {
            cinema.Schedule = new Schedule();

            //�жϷ�ӳ�б��Ƿ�Ϊ��
            if (cinema.Schedule.Items.Count == 0)
            {
                cinema.Schedule.LoadItem();
            }
            cinema.Load();
            InitTreeView();
            
        }

        //�ر�ʱ���浱ǰ����״̬
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("�Ƿ񱣴浱ǰ����״̬��", "������ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //�˳�ʱ���л�Cinema����
                cinema.Save();
            }
        }

        //��С��ʱ���½ǲ˵���ʾ����ͼ��
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        //����������ͼƬʱ����
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.notifyIcon1.Visible = false;
        }

        //���ӰƬ
        private void tsmiAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.ShowDialog();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wcm777.hk");

        }

        private void picTitle_Click(object sender, EventArgs e)
        {

        }
    }
}