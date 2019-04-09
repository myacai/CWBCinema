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

        // 页面加载时触发
        private void MainForm_Load(object sender, EventArgs e)
        {
            //创建一个电影院
            cinema = new Cinema();

            //清空影片详情信息
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

            //调用添加动态座位的方法
            InitSeats(7, 5, tbCinemas);
        }

        // 初始化 TreeView 控件
        public void InitTreeView()
        {
            //清空树节点的集合
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

        // 添加动态加载座位的方法
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
                    label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    label.Location = new System.Drawing.Point(59, 60);
                    label.Name = "lbl" + (j + 1).ToString() + "_" + (i + 1).ToString();
                    label.Size = new System.Drawing.Size(50, 25);
                    //设置座位号
                    label.Text = Convert.ToString((j + 1)) + "-" + Convert.ToString((i + 1));
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                    //所有的标签都绑定到同一事件
                    label.Click += new System.EventHandler(lblSeat_Click);
                    tb.Controls.Add(label);
                    labels.Add(label.Text, label);

                    //实例化一个座位
                    seat = new Seat(Convert.ToString((j + 1)) + "-" + Convert.ToString((i + 1)),Color.Yellow);

                    //保存的座位集合
                    cinema.Seats.Add(seat.SeatNum, seat);
                }
            }
        }

        // 单击新销售时刷新放映列表
        private void tsmiNewVendition_Click(object sender, EventArgs e)
        {
            cinema.Schedule = new Schedule();
            cinema.Schedule.LoadItem();
            cinema.SoldTickets.Clear();
            InitTreeView();
        }

        // 单击节点时发生
        private void tvMyXml_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取当前选中的节点
            TreeNode node = tvMyXml.SelectedNode;

            //判断该节点是否为空
            if (node == null)
            {
                return;
            }

            //判断节点是否是放映时间
            if (node.Level != 1)
            {
                return;
            }

            //获取节点的信息
            key = tvMyXml.SelectedNode.Text;

            //显示详细信息
            this.lblName.Text = cinema.Schedule.Items[key].Movie.MovieName;
            this.lblDirector.Text = cinema.Schedule.Items[key].Movie.Director;
            this.lblActor.Text = cinema.Schedule.Items[key].Movie.Actor;
            this.lblMovieType.Text = cinema.Schedule.Items[key].Movie.MovieType.ToString();
            this.lblTime.Text = cinema.Schedule.Items[key].Time;
            this.lblPrice.Text = cinema.Schedule.Items[key].Movie.Price.ToString();
            this.picTitle.Image = Image.FromFile(cinema.Schedule.Items[key].Movie.Poster);
            this.lblPreferentialPrice.Text = "";

            //清空和更新座位信息
            ClearSeat(key);
        }

        //更新座位状态
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }

        //退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //单选按钮选中事件
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

        //单击一个座位，购买电影票
        private void lblSeat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lblName.Text))
            {
                MessageBox.Show("您还没有选择电影！");
                return;
            }

            //将选择的sender转换为标签,并取得标签的Text,获取座位号
            string seatNum = ((Label)sender).Text.ToString();
            key = tvMyXml.SelectedNode.Text;
            string customer = null;
            int discount = 0;
            string type = null;
            if (cinema.Seats[seatNum].Color == Color.Red)
            {
                MessageBox.Show("对不起，此票已售出！");
                return;
            }
            if (rdoCommon.Checked == true)
            {
                type = "普通票";
            }
            if (rdoLargess.Checked == true)
            {
                if (this.txtPresent.Text.Trim() == "")
                {
                    MessageBox.Show("请输入赠票者姓名！");
                    txtPresent.Focus();
                    return;
                }
                type = "赠票";
                customer = txtPresent.Text;
            }
            if (rdoStudent.Checked == true)
            {
                type = "学生票";
                discount = Convert.ToInt32(this.cboStudentDiscount.Text);
            }
            try
            {
                //调用简单工厂模式，创建不同类型的电影票
                Ticket ticket = TicketFactory.CreateTicket(cinema.Schedule.Items[key], cinema.Seats[seatNum], customer, discount, type);
                DialogResult result = MessageBox.Show("是否购买？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //将创建好的票添加到已售出票的集合中
                    cinema.SoldTickets.Add(ticket);

                    //计算优惠价格
                    ticket.CalcPrice();

                    //显示到优惠价标签
                    this.lblPreferentialPrice.Text = ticket.Price.ToString();
                    this.lblPreferentialPrice.ForeColor = System.Drawing.Color.Red;

                    //调用打印方法 
                    ticket.Print();

                    //清空和更新座位信息
                    ClearSeat(key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出售失败！" + ex.Message.ToString());
            }
        }

        //清空座位
        private void ClearSeat(string key)
        {
            foreach (Seat seat in cinema.Seats.Values)
            {
                seat.Color = Color.Yellow;
            }

            //遍历该场电影的座位销售情况
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

            //更新座位状态
            UpdateSeat();
        }

        //继续销售
        private void tsmiContinueCinema_Click(object sender, EventArgs e)
        {
            cinema.Schedule = new Schedule();

            //判断放映列表是否为空
            if (cinema.Schedule.Items.Count == 0)
            {
                cinema.Schedule.LoadItem();
            }
            cinema.Load();
            InitTreeView();
            
        }

        //关闭时保存当前销售状态
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否保存当前销售状态？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //退出时序列化Cinema对象
                cinema.Save();
            }
        }

        //最小化时右下角菜单显示程序图标
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        //单击任务栏图片时触发
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.notifyIcon1.Visible = false;
        }

        //添加影片
        private void tsmiAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wcm777.hk");

        }

        private void picTitle_Click(object sender, EventArgs e)
        {

        }
    }
}