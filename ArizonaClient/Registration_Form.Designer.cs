namespace ArizonaClient
{
    partial class Registration_Form
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
            this.lblClient = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Location = new System.Drawing.Point(0, 0);
            this.lblClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(115, 27);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Компания";
            // 
            // cbClient
            // 
            this.cbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(0, 27);
            this.cbClient.Margin = new System.Windows.Forms.Padding(5);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(351, 34);
            this.cbClient.TabIndex = 1;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstname.Location = new System.Drawing.Point(0, 61);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(105, 27);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "Фамилия";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstname.Location = new System.Drawing.Point(0, 88);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(351, 34);
            this.tbFirstname.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(0, 149);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 34);
            this.tbName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(0, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 27);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Имя";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(0, 210);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(351, 34);
            this.tbPatronymic.TabIndex = 7;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatronymic.Location = new System.Drawing.Point(0, 183);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(107, 27);
            this.lblPatronymic.TabIndex = 6;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(0, 271);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(351, 34);
            this.tbLogin.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(0, 244);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 27);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(0, 332);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(351, 34);
            this.tbPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 305);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 27);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Пароль";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfirm.Location = new System.Drawing.Point(0, 393);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(351, 34);
            this.tbConfirm.TabIndex = 13;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirm.Location = new System.Drawing.Point(0, 366);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(219, 27);
            this.lblConfirm.TabIndex = 12;
            this.lblConfirm.Text = "Подтвердите пароль";
            // 
            // btReg
            // 
            this.btReg.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReg.Location = new System.Drawing.Point(0, 427);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(175, 0);
            this.btReg.TabIndex = 14;
            this.btReg.Text = "Подтвердить";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.BtReg_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(181, 427);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(170, 0);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Отменить";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 405);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lblClient);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Registration_Form";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Button btCancel;
    }
}