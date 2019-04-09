namespace MyCinema
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBuyPiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewVendition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContinueCinema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvMyXml = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPreferentialPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.cboStudentDiscount = new System.Windows.Forms.ComboBox();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblDisCount = new System.Windows.Forms.Label();
            this.rdoLargess = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoCommon = new System.Windows.Forms.RadioButton();
            this.tbCinema = new System.Windows.Forms.TabControl();
            this.tbCinemas = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuyPiao,
            this.tsmiSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBuyPiao
            // 
            this.tsmiBuyPiao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewVendition,
            this.tsmiContinueCinema,
            this.tsmiExit});
            this.tsmiBuyPiao.Name = "tsmiBuyPiao";
            this.tsmiBuyPiao.Size = new System.Drawing.Size(44, 21);
            this.tsmiBuyPiao.Text = "购票";
            // 
            // tsmiNewVendition
            // 
            this.tsmiNewVendition.Name = "tsmiNewVendition";
            this.tsmiNewVendition.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewVendition.Text = "新 销 售";
            this.tsmiNewVendition.Click += new System.EventHandler(this.tsmiNewVendition_Click);
            // 
            // tsmiContinueCinema
            // 
            this.tsmiContinueCinema.Name = "tsmiContinueCinema";
            this.tsmiContinueCinema.Size = new System.Drawing.Size(152, 22);
            this.tsmiContinueCinema.Text = "继续销售";
            this.tsmiContinueCinema.Click += new System.EventHandler(this.tsmiContinueCinema_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "退　  出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddMovie,
            this.关于ToolStripMenuItem});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmiSystem.Text = "系统";
            // 
            // tsmiAddMovie
            // 
            this.tsmiAddMovie.Name = "tsmiAddMovie";
            this.tsmiAddMovie.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddMovie.Text = "添加影片";
            this.tsmiAddMovie.Click += new System.EventHandler(this.tsmiAddMovie_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 639);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvMyXml);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "放映列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvMyXml
            // 
            this.tvMyXml.ImageIndex = 2;
            this.tvMyXml.ImageList = this.imageList1;
            this.tvMyXml.Location = new System.Drawing.Point(7, 11);
            this.tvMyXml.Name = "tvMyXml";
            this.tvMyXml.SelectedImageIndex = 1;
            this.tvMyXml.Size = new System.Drawing.Size(176, 575);
            this.tvMyXml.TabIndex = 0;
            this.tvMyXml.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMyXml_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "(26,36).png");
            this.imageList1.Images.SetKeyName(1, "(35,39).png");
            this.imageList1.Images.SetKeyName(2, "(14,37).png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPreferentialPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblMovieType);
            this.groupBox1.Controls.Add(this.lblActor);
            this.groupBox1.Controls.Add(this.lblDirector);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picTitle);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(208, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // lblPreferentialPrice
            // 
            this.lblPreferentialPrice.AutoSize = true;
            this.lblPreferentialPrice.Location = new System.Drawing.Point(318, 176);
            this.lblPreferentialPrice.Name = "lblPreferentialPrice";
            this.lblPreferentialPrice.Size = new System.Drawing.Size(47, 12);
            this.lblPreferentialPrice.TabIndex = 14;
            this.lblPreferentialPrice.Text = "label14";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(318, 143);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 12);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "label13";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(318, 113);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 12);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "label12";
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Location = new System.Drawing.Point(318, 83);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(47, 12);
            this.lblMovieType.TabIndex = 11;
            this.lblMovieType.Text = "label11";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(318, 53);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(47, 12);
            this.lblActor.TabIndex = 10;
            this.lblActor.Text = "label10";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(318, 21);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(41, 12);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(209, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "优惠价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "票 价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "放映时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "类 型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "主 演：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(215, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "导 演：";
            // 
            // picTitle
            // 
            this.picTitle.Location = new System.Drawing.Point(21, 42);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(111, 155);
            this.picTitle.TabIndex = 2;
            this.picTitle.TabStop = false;
            this.picTitle.Click += new System.EventHandler(this.picTitle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(81, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "片名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPresent);
            this.groupBox2.Controls.Add(this.cboStudentDiscount);
            this.groupBox2.Controls.Add(this.lblPresent);
            this.groupBox2.Controls.Add(this.lblDisCount);
            this.groupBox2.Controls.Add(this.rdoLargess);
            this.groupBox2.Controls.Add(this.rdoStudent);
            this.groupBox2.Controls.Add(this.rdoCommon);
            this.groupBox2.Location = new System.Drawing.Point(668, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 212);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "特殊票：";
            // 
            // txtPresent
            // 
            this.txtPresent.Location = new System.Drawing.Point(100, 138);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(100, 21);
            this.txtPresent.TabIndex = 6;
            // 
            // cboStudentDiscount
            // 
            this.cboStudentDiscount.FormattingEnabled = true;
            this.cboStudentDiscount.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboStudentDiscount.Location = new System.Drawing.Point(100, 99);
            this.cboStudentDiscount.Name = "cboStudentDiscount";
            this.cboStudentDiscount.Size = new System.Drawing.Size(100, 20);
            this.cboStudentDiscount.TabIndex = 5;
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Location = new System.Drawing.Point(38, 141);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(53, 12);
            this.lblPresent.TabIndex = 4;
            this.lblPresent.Text = "赠送者：";
            // 
            // lblDisCount
            // 
            this.lblDisCount.AutoSize = true;
            this.lblDisCount.Location = new System.Drawing.Point(26, 102);
            this.lblDisCount.Name = "lblDisCount";
            this.lblDisCount.Size = new System.Drawing.Size(65, 12);
            this.lblDisCount.TabIndex = 3;
            this.lblDisCount.Text = "学生折扣：";
            // 
            // rdoLargess
            // 
            this.rdoLargess.AutoSize = true;
            this.rdoLargess.Location = new System.Drawing.Point(99, 32);
            this.rdoLargess.Name = "rdoLargess";
            this.rdoLargess.Size = new System.Drawing.Size(47, 16);
            this.rdoLargess.TabIndex = 2;
            this.rdoLargess.TabStop = true;
            this.rdoLargess.Text = "赠票";
            this.rdoLargess.UseVisualStyleBackColor = true;
            this.rdoLargess.CheckedChanged += new System.EventHandler(this.rdoLargess_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(164, 32);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(59, 16);
            this.rdoStudent.TabIndex = 1;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "学生票";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoLargess_CheckedChanged);
            // 
            // rdoCommon
            // 
            this.rdoCommon.AutoSize = true;
            this.rdoCommon.Location = new System.Drawing.Point(21, 32);
            this.rdoCommon.Name = "rdoCommon";
            this.rdoCommon.Size = new System.Drawing.Size(59, 16);
            this.rdoCommon.TabIndex = 0;
            this.rdoCommon.TabStop = true;
            this.rdoCommon.Text = "普通票";
            this.rdoCommon.UseVisualStyleBackColor = true;
            this.rdoCommon.CheckedChanged += new System.EventHandler(this.rdoLargess_CheckedChanged);
            // 
            // tbCinema
            // 
            this.tbCinema.Controls.Add(this.tbCinemas);
            this.tbCinema.Controls.Add(this.tabPage2);
            this.tbCinema.Location = new System.Drawing.Point(209, 255);
            this.tbCinema.Name = "tbCinema";
            this.tbCinema.SelectedIndex = 0;
            this.tbCinema.Size = new System.Drawing.Size(712, 419);
            this.tbCinema.TabIndex = 4;
            // 
            // tbCinemas
            // 
            this.tbCinemas.Location = new System.Drawing.Point(4, 22);
            this.tbCinemas.Name = "tbCinemas";
            this.tbCinemas.Padding = new System.Windows.Forms.Padding(3);
            this.tbCinemas.Size = new System.Drawing.Size(704, 393);
            this.tbCinemas.TabIndex = 1;
            this.tbCinemas.Text = "普通厅";
            this.tbCinemas.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 393);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "IMAX厅";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "影院售票系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 685);
            this.Controls.Add(this.tbCinema);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蔡雯彬影城售票系统";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbCinema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuyPiao;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView tvMyXml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPreferentialPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.ComboBox cboStudentDiscount;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblDisCount;
        private System.Windows.Forms.RadioButton rdoLargess;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoCommon;
        private System.Windows.Forms.TabControl tbCinema;
        private System.Windows.Forms.TabPage tbCinemas;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewVendition;
        private System.Windows.Forms.ToolStripMenuItem tsmiContinueCinema;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMovie;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

