namespace Theatre_Management
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtUserName = new CCWin.SkinControl.SkinTextBox();
            this.txtLoginPwd = new CCWin.SkinControl.SkinTextBox();
            this.txtConfirmPwd = new CCWin.SkinControl.SkinTextBox();
            this.btnRegister = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文中宋", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(132, 18);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(122, 31);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "用户注册";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel2.Location = new System.Drawing.Point(62, 85);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(58, 21);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "用户名";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel3.Location = new System.Drawing.Point(62, 139);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(74, 21);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "登录密码";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel4.Location = new System.Drawing.Point(62, 188);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(74, 21);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "确认密码";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(269, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "已有账户，去登录";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.DownBack = null;
            this.txtUserName.Icon = global::Theatre_Management.Properties.Resources.login;
            this.txtUserName.IconIsButton = false;
            this.txtUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserName.IsPasswordChat = '\0';
            this.txtUserName.IsSystemPasswordChar = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(150, 78);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserName.MouseBack = null;
            this.txtUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NormlBack = null;
            this.txtUserName.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtUserName.ReadOnly = false;
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserName.SkinTxt.Name = "BaseText";
            this.txtUserName.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtUserName.SkinTxt.TabIndex = 0;
            this.txtUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.SkinTxt.WaterText = "";
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.WaterText = "";
            this.txtUserName.WordWrap = true;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginPwd.DownBack = null;
            this.txtLoginPwd.Icon = global::Theatre_Management.Properties.Resources.pwd;
            this.txtLoginPwd.IconIsButton = false;
            this.txtLoginPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtLoginPwd.IsPasswordChat = '*';
            this.txtLoginPwd.IsSystemPasswordChar = false;
            this.txtLoginPwd.Lines = new string[0];
            this.txtLoginPwd.Location = new System.Drawing.Point(150, 132);
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
            this.txtLoginPwd.TabIndex = 8;
            this.txtLoginPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtLoginPwd.WaterText = "";
            this.txtLoginPwd.WordWrap = true;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPwd.DownBack = null;
            this.txtConfirmPwd.Icon = global::Theatre_Management.Properties.Resources.pwd;
            this.txtConfirmPwd.IconIsButton = false;
            this.txtConfirmPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConfirmPwd.IsPasswordChat = '*';
            this.txtConfirmPwd.IsSystemPasswordChar = false;
            this.txtConfirmPwd.Lines = new string[0];
            this.txtConfirmPwd.Location = new System.Drawing.Point(150, 181);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPwd.MaxLength = 32767;
            this.txtConfirmPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtConfirmPwd.MouseBack = null;
            this.txtConfirmPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConfirmPwd.Multiline = false;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.NormlBack = null;
            this.txtConfirmPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtConfirmPwd.ReadOnly = false;
            this.txtConfirmPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtConfirmPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtConfirmPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtConfirmPwd.SkinTxt.Name = "BaseText";
            this.txtConfirmPwd.SkinTxt.PasswordChar = '*';
            this.txtConfirmPwd.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtConfirmPwd.SkinTxt.TabIndex = 0;
            this.txtConfirmPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConfirmPwd.SkinTxt.WaterText = "";
            this.txtConfirmPwd.TabIndex = 9;
            this.txtConfirmPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConfirmPwd.WaterText = "";
            this.txtConfirmPwd.WordWrap = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRegister.DownBack = null;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(114, 253);
            this.btnRegister.MouseBack = null;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormlBack = null;
            this.btnRegister.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "注  册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(260, 253);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theatre_Management.Properties.Resources.b_看图王;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private CCWin.SkinControl.SkinTextBox txtUserName;
        private CCWin.SkinControl.SkinTextBox txtLoginPwd;
        private CCWin.SkinControl.SkinTextBox txtConfirmPwd;
        private CCWin.SkinControl.SkinButton btnRegister;
        private CCWin.SkinControl.SkinButton btnCancel;
    }
}