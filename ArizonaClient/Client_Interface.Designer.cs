namespace ArizonaClient
{
    partial class Client_Interface
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
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btDrawback = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbctrlClient = new System.Windows.Forms.TabControl();
            this.tbpgOrder = new System.Windows.Forms.TabPage();
            this.btOrderAdd = new System.Windows.Forms.Button();
            this.gbOrderComp = new System.Windows.Forms.GroupBox();
            this.dgOrderComp = new System.Windows.Forms.DataGridView();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.tbpgtec = new System.Windows.Forms.TabPage();
            this.btTecAdd = new System.Windows.Forms.Button();
            this.nudTecEfficiency = new System.Windows.Forms.NumericUpDown();
            this.lbltecEfficiency = new System.Windows.Forms.Label();
            this.tbTecAbout = new System.Windows.Forms.TextBox();
            this.lblTecAbout = new System.Windows.Forms.Label();
            this.tbTecName = new System.Windows.Forms.TextBox();
            this.lblTecName = new System.Windows.Forms.Label();
            this.dgTec = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.gbClient.SuspendLayout();
            this.tbctrlClient.SuspendLayout();
            this.tbpgOrder.SuspendLayout();
            this.gbOrderComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderComp)).BeginInit();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.tbpgtec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTecEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTec)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btDrawback);
            this.gbClient.Controls.Add(this.btAccept);
            this.gbClient.Controls.Add(this.tbConfirm);
            this.gbClient.Controls.Add(this.lblConfirm);
            this.gbClient.Controls.Add(this.tbPassword);
            this.gbClient.Controls.Add(this.lblPassword);
            this.gbClient.Controls.Add(this.tbLogin);
            this.gbClient.Controls.Add(this.lblLogin);
            this.gbClient.Controls.Add(this.tbClient);
            this.gbClient.Controls.Add(this.lblClient);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbClient.Location = new System.Drawing.Point(0, 0);
            this.gbClient.Margin = new System.Windows.Forms.Padding(5);
            this.gbClient.Name = "gbClient";
            this.gbClient.Padding = new System.Windows.Forms.Padding(5);
            this.gbClient.Size = new System.Drawing.Size(725, 344);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Личные данные";
            // 
            // btDrawback
            // 
            this.btDrawback.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDrawback.Location = new System.Drawing.Point(614, 272);
            this.btDrawback.Name = "btDrawback";
            this.btDrawback.Size = new System.Drawing.Size(106, 67);
            this.btDrawback.TabIndex = 9;
            this.btDrawback.Text = "Откатить";
            this.btDrawback.UseVisualStyleBackColor = true;
            this.btDrawback.Click += new System.EventHandler(this.BtDrawback_Click);
            // 
            // btAccept
            // 
            this.btAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAccept.Location = new System.Drawing.Point(5, 272);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(128, 67);
            this.btAccept.TabIndex = 8;
            this.btAccept.Text = "Подтвердить";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // tbConfirm
            // 
            this.tbConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfirm.Location = new System.Drawing.Point(5, 238);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(715, 34);
            this.tbConfirm.TabIndex = 7;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirm.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.lblConfirm.Location = new System.Drawing.Point(5, 212);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(239, 26);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Подтверждение пароля";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(5, 178);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(715, 34);
            this.tbPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.lblPassword.Location = new System.Drawing.Point(5, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 26);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(5, 118);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(715, 34);
            this.tbLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.lblLogin.Location = new System.Drawing.Point(5, 92);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(72, 26);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // tbClient
            // 
            this.tbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(5, 58);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(715, 34);
            this.tbClient.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.lblClient.Location = new System.Drawing.Point(5, 32);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(62, 26);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "ФИО";
            // 
            // tbctrlClient
            // 
            this.tbctrlClient.Controls.Add(this.tbpgOrder);
            this.tbctrlClient.Controls.Add(this.tbpgtec);
            this.tbctrlClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbctrlClient.Location = new System.Drawing.Point(0, 344);
            this.tbctrlClient.Name = "tbctrlClient";
            this.tbctrlClient.SelectedIndex = 0;
            this.tbctrlClient.Size = new System.Drawing.Size(725, 416);
            this.tbctrlClient.TabIndex = 1;
            // 
            // tbpgOrder
            // 
            this.tbpgOrder.Controls.Add(this.btOrderAdd);
            this.tbpgOrder.Controls.Add(this.gbOrderComp);
            this.tbpgOrder.Controls.Add(this.gbOrder);
            this.tbpgOrder.Location = new System.Drawing.Point(4, 35);
            this.tbpgOrder.Name = "tbpgOrder";
            this.tbpgOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgOrder.Size = new System.Drawing.Size(717, 335);
            this.tbpgOrder.TabIndex = 0;
            this.tbpgOrder.Text = "Заказы";
            this.tbpgOrder.UseVisualStyleBackColor = true;
            // 
            // btOrderAdd
            // 
            this.btOrderAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOrderAdd.Location = new System.Drawing.Point(448, 297);
            this.btOrderAdd.Name = "btOrderAdd";
            this.btOrderAdd.Size = new System.Drawing.Size(266, 35);
            this.btOrderAdd.TabIndex = 2;
            this.btOrderAdd.Text = "Добавить заказ";
            this.btOrderAdd.UseVisualStyleBackColor = true;
            this.btOrderAdd.Click += new System.EventHandler(this.BtOrderAdd_Click);
            // 
            // gbOrderComp
            // 
            this.gbOrderComp.Controls.Add(this.dgOrderComp);
            this.gbOrderComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOrderComp.Location = new System.Drawing.Point(448, 3);
            this.gbOrderComp.Name = "gbOrderComp";
            this.gbOrderComp.Size = new System.Drawing.Size(266, 294);
            this.gbOrderComp.TabIndex = 1;
            this.gbOrderComp.TabStop = false;
            this.gbOrderComp.Text = "Состав заказа";
            // 
            // dgOrderComp
            // 
            this.dgOrderComp.AllowUserToAddRows = false;
            this.dgOrderComp.AllowUserToDeleteRows = false;
            this.dgOrderComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderComp.Location = new System.Drawing.Point(3, 30);
            this.dgOrderComp.Name = "dgOrderComp";
            this.dgOrderComp.ReadOnly = true;
            this.dgOrderComp.RowHeadersWidth = 51;
            this.dgOrderComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderComp.Size = new System.Drawing.Size(260, 261);
            this.dgOrderComp.TabIndex = 1;
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.dgOrder);
            this.gbOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOrder.Location = new System.Drawing.Point(3, 3);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(445, 329);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Ваши заказы";
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.AllowUserToDeleteRows = false;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrder.Location = new System.Drawing.Point(3, 30);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(439, 296);
            this.dgOrder.TabIndex = 0;
            this.dgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellClick);
            this.dgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellClick);
            // 
            // tbpgtec
            // 
            this.tbpgtec.Controls.Add(this.btTecAdd);
            this.tbpgtec.Controls.Add(this.nudTecEfficiency);
            this.tbpgtec.Controls.Add(this.lbltecEfficiency);
            this.tbpgtec.Controls.Add(this.tbTecAbout);
            this.tbpgtec.Controls.Add(this.lblTecAbout);
            this.tbpgtec.Controls.Add(this.tbTecName);
            this.tbpgtec.Controls.Add(this.lblTecName);
            this.tbpgtec.Controls.Add(this.dgTec);
            this.tbpgtec.Location = new System.Drawing.Point(4, 35);
            this.tbpgtec.Name = "tbpgtec";
            this.tbpgtec.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgtec.Size = new System.Drawing.Size(717, 377);
            this.tbpgtec.TabIndex = 1;
            this.tbpgtec.Text = "Технологии";
            this.tbpgtec.UseVisualStyleBackColor = true;
            // 
            // btTecAdd
            // 
            this.btTecAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTecAdd.Location = new System.Drawing.Point(3, 342);
            this.btTecAdd.Name = "btTecAdd";
            this.btTecAdd.Size = new System.Drawing.Size(711, 31);
            this.btTecAdd.TabIndex = 8;
            this.btTecAdd.Text = "Добавить";
            this.btTecAdd.UseVisualStyleBackColor = true;
            this.btTecAdd.Click += new System.EventHandler(this.BtTecAdd_Click);
            // 
            // nudTecEfficiency
            // 
            this.nudTecEfficiency.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTecEfficiency.Location = new System.Drawing.Point(3, 308);
            this.nudTecEfficiency.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTecEfficiency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTecEfficiency.Name = "nudTecEfficiency";
            this.nudTecEfficiency.ReadOnly = true;
            this.nudTecEfficiency.Size = new System.Drawing.Size(711, 34);
            this.nudTecEfficiency.TabIndex = 7;
            this.nudTecEfficiency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltecEfficiency
            // 
            this.lbltecEfficiency.AutoSize = true;
            this.lbltecEfficiency.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltecEfficiency.Location = new System.Drawing.Point(3, 281);
            this.lbltecEfficiency.Name = "lbltecEfficiency";
            this.lbltecEfficiency.Size = new System.Drawing.Size(145, 27);
            this.lbltecEfficiency.TabIndex = 6;
            this.lbltecEfficiency.Text = "Потребление";
            // 
            // tbTecAbout
            // 
            this.tbTecAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTecAbout.Location = new System.Drawing.Point(3, 247);
            this.tbTecAbout.Name = "tbTecAbout";
            this.tbTecAbout.Size = new System.Drawing.Size(711, 34);
            this.tbTecAbout.TabIndex = 5;
            // 
            // lblTecAbout
            // 
            this.lblTecAbout.AutoSize = true;
            this.lblTecAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTecAbout.Location = new System.Drawing.Point(3, 220);
            this.lblTecAbout.Name = "lblTecAbout";
            this.lblTecAbout.Size = new System.Drawing.Size(114, 27);
            this.lblTecAbout.TabIndex = 4;
            this.lblTecAbout.Text = "Описание";
            // 
            // tbTecName
            // 
            this.tbTecName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTecName.Location = new System.Drawing.Point(3, 186);
            this.tbTecName.Name = "tbTecName";
            this.tbTecName.Size = new System.Drawing.Size(711, 34);
            this.tbTecName.TabIndex = 3;
            // 
            // lblTecName
            // 
            this.lblTecName.AutoSize = true;
            this.lblTecName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTecName.Location = new System.Drawing.Point(3, 159);
            this.lblTecName.Name = "lblTecName";
            this.lblTecName.Size = new System.Drawing.Size(108, 27);
            this.lblTecName.TabIndex = 2;
            this.lblTecName.Text = "Название";
            // 
            // dgTec
            // 
            this.dgTec.AllowUserToAddRows = false;
            this.dgTec.AllowUserToDeleteRows = false;
            this.dgTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTec.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTec.Location = new System.Drawing.Point(3, 3);
            this.dgTec.Name = "dgTec";
            this.dgTec.ReadOnly = true;
            this.dgTec.RowHeadersWidth = 51;
            this.dgTec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTec.Size = new System.Drawing.Size(711, 156);
            this.dgTec.TabIndex = 1;
            this.dgTec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTec_CellClick);
            this.dgTec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTec_CellClick);
            // 
            // btExit
            // 
            this.btExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btExit.Location = new System.Drawing.Point(0, 765);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(725, 30);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выйти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // Client_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 795);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbctrlClient);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Client_Interface";
            this.Text = "Интерфейс клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClInterface_FormClosing);
            this.Load += new System.EventHandler(this.Client_Interface_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.tbctrlClient.ResumeLayout(false);
            this.tbpgOrder.ResumeLayout(false);
            this.gbOrderComp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderComp)).EndInit();
            this.gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.tbpgtec.ResumeLayout(false);
            this.tbpgtec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTecEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TabControl tbctrlClient;
        private System.Windows.Forms.TabPage tbpgOrder;
        private System.Windows.Forms.TabPage tbpgtec;
        private System.Windows.Forms.Button btDrawback;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btOrderAdd;
        private System.Windows.Forms.GroupBox gbOrderComp;
        private System.Windows.Forms.DataGridView dgOrderComp;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Button btTecAdd;
        private System.Windows.Forms.NumericUpDown nudTecEfficiency;
        private System.Windows.Forms.Label lbltecEfficiency;
        private System.Windows.Forms.TextBox tbTecAbout;
        private System.Windows.Forms.Label lblTecAbout;
        private System.Windows.Forms.TextBox tbTecName;
        private System.Windows.Forms.Label lblTecName;
        private System.Windows.Forms.DataGridView dgTec;
        private System.Windows.Forms.Button btExit;
    }
}