namespace ArizonaClient
{
    partial class OrderAdd
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btAddToOrder = new System.Windows.Forms.Button();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.dgOrderList = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btCountDates = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(86, 27);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Товары";
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgProduct.Location = new System.Drawing.Point(0, 27);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduct.Size = new System.Drawing.Size(576, 156);
            this.dgProduct.TabIndex = 2;
            this.dgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProduct_CellContentClick);
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProduct_CellContentClick);
            // 
            // btAddToOrder
            // 
            this.btAddToOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddToOrder.Enabled = false;
            this.btAddToOrder.Location = new System.Drawing.Point(0, 183);
            this.btAddToOrder.Name = "btAddToOrder";
            this.btAddToOrder.Size = new System.Drawing.Size(576, 32);
            this.btAddToOrder.TabIndex = 3;
            this.btAddToOrder.Text = "Добавить к заказу";
            this.btAddToOrder.UseVisualStyleBackColor = true;
            this.btAddToOrder.Click += new System.EventHandler(this.BtAddToOrder_Click);
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderList.Location = new System.Drawing.Point(0, 215);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(67, 27);
            this.lblOrderList.TabIndex = 4;
            this.lblOrderList.Text = "Заказ";
            // 
            // dgOrderList
            // 
            this.dgOrderList.AllowUserToAddRows = false;
            this.dgOrderList.AllowUserToDeleteRows = false;
            this.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgOrderList.Location = new System.Drawing.Point(0, 242);
            this.dgOrderList.Name = "dgOrderList";
            this.dgOrderList.ReadOnly = true;
            this.dgOrderList.RowHeadersWidth = 51;
            this.dgOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderList.Size = new System.Drawing.Size(576, 156);
            this.dgOrderList.TabIndex = 5;
            this.dgOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrderList_CellClick);
            this.dgOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrderList_CellClick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCount.Location = new System.Drawing.Point(0, 398);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(205, 27);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Количество товара";
            // 
            // nudCount
            // 
            this.nudCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudCount.Location = new System.Drawing.Point(0, 425);
            this.nudCount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.ReadOnly = true;
            this.nudCount.Size = new System.Drawing.Size(576, 34);
            this.nudCount.TabIndex = 7;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Enabled = false;
            this.btUpdate.Location = new System.Drawing.Point(0, 459);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(576, 31);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Изменить количество товара";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(0, 490);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(576, 29);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Удалить из заказа";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStart.Location = new System.Drawing.Point(0, 519);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(134, 27);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Дата начала";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Location = new System.Drawing.Point(0, 546);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(671, 27);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Минимальная дата = 01.01.0001, Оптимальная дата = 01.01.0001";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEnd.Location = new System.Drawing.Point(0, 634);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(576, 34);
            this.dtpEnd.TabIndex = 19;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnd.Location = new System.Drawing.Point(0, 607);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(173, 27);
            this.lblEnd.TabIndex = 18;
            this.lblEnd.Text = "Дата окончания";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpStart.Location = new System.Drawing.Point(0, 573);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(576, 34);
            this.dtpStart.TabIndex = 17;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // btCountDates
            // 
            this.btCountDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCountDates.Location = new System.Drawing.Point(0, 668);
            this.btCountDates.Name = "btCountDates";
            this.btCountDates.Size = new System.Drawing.Size(576, 31);
            this.btCountDates.TabIndex = 20;
            this.btCountDates.Text = "Рассчитать";
            this.btCountDates.UseVisualStyleBackColor = true;
            this.btCountDates.Click += new System.EventHandler(this.BtCountDates_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCancel.Location = new System.Drawing.Point(0, 730);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(576, 34);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "Отменить заказ";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // btAccept
            // 
            this.btAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAccept.Enabled = false;
            this.btAccept.Location = new System.Drawing.Point(0, 699);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(576, 31);
            this.btAccept.TabIndex = 22;
            this.btAccept.Text = "Добавить заказ";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 716);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.btCountDates);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgOrderList);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.btAddToOrder);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.lblProduct);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderAdd";
            this.Text = "Добавление заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderAdd_FormClosing);
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btAddToOrder;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.DataGridView dgOrderList;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btCountDates;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
    }
}