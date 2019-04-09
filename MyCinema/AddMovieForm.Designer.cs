namespace MyCinema
{
    partial class AddMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertMovie = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtPicMovieName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoviePrice = new System.Windows.Forms.TextBox();
            this.mTxtDateTime2 = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDateTime1 = new System.Windows.Forms.MaskedTextBox();
            this.cboMovieType = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "影片名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "图片名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "导　演：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "主　演：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "类　型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "价　格：";
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.Location = new System.Drawing.Point(79, 359);
            this.btnInsertMovie.Name = "btnInsertMovie";
            this.btnInsertMovie.Size = new System.Drawing.Size(75, 23);
            this.btnInsertMovie.TabIndex = 7;
            this.btnInsertMovie.Text = "添加";
            this.btnInsertMovie.UseVisualStyleBackColor = true;
            this.btnInsertMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(104, 23);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(208, 21);
            this.txtMovieName.TabIndex = 0;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(104, 139);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(208, 21);
            this.txtActor.TabIndex = 3;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(104, 99);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(208, 21);
            this.txtDirector.TabIndex = 2;
            // 
            // txtPicMovieName
            // 
            this.txtPicMovieName.Location = new System.Drawing.Point(104, 61);
            this.txtPicMovieName.Name = "txtPicMovieName";
            this.txtPicMovieName.Size = new System.Drawing.Size(140, 21);
            this.txtPicMovieName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "时间段：";
            // 
            // txtMoviePrice
            // 
            this.txtMoviePrice.Location = new System.Drawing.Point(104, 218);
            this.txtMoviePrice.Name = "txtMoviePrice";
            this.txtMoviePrice.Size = new System.Drawing.Size(208, 21);
            this.txtMoviePrice.TabIndex = 5;
            this.txtMoviePrice.TextChanged += new System.EventHandler(this.txtMoviePrice_TextChanged);
            this.txtMoviePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoviePrice_KeyPress);
            // 
            // mTxtDateTime2
            // 
            this.mTxtDateTime2.Location = new System.Drawing.Point(104, 303);
            this.mTxtDateTime2.Mask = "00-00 00-00";
            this.mTxtDateTime2.Name = "mTxtDateTime2";
            this.mTxtDateTime2.Size = new System.Drawing.Size(208, 21);
            this.mTxtDateTime2.TabIndex = 7;
            this.mTxtDateTime2.Tag = "";
            // 
            // mTxtDateTime1
            // 
            this.mTxtDateTime1.Location = new System.Drawing.Point(104, 265);
            this.mTxtDateTime1.Mask = "00-00 00-00";
            this.mTxtDateTime1.Name = "mTxtDateTime1";
            this.mTxtDateTime1.Size = new System.Drawing.Size(208, 21);
            this.mTxtDateTime1.TabIndex = 6;
            this.mTxtDateTime1.Tag = "";
            // 
            // cboMovieType
            // 
            this.cboMovieType.FormattingEnabled = true;
            this.cboMovieType.Items.AddRange(new object[] {
            "Comedy",
            "War",
            "Romance",
            "Action",
            "Cartoon",
            "Thriller"});
            this.cboMovieType.Location = new System.Drawing.Point(104, 176);
            this.cboMovieType.Name = "cboMovieType";
            this.cboMovieType.Size = new System.Drawing.Size(208, 20);
            this.cboMovieType.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(250, 59);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(62, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 398);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cboMovieType);
            this.Controls.Add(this.mTxtDateTime1);
            this.Controls.Add(this.mTxtDateTime2);
            this.Controls.Add(this.txtMoviePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPicMovieName);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertMovie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCinemaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertMovie;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtPicMovieName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoviePrice;
        private System.Windows.Forms.MaskedTextBox mTxtDateTime2;
        private System.Windows.Forms.MaskedTextBox mTxtDateTime1;
        private System.Windows.Forms.ComboBox cboMovieType;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}