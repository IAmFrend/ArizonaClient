namespace ArizonaClient
{
    partial class Autorization_Form
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(84, 31);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserLogin.Location = new System.Drawing.Point(0, 31);
            this.tbUserLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(418, 38);
            this.tbUserLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 69);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 31);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserPassword.Location = new System.Drawing.Point(0, 100);
            this.tbUserPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(418, 38);
            this.tbUserPassword.TabIndex = 4;
            // 
            // btEnter
            // 
            this.btEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEnter.Location = new System.Drawing.Point(0, 138);
            this.btEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(134, 31);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(292, 138);
            this.btClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(126, 31);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Отмена";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtLeave_Click);
            // 
            // btReg
            // 
            this.btReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReg.Location = new System.Drawing.Point(134, 138);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(158, 31);
            this.btReg.TabIndex = 7;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.BtReg_Click);
            // 
            // Autorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 169);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Autorization_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autorization_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btReg;
    }
}