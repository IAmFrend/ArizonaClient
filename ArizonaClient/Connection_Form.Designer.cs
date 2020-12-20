namespace ArizonaClient
{
    partial class Connection_Form
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
            this.lbServer = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.btChecked = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbServer.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbServer.Location = new System.Drawing.Point(0, 0);
            this.lbServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(96, 31);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Сервер";
            // 
            // cbServer
            // 
            this.cbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServer.Enabled = false;
            this.cbServer.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(0, 31);
            this.cbServer.Margin = new System.Windows.Forms.Padding(4);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(696, 39);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.CbServer_SelectedIndexChanged);
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDatabase.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbDatabase.Location = new System.Drawing.Point(0, 70);
            this.lbDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(157, 31);
            this.lbDatabase.TabIndex = 2;
            this.lbDatabase.Text = "База данных";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabase.Enabled = false;
            this.cbDatabase.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(0, 101);
            this.cbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(696, 39);
            this.cbDatabase.TabIndex = 3;
            // 
            // btChecked
            // 
            this.btChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChecked.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btChecked.Location = new System.Drawing.Point(0, 140);
            this.btChecked.Margin = new System.Windows.Forms.Padding(4);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(228, 105);
            this.btChecked.TabIndex = 4;
            this.btChecked.Text = "Проверить";
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Click += new System.EventHandler(this.BtChecked_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btCancel.Location = new System.Drawing.Point(468, 140);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(228, 105);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Enabled = false;
            this.btConnect.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btConnect.Location = new System.Drawing.Point(228, 140);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(240, 105);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Подключить";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 245);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChecked);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.lbServer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connection_Form";
            this.Text = "Соединение с сервером";
            this.Load += new System.EventHandler(this.Connection_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnect;
    }
}