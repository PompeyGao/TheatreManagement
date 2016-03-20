namespace Theatre_Management
{
    partial class AddFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureboxPoster = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfirmAdd = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnInsertPoster = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPlayTime = new System.Windows.Forms.TextBox();
            this.cboFilmType = new CCWin.SkinControl.SkinComboBox();
            this.cboHall = new CCWin.SkinControl.SkinComboBox();
            this.dtpPlayDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIntroduction = new CCWin.SkinControl.SkinTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPoster)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtpPlayDate);
            this.groupBox1.Controls.Add(this.cboHall);
            this.groupBox1.Controls.Add(this.cboFilmType);
            this.groupBox1.Controls.Add(this.txtPlayTime);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtActor);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.txtFilmName);
            this.groupBox1.Controls.Add(this.skinLabel8);
            this.groupBox1.Controls.Add(this.skinLabel7);
            this.groupBox1.Controls.Add(this.skinLabel6);
            this.groupBox1.Controls.Add(this.skinLabel5);
            this.groupBox1.Controls.Add(this.skinLabel4);
            this.groupBox1.Controls.Add(this.skinLabel3);
            this.groupBox1.Controls.Add(this.skinLabel2);
            this.groupBox1.Controls.Add(this.skinLabel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影片信息";
            // 
            // pictureboxPoster
            // 
            this.pictureboxPoster.Location = new System.Drawing.Point(6, 22);
            this.pictureboxPoster.Name = "pictureboxPoster";
            this.pictureboxPoster.Size = new System.Drawing.Size(273, 354);
            this.pictureboxPoster.TabIndex = 1;
            this.pictureboxPoster.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureboxPoster);
            this.groupBox2.Location = new System.Drawing.Point(509, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电影海报";
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConfirmAdd.DownBack = null;
            this.btnConfirmAdd.Location = new System.Drawing.Point(329, 473);
            this.btnConfirmAdd.MouseBack = null;
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.NormlBack = null;
            this.btnConfirmAdd.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAdd.TabIndex = 3;
            this.btnConfirmAdd.Text = "确认增加";
            this.btnConfirmAdd.UseVisualStyleBackColor = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(586, 473);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnInsertPoster
            // 
            this.btnInsertPoster.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertPoster.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnInsertPoster.DownBack = null;
            this.btnInsertPoster.Location = new System.Drawing.Point(574, 401);
            this.btnInsertPoster.MouseBack = null;
            this.btnInsertPoster.Name = "btnInsertPoster";
            this.btnInsertPoster.NormlBack = null;
            this.btnInsertPoster.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnInsertPoster.Size = new System.Drawing.Size(167, 23);
            this.btnInsertPoster.TabIndex = 5;
            this.btnInsertPoster.Text = "插 入 海 报";
            this.btnInsertPoster.UseVisualStyleBackColor = false;
            this.btnInsertPoster.Click += new System.EventHandler(this.btnInsertPoster_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(6, 35);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "影片名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(6, 85);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "导演";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(6, 137);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "主演";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(6, 189);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "价格";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(6, 237);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 4;
            this.skinLabel5.Text = "类型";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(6, 280);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 5;
            this.skinLabel6.Text = "放映日期";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(6, 324);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 6;
            this.skinLabel7.Text = "场次";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(6, 371);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(44, 17);
            this.skinLabel8.TabIndex = 7;
            this.skinLabel8.Text = "放映厅";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(94, 35);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(164, 23);
            this.txtFilmName.TabIndex = 8;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(94, 85);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(164, 23);
            this.txtDirector.TabIndex = 9;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(94, 137);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(164, 23);
            this.txtActor.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 23);
            this.txtPrice.TabIndex = 11;
            // 
            // txtPlayTime
            // 
            this.txtPlayTime.Location = new System.Drawing.Point(94, 324);
            this.txtPlayTime.Name = "txtPlayTime";
            this.txtPlayTime.Size = new System.Drawing.Size(164, 23);
            this.txtPlayTime.TabIndex = 14;
            // 
            // cboFilmType
            // 
            this.cboFilmType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilmType.FormattingEnabled = true;
            this.cboFilmType.Location = new System.Drawing.Point(94, 237);
            this.cboFilmType.Name = "cboFilmType";
            this.cboFilmType.Size = new System.Drawing.Size(164, 24);
            this.cboFilmType.TabIndex = 15;
            this.cboFilmType.WaterText = "";
            // 
            // cboHall
            // 
            this.cboHall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHall.FormattingEnabled = true;
            this.cboHall.Location = new System.Drawing.Point(94, 371);
            this.cboHall.Name = "cboHall";
            this.cboHall.Size = new System.Drawing.Size(164, 24);
            this.cboHall.TabIndex = 16;
            this.cboHall.WaterText = "";
            // 
            // dtpPlayDate
            // 
            this.dtpPlayDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpPlayDate.DropDownHeight = 180;
            this.dtpPlayDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpPlayDate.DropDownWidth = 120;
            this.dtpPlayDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpPlayDate.Items = null;
            this.dtpPlayDate.Location = new System.Drawing.Point(94, 280);
            this.dtpPlayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPlayDate.Name = "dtpPlayDate";
            this.dtpPlayDate.Size = new System.Drawing.Size(164, 22);
            this.dtpPlayDate.TabIndex = 17;
            this.dtpPlayDate.text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIntroduction);
            this.groupBox3.Location = new System.Drawing.Point(316, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 360);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "影片简介";
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.txtIntroduction.DownBack = null;
            this.txtIntroduction.Icon = null;
            this.txtIntroduction.IconIsButton = false;
            this.txtIntroduction.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIntroduction.IsPasswordChat = '\0';
            this.txtIntroduction.IsSystemPasswordChar = false;
            this.txtIntroduction.Lines = new string[0];
            this.txtIntroduction.Location = new System.Drawing.Point(3, 19);
            this.txtIntroduction.Margin = new System.Windows.Forms.Padding(0);
            this.txtIntroduction.MaxLength = 32767;
            this.txtIntroduction.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtIntroduction.MouseBack = null;
            this.txtIntroduction.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.NormlBack = null;
            this.txtIntroduction.Padding = new System.Windows.Forms.Padding(5);
            this.txtIntroduction.ReadOnly = false;
            this.txtIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIntroduction.Size = new System.Drawing.Size(152, 334);
            // 
            // 
            // 
            this.txtIntroduction.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntroduction.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIntroduction.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtIntroduction.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtIntroduction.SkinTxt.Multiline = true;
            this.txtIntroduction.SkinTxt.Name = "BaseText";
            this.txtIntroduction.SkinTxt.Size = new System.Drawing.Size(142, 324);
            this.txtIntroduction.SkinTxt.TabIndex = 0;
            this.txtIntroduction.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIntroduction.SkinTxt.WaterText = "";
            this.txtIntroduction.TabIndex = 0;
            this.txtIntroduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIntroduction.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIntroduction.WaterText = "";
            this.txtIntroduction.WordWrap = true;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 528);
            this.Controls.Add(this.btnInsertPoster);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddFilm";
            this.Text = "增加影片";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPoster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.PictureBox pictureboxPoster;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinButton btnConfirmAdd;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnInsertPoster;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinDateTimePicker dtpPlayDate;
        private CCWin.SkinControl.SkinComboBox cboHall;
        private CCWin.SkinControl.SkinComboBox cboFilmType;
        private System.Windows.Forms.TextBox txtPlayTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinTextBox txtIntroduction;
    }
}