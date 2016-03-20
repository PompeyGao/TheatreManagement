namespace Theatre_Management
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.btnQuit = new CCWin.SkinControl.SkinButton();
            this.linklblRegister = new System.Windows.Forms.LinkLabel();
            this.lblLoginName = new CCWin.SkinControl.SkinLabel();
            this.lblLoginPwd = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txtLoginName = new CCWin.SkinControl.SkinTextBox();
            this.txtLoginPwd = new CCWin.SkinControl.SkinTextBox();
            this.lblType = new CCWin.SkinControl.SkinLabel();
            this.cboLoginType = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.Create = true;
            this.btnLogin.DownBack = null;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnLogin.ForeColorSuit = true;
            this.btnLogin.Location = new System.Drawing.Point(117, 267);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuit.DownBack = null;
            this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(271, 267);
            this.btnQuit.MouseBack = null;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.NormlBack = null;
            this.btnQuit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "退  出";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // linklblRegister
            // 
            this.linklblRegister.AutoSize = true;
            this.linklblRegister.BackColor = System.Drawing.Color.Transparent;
            this.linklblRegister.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.linklblRegister.Location = new System.Drawing.Point(286, 312);
            this.linklblRegister.Name = "linklblRegister";
            this.linklblRegister.Size = new System.Drawing.Size(135, 20);
            this.linklblRegister.TabIndex = 2;
            this.linklblRegister.TabStop = true;
            this.linklblRegister.Text = "还没有账户，去注册";
            this.linklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegister_LinkClicked);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.BorderColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginName.Location = new System.Drawing.Point(83, 100);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(58, 21);
            this.lblLoginName.TabIndex = 3;
            this.lblLoginName.Text = "用户名";
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPwd.BorderColor = System.Drawing.Color.Transparent;
            this.lblLoginPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLoginPwd.Location = new System.Drawing.Point(83, 159);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(42, 21);
            this.lblLoginPwd.TabIndex = 4;
            this.lblLoginPwd.Text = "密码";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("华文中宋", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(137, 22);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(160, 31);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "XX影院系统";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginName.DownBack = null;
            this.txtLoginName.Icon = ((System.Drawing.Image)(resources.GetObject("txtLoginName.Icon")));
            this.txtLoginName.IconIsButton = false;
            this.txtLoginName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtLoginName.IsPasswordChat = '\0';
            this.txtLoginName.IsSystemPasswordChar = false;
            this.txtLoginName.Lines = new string[0];
            this.txtLoginName.Location = new System.Drawing.Point(161, 93);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginName.MaxLength = 32767;
            this.txtLoginName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtLoginName.MouseBack = null;
            this.txtLoginName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtLoginName.Multiline = false;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.NormlBack = null;
            this.txtLoginName.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtLoginName.ReadOnly = false;
            this.txtLoginName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtLoginName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtLoginName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtLoginName.SkinTxt.Name = "BaseText";
            this.txtLoginName.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtLoginName.SkinTxt.TabIndex = 0;
            this.txtLoginName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtLoginName.SkinTxt.WaterText = "";
            this.txtLoginName.TabIndex = 6;
            this.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtLoginName.WaterText = "";
            this.txtLoginName.WordWrap = true;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginPwd.DownBack = null;
            this.txtLoginPwd.Icon = ((System.Drawing.Image)(resources.GetObject("txtLoginPwd.Icon")));
            this.txtLoginPwd.IconIsButton = false;
            this.txtLoginPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtLoginPwd.IsPasswordChat = '*';
            this.txtLoginPwd.IsSystemPasswordChar = false;
            this.txtLoginPwd.Lines = new string[0];
            this.txtLoginPwd.Location = new System.Drawing.Point(161, 152);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginPwd.MaxLength = 32767;
            this.txtLoginPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtLoginPwd.MouseBack = null;
            this.txtLoginPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtLoginPwd.Multiline = false;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.NormlBack = null;
            this.txtLoginPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtLoginPwd.ReadOnly = false;
            this.txtLoginPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtLoginPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtLoginPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtLoginPwd.SkinTxt.Name = "BaseText";
            this.txtLoginPwd.SkinTxt.PasswordChar = '*';
            this.txtLoginPwd.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtLoginPwd.SkinTxt.TabIndex = 0;
            this.txtLoginPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtLoginPwd.SkinTxt.WaterText = "";
            this.txtLoginPwd.TabIndex = 7;
            this.txtLoginPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtLoginPwd.WaterText = "";
            this.txtLoginPwd.WordWrap = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.BorderColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblType.Location = new System.Drawing.Point(83, 214);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 21);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "类型";
            // 
            // cboLoginType
            // 
            this.cboLoginType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoginType.FormattingEnabled = true;
            this.cboLoginType.Location = new System.Drawing.Point(161, 213);
            this.cboLoginType.Name = "cboLoginType";
            this.cboLoginType.Size = new System.Drawing.Size(185, 22);
            this.cboLoginType.TabIndex = 9;
            this.cboLoginType.WaterText = "";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theatre_Management.Properties.Resources.b_看图王;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 353);
            this.Controls.Add(this.cboLoginType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.lblLoginPwd);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.linklblRegister);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "登录";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton btnQuit;
        private System.Windows.Forms.LinkLabel linklblRegister;
        private CCWin.SkinControl.SkinLabel lblLoginName;
        private CCWin.SkinControl.SkinLabel lblLoginPwd;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox txtLoginName;
        private CCWin.SkinControl.SkinTextBox txtLoginPwd;
        private CCWin.SkinControl.SkinLabel lblType;
        private CCWin.SkinControl.SkinComboBox cboLoginType;
    }
}

