using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace ArizonaClient
{
    public partial class OrderAdd : Form
    {

        DataTable orderList = new DataTable("Order List");
        DataColumn ID = new DataColumn();
        DataColumn PrName = new DataColumn();
        DataColumn Amount = new DataColumn();
        public OrderAdd()
        {
            InitializeComponent();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите выйти на страницу клиента?", "Arizona Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    this.Hide();
                    this.Owner.Focus();
                    break;
            }
        }

        private void OrderAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите выйти на страницу клиента?", "Arizona Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    this.Hide();
                    this.Owner.Focus();
                    break;
            }
        }

        private void ProductLoad()
        {
            Action action = () =>
            {
                Table_Class tableOrder = new Table_Class("SELECT dbo.Product.ID_Product as \'Артикул\', dbo.Product.Product_Current_Amount as \'Остаток на складе\', dbo.Product.Product_Reserved as \'Зарезервировано\', dbo.[Raw].Raw_Name as \'Сырьё\', dbo.Tecnology.Tec_Name as \'Технология\' FROM dbo.Product INNER JOIN dbo.[Raw] ON dbo.Product.Raw_ID = dbo.[Raw].ID_Raw INNER JOIN dbo.Tecnology ON dbo.Product.Tec_ID = dbo.Tecnology.ID_Tec WHERE [ID_Product]>0 AND [Product_Logical_Delete] = 0");
                dgProduct.DataSource = tableOrder.table;
            };
            Invoke(action);
        }


        private void OrderAdd_Load(object sender, EventArgs e)
        {
            Thread prLoad = new Thread(ProductLoad);
            prLoad.Start();
            ID.DataType = System.Type.GetType("System.String");
            ID.AutoIncrement = false;
            ID.ColumnName = "Артикул";
            orderList.Columns.Add(ID);
            PrName.DataType = System.Type.GetType("System.String");
            PrName.ColumnName = "Название";
            orderList.Columns.Add(PrName);
            Amount.DataType = System.Type.GetType("System.Int32");
            Amount.ColumnName = "Количество";
            orderList.Columns.Add(Amount);
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(1);
        }

        string SelectedProduct = "";
        string SelectedProductName = "";
        string SelectedOrderItem = "";
        string SelectedOrderItemName = "";
        string SelectedOrderItemCount = "";

        private void DgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedProduct = dgProduct.Rows[dgProduct.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                SelectedProduct = "";
            }
            finally
            {
                SelectedProductName = dgProduct.Rows[dgProduct.SelectedCells[0].RowIndex].Cells[3].Value.ToString() + " - " + dgProduct.Rows[dgProduct.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                btAddToOrder.Enabled = true;
            }
        }

        private void BtAddToOrder_Click(object sender, EventArgs e)
        {
            Thread prAdd = new Thread(ProductAddToList);
            prAdd.Start();
            btAddToOrder.Enabled = false;
            btAccept.Enabled = false;

        }

        private void ProductAddToList()
        {
            Action action = () =>
            {
                if (orderList.Select(String.Format("Артикул = {0}", SelectedProduct)).Length == 0)
                {
                    DataRow row = orderList.NewRow();
                    row["Артикул"] = SelectedProduct;
                    row["Название"] = SelectedProductName;
                    row["Количество"] = Convert.ToInt32(nudCount.Value);
                    orderList.Rows.Add(row);
                    dgOrderList.DataSource = orderList;
                }
                else
                    MessageBox.Show("Этот товар уже добавлен!", "Arizona Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }

        private void ProductDelete()
        {
            Action action = () =>
            {
                if (SelectedOrderItem != "")
                {
                    DataRow row = orderList.Select(String.Format("Артикул = {0}", SelectedOrderItem))[0];
                    orderList.Rows.Remove(row);
                    dgOrderList.DataSource = orderList;
                    btDelete.Enabled = false;
                    btUpdate.Enabled = false;
                }
            };
            Invoke(action);
        }

        private void ProductUpdate()
        {
            Action action = () =>
            {
                if (SelectedOrderItem != "")
                {
                    DataRow row = orderList.Select(String.Format("Артикул = {0}", SelectedOrderItem))[0];
                    orderList.Rows.Remove(row);
                    row[0] = SelectedOrderItem;
                    row[1] = SelectedOrderItemName;
                    row[2] = nudCount.Value.ToString();
                    orderList.Rows.Add(row);
                    dgOrderList.DataSource = orderList;
                    btDelete.Enabled = false;
                    btUpdate.Enabled = false;
                }
            };
            Invoke(action);
        }

        private void OrderInsert()
        {
            Action action = () =>
            {
                if (orderList.Rows.Count>0)
                {
                    Table_Class before = new Table_Class("SELECT [ID_Order] FROM [dbo].[Order]");
                    ArrayList array = new ArrayList();
                    Table_Class client = new Table_Class(String.Format("SELECT [Client_ID] FROM [dbo].[Client_Face] WHERE [ID_Client_Face] = {0}", Program.intID));
                    string start = "";
                    if (dtpStart.Value.Day.ToString().Length > 1)
                        start += dtpStart.Value.Day.ToString();
                    else
                        start += "0"+dtpStart.Value.Day.ToString();
                    start += ".";
                    if (dtpStart.Value.Month.ToString().Length > 1)
                        start += dtpStart.Value.Month.ToString();
                    else
                        start += "0" + dtpStart.Value.Month.ToString();
                    start += ".";
                    start += dtpStart.Value.Year.ToString();
                    string end = "";
                    if (dtpEnd.Value.Day.ToString().Length > 1)
                        end += dtpEnd.Value.Day.ToString();
                    else
                        end += "0" + dtpEnd.Value.Day.ToString();
                    end += ".";
                    if (dtpEnd.Value.Month.ToString().Length > 1)
                        end += dtpEnd.Value.Month.ToString();
                    else
                        end += "0" + dtpEnd.Value.Month.ToString();
                    end += ".";
                    end += dtpEnd.Value.Year.ToString();
                    array.Add(start);
                    array.Add(end);
                    array.Add(client.table.Rows[0][0].ToString());
                    array.Add(Program.intID);
                    Procedure_Class insert = new Procedure_Class();
                    insert.procedure_Execution("Order_Insert", array);
                    Table_Class after = new Table_Class("SELECT [ID_Order] FROM [dbo].[Order]");
                    foreach (DataRow row in before.table.Rows)
                    {
                        DataRow deleterow = after.table.Select(String.Format("ID_Order = {0}", row[0]))[0];
                        after.table.Rows.Remove(deleterow);
                    }
                    foreach (DataRow row in orderList.Rows)
                    {
                        ArrayList insertComp = new ArrayList();
                        insertComp.Add(row[2]);
                        insertComp.Add(row[0]);
                        insertComp.Add(after.table.Rows[0][0].ToString());
                        Procedure_Class compinsert = new Procedure_Class();
                        compinsert.procedure_Execution("Order_Comp_Insert", insertComp);
                        insertComp.Clear();
                    }
                }
                else
                    MessageBox.Show("Добавьте товары к заказу!", "Arizona Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }

        private void DgOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedOrderItem = dgOrderList.Rows[dgOrderList.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                SelectedOrderItem = "";
            }
            finally
            {
                SelectedOrderItemName = dgOrderList.Rows[dgOrderList.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                SelectedOrderItemCount = dgOrderList.Rows[dgOrderList.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
                nudCount.Value = Convert.ToInt32(SelectedOrderItemCount);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Thread prDelete = new Thread(ProductDelete);
            prDelete.Start();
            btAccept.Enabled = false;

        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Thread prUpdate = new Thread(ProductUpdate);
            prUpdate.Start();
            btAccept.Enabled = false;

        }

        private void BtAccept_Click(object sender, EventArgs e)
        {
            Thread orderInsert = new Thread(OrderInsert);
            orderInsert.Start();
            (Owner as Client_Interface).OrderLoadPub();
            this.Hide();
            this.Owner.Focus();
        }

        DateTime min = DateTime.Now;
        DateTime max = DateTime.Now;

        private void GetDates()
        {
            Action action = () =>
            {
                if (orderList.Rows.Count > 0)
                {
                    min = dtpStart.Value;
                    max = dtpStart.Value;
                    foreach (DataRow row in orderList.Rows)
                    {
                        ArrayList mintime = new ArrayList();
                        mintime.Add(row[0]);
                        mintime.Add(row[2]);
                        Function_class minTimeCount = new Function_class("Order_Count_Check_MAX", Function_class.Function_Result.scalar, mintime);
                        Double minAdd = Convert.ToDouble(minTimeCount.Regtable.Rows[0][0]);
                        min=min.AddDays(minAdd);
                        mintime.Clear();
                    }
                    foreach (DataRow row in orderList.Rows)
                    {
                        ArrayList maxtime = new ArrayList();
                        maxtime.Add(row[0]);
                        maxtime.Add(row[2]);
                        Function_class maxTimeCount = new Function_class("Order_Count_Check_MIN", Function_class.Function_Result.scalar, maxtime);
                        max=max.AddDays(Convert.ToDouble(maxTimeCount.Regtable.Rows[0][0]));
                        maxtime.Clear();
                    }
                }
                lblDate.Text = String.Format("Минимальная дата = {0}, Оптимальная дата = {1}", (min.Day.ToString() + "." + min.Month.ToString() + "." + min.Year.ToString()), (max.Day.ToString() + "." + max.Month.ToString() + "." + max.Year.ToString()));
                dtpEnd.Value = min;
            };
            Invoke(action);
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
                dtpStart.Value = DateTime.Now;
            if (dtpStart.Value >= dtpEnd.Value)
                dtpEnd.Value = min;
            btAccept.Enabled = false;
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (min >= dtpEnd.Value)
                dtpEnd.Value = min;
        }

        private void BtCountDates_Click(object sender, EventArgs e)
        {
            GetDates();
            if (min >= dtpEnd.Value)
                dtpEnd.Value = min;
            btAccept.Enabled = true;
        }
    }
}
