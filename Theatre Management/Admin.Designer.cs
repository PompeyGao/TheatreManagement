namespace Theatre_Management
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.txtDetail = new CCWin.SkinControl.SkinTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnModify = new CCWin.SkinControl.SkinButton();
            this.btnDel = new CCWin.SkinControl.SkinButton();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.btnFresh = new CCWin.SkinControl.SkinButton();
            this.btnQuit = new CCWin.SkinControl.SkinButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPlayDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.cboHall = new CCWin.SkinControl.SkinComboBox();
            this.cboFilmType = new CCWin.SkinControl.SkinComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtPlayTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(13, 13);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(879, 244);
            this.dgvList.TabIndex = 0;
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.Transparent;
            this.txtDetail.DownBack = null;
            this.txtDetail.Icon = null;
            this.txtDetail.IconIsButton = false;
            this.txtDetail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDetail.IsPasswordChat = '\0';
            this.txtDetail.IsSystemPasswordChar = false;
            this.txtDetail.Lines = new string[0];
            this.txtDetail.Location = new System.Drawing.Point(2, 17);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(0);
            this.txtDetail.MaxLength = 32767;
            this.txtDetail.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDetail.MouseBack = null;
            this.txtDetail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.NormlBack = null;
            this.txtDetail.Padding = new System.Windows.Forms.Padding(5);
            this.txtDetail.ReadOnly = false;
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.Size = new System.Drawing.Size(406, 191);
            // 
            // 
            // 
            this.txtDetail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDetail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDetail.SkinTxt.Multiline = true;
            this.txtDetail.SkinTxt.Name = "BaseText";
            this.txtDetail.SkinTxt.Size = new System.Drawing.Size(396, 181);
            this.txtDetail.SkinTxt.TabIndex = 0;
            this.txtDetail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.SkinTxt.WaterText = "";
            this.txtDetail.TabIndex = 2;
            this.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.WaterText = "";
            this.txtDetail.WordWrap = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtDetail);
            this.groupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox.Location = new System.Drawing.Point(481, 263);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(411, 211);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "电影简介";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModify.DownBack = null;
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Location = new System.Drawing.Point(254, 492);
            this.btnModify.MouseBack = null;
            this.btnModify.Name = "btnModify";
            this.btnModify.NormlBack = null;
            this.btnModify.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修  改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDel.DownBack = null;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(384, 492);
            this.btnDel.MouseBack = null;
            this.btnDel.Name = "btnDel";
            this.btnDel.NormlBack = null;
            this.btnDel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删  除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(517, 492);
            this.btnAdd.MouseBack = null;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "增加影片";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Transparent;
            this.btnFresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFresh.DownBack = null;
            this.btnFresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.Location = new System.Drawing.Point(652, 492);
            this.btnFresh.MouseBack = null;
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.NormlBack = null;
            this.btnFresh.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnFresh.Size = new System.Drawing.Size(75, 23);
            this.btnFresh.TabIndex = 7;
            this.btnFresh.Text = "刷  新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuit.DownBack = null;
            this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(789, 492);
            this.btnQuit.MouseBack = null;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.NormlBack = null;
            this.btnQuit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "退  出";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlayTime);
            this.groupBox1.Controls.Add(this.skinLabel8);
            this.groupBox1.Controls.Add(this.dtpPlayDate);
            this.groupBox1.Controls.Add(this.cboHall);
            this.groupBox1.Controls.Add(this.cboFilmType);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtActor);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.txtFilmName);
            this.groupBox1.Controls.Add(this.skinLabel7);
            this.groupBox1.Controls.Add(this.skinLabel6);
            this.groupBox1.Controls.Add(this.skinLabel5);
            this.groupBox1.Controls.Add(this.skinLabel4);
            this.groupBox1.Controls.Add(this.skinLabel3);
            this.groupBox1.Controls.Add(this.skinLabel2);
            this.groupBox1.Controls.Add(this.skinLabel1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影片信息";
            // 
            // dtpPlayDate
            // 
            this.dtpPlayDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpPlayDate.DropDownHeight = 180;
            this.dtpPlayDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpPlayDate.DropDownWidth = 120;
            this.dtpPlayDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpPlayDate.Items = null;
            this.dtpPlayDate.Location = new System.Drawing.Point(69, 165);
            this.dtpPlayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPlayDate.Name = "dtpPlayDate";
            this.dtpPlayDate.Size = new System.Drawing.Size(124, 22);
            this.dtpPlayDate.TabIndex = 13;
            this.dtpPlayDate.text = "";
            // 
            // cboHall
            // 
            this.cboHall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHall.FormattingEnabled = true;
            this.cboHall.Location = new System.Drawing.Point(293, 120);
            this.cboHall.Name = "cboHall";
            this.cboHall.Size = new System.Drawing.Size(121, 24);
            this.cboHall.TabIndex = 12;
            this.cboHall.WaterText = "";
            // 
            // cboFilmType
            // 
            this.cboFilmType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilmType.FormattingEnabled = true;
            this.cboFilmType.Location = new System.Drawing.Point(69, 120);
            this.cboFilmType.Name = "cboFilmType";
            this.cboFilmType.Size = new System.Drawing.Size(124, 24);
            this.cboFilmType.TabIndex = 11;
            this.cboFilmType.WaterText = "";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(293, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 23);
            this.txtPrice.TabIndex = 10;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(293, 30);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(121, 23);
            this.txtActor.TabIndex = 9;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(69, 79);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(124, 23);
            this.txtDirector.TabIndex = 8;
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(69, 33);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(124, 23);
            this.txtFilmName.TabIndex = 7;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(238, 120);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(44, 17);
            this.skinLabel7.TabIndex = 6;
            this.skinLabel7.Text = "放映厅";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(238, 79);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 5;
            this.skinLabel6.Text = "价格";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(238, 33);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 4;
            this.skinLabel5.Text = "主演";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(6, 165);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "放映日期";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(6, 120);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "类型";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(6, 79);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "导演";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(6, 33);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "电影名称";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(238, 165);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 14;
            this.skinLabel8.Text = "场次";
            // 
            // txtPlayTime
            // 
            this.txtPlayTime.Location = new System.Drawing.Point(293, 165);
            this.txtPlayTime.Name = "txtPlayTime";
            this.txtPlayTime.Size = new System.Drawing.Size(121, 23);
            this.txtPlayTime.TabIndex = 15;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dgvList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "管理员";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private CCWin.SkinControl.SkinTextBox txtDetail;
        private System.Windows.Forms.GroupBox groupBox;
        private CCWin.SkinControl.SkinButton btnModify;
        private CCWin.SkinControl.SkinButton btnDel;
        private CCWin.SkinControl.SkinButton btnAdd;
        private CCWin.SkinControl.SkinButton btnFresh;
        private CCWin.SkinControl.SkinButton btnQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinDateTimePicker dtpPlayDate;
        private CCWin.SkinControl.SkinComboBox cboHall;
        private CCWin.SkinControl.SkinComboBox cboFilmType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtFilmName;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.TextBox txtPlayTime;
        private CCWin.SkinControl.SkinLabel skinLabel8;
    }
}