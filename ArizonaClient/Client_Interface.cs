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
using ParawosoffCrypt;
using System.Security.Cryptography;

namespace ArizonaClient
{
    public partial class Client_Interface : Form
    {
        public Client_Interface()
        {
            InitializeComponent();
        }

        private void ClInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Arizona Client", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    Application.ExitThread();
                    break;
                case (DialogResult.No):
                    e.Cancel = true;
                    break;
                case (DialogResult.Cancel):
                    this.Hide();
                    this.Owner.Show();
                    break;
            }
        }

        char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] ruLetters = new char[66] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        private void BtClose_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите выйти на страницу авторизации?", "Arizona Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    this.Hide();
                    this.Owner.Show();
                    break;
            }
        }

        string Password = "";
        string Login = "";
        private void ClMainLoad()
        {
            Action action = () =>
            {
                Table_Class tableClient = new Table_Class(String.Format("SELECT [Client_Face_Firstname] + [Client_Face_Name] + [Client_Face_Patronymic] +\'(\' + (select [Client_Name] from [dbo].[Client] where [ID_Client] = [Client_ID]) +\')\',[Client_Face_Adress],[Client_Face_Password] FROM [dbo].[Client_Face] WHERE [ID_Client_Face] = {0}",Program.intID));
                tbClient.Text = tableClient.table.Rows[0][0].ToString();
                try
                {
                    DES des = DES.Create();
                    byte[] key = Convert.FromBase64String("ybqAS+sVBLY=");
                    byte[] IV = Convert.FromBase64String("1mbClpyz5bU=");
                    des.Key = key;
                    des.IV = IV;
                    string loginout = Crypt_Class.SymmetricDecrypt(Convert.FromBase64String(tableClient.table.Rows[0][1].ToString()), des);
                    string passwdout = Crypt_Class.SymmetricDecrypt(Convert.FromBase64String(tableClient.table.Rows[0][2].ToString()), des);
                    tbLogin.Text = loginout;
                    tbPassword.Clear();
                    tbConfirm.Clear();
                    Login = loginout;
                    Password = passwdout;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OrderLoad()
        {
            Action action = () =>
            {
                Table_Class tableOrder = new Table_Class(String.Format("SELECT [ID_Order] as \'Код\',[Order_Start_Date] as \'С\',[Order_End_Date] as \'По\',(select [OrderStatus_Name] from [dbo].[OrderState] where [ID_OrderStatus] = [OrderStatus_ID]) as \'Статус\' FROM [dbo].[Order] WHERE [Client_Face_ID] = {0}", Program.intID));
                tableOrder.Dependency.OnChange += OrderDependency_OnChange;
                dgOrder.DataSource = tableOrder.table;
            };
            Invoke(action);
        }

        private void OrderDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                OrderLoad();
        }

        private void TecLoad()
        {
            Action action = () =>
            {
                Table_Class tableTec = new Table_Class("SELECT [ID_Tec] as \'Кодовый номер\',[Tec_Name] as \'Название\',[Tec_Efficiency] as \'Затраты\',[Tec_About] as \'Описание\',(select [TecStatus_Name] from [dbo].[TecState] Where [ID_TecStatus] = [TecStatus_ID]) as \'Статус\' FROM [dbo].[Tecnology]");
                tableTec.Dependency.OnChange += tecDependency_OnChange;
                dgTec.DataSource = tableTec.table;
            };
            Invoke(action);
        }

        string SelectedTec = "";

        private void TecFieldLoad()
        {
            Action action = () =>
            {
                if (SelectedTec != "")
                {
                    Table_Class tableTecField = new Table_Class(String.Format("SELECT [Tec_Name],[Tec_Efficiency],[Tec_About] FROM [dbo].[Tecnology] WHERE [ID_Tec] = {0}", SelectedTec));
                    tbTecName.Text = tableTecField.table.Rows[0][0].ToString();
                    nudTecEfficiency.Value = Convert.ToInt32(tableTecField.table.Rows[0][1].ToString());
                    tbTecAbout.Text = tableTecField.table.Rows[0][2].ToString();
                }
            };
            Invoke(action);
        }

        private void tecDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                TecLoad();
        }

        private void Client_Interface_Load(object sender, EventArgs e)
        {
            Thread clLoad = new Thread(ClMainLoad);
            clLoad.Start();
            Thread orLoad = new Thread(OrderLoad);
            orLoad.Start();
            Thread tecLoad = new Thread(TecLoad);
            tecLoad.Start();
        }

        public void OrderLoadPub()
        {
            Thread orLoad = new Thread(OrderLoad);
            orLoad.Start();
        }

        private void BtDrawback_Click(object sender, EventArgs e)
        {
            Thread clLoad = new Thread(ClMainLoad);
            clLoad.Start();
        }

        private void BtAccept_Click(object sender, EventArgs e)
        {
            Thread clUpdate = new Thread(ClReg);
            clUpdate.Start();
        }

        private void ClReg()
        {
            Action action = () =>
            {
                if ((tbLogin.Text.Length == 0) | (tbLogin.Text.IndexOf('@') == -1) | (tbLogin.Text.IndexOf('.') == -1) | (tbLogin.Text.IndexOf('@') > tbLogin.Text.IndexOf('.')))
                    tbLogin.BackColor = Color.Red;
                else
                {
                    tbLogin.BackColor = Color.White;
                    ArrayList Checkarray = new ArrayList();
                    DES des = DES.Create();
                    byte[] key = Convert.FromBase64String("ybqAS+sVBLY=");
                    byte[] IV = Convert.FromBase64String("1mbClpyz5bU=");
                    des.Key = key;
                    des.IV = IV;
                    byte[] login = Crypt_Class.SymmetricEncrypt(tbLogin.Text, des);
                    Checkarray.Add("\'" + Convert.ToBase64String(login) + "\'");
                    Function_class UQCheck = new Function_class("Client_Face_Adress_UQ_Check", Function_class.Function_Result.scalar, Checkarray);
                    if ((UQCheck.Regtable.Rows[0][0].ToString() == "False")&(tbLogin.Text == Login))
                        tbLogin.BackColor = Color.Red;
                    else
                    {
                        tbLogin.BackColor = Color.White;
                        if ((tbPassword.Text.Length < 6) | (tbPassword.Text.IndexOfAny(numbers) == -1) | (tbPassword.Text.IndexOfAny(ruLetters) != -1) | (tbPassword.Text != tbConfirm.Text))
                        {
                            tbPassword.BackColor = Color.Red;
                            if ((tbPassword.Text == tbConfirm.Text)&((tbPassword.Text == Password)|(tbPassword.Text != "")))
                            {
                                tbPassword.BackColor = Color.White;
                                ArrayList array = new ArrayList();
                                array.Add(Program.intID);
                                Table_Class tableClient = new Table_Class(String.Format("SELECT [Client_Face_Name],[Client_Face_Firstname],[Client_Face_Patronymic],[Client_ID] FROM [dbo].[Client_Face] WHERE [ID_Client_Face] = {0}", Program.intID));
                                array.Add(tableClient.table.Rows[0][0].ToString());
                                array.Add(tableClient.table.Rows[0][1].ToString());
                                array.Add(tableClient.table.Rows[0][2].ToString());
                                DES indes = DES.Create();
                                byte[] inkey = Convert.FromBase64String("ybqAS+sVBLY=");
                                byte[] inIV = Convert.FromBase64String("1mbClpyz5bU=");
                                indes.Key = inkey;
                                indes.IV = inIV;
                                byte[] inlogin = Crypt_Class.SymmetricEncrypt(tbLogin.Text, indes);
                                byte[] inpasswd = Crypt_Class.SymmetricEncrypt(Password, indes);
                                array.Add(Convert.ToBase64String(inlogin));
                                array.Add(Convert.ToBase64String(inpasswd));
                                array.Add(tableClient.table.Rows[0][3].ToString());
                                array.Add("0");
                                Procedure_Class procedure = new Procedure_Class();
                                procedure.procedure_Execution("Client_Face_Update", array);
                                ClMainLoad();
                            }
                        }
                        else
                        {
                            tbPassword.BackColor = Color.White;
                            ArrayList array = new ArrayList();
                            array.Add(Program.intID);
                            Table_Class tableClient = new Table_Class(String.Format("SELECT [Client_Face_Name],[Client_Face_Firstname],[Client_Face_Patronymic],[Client_ID] FROM [dbo].[Client_Face] WHERE [ID_Client_Face] = {0}", Program.intID));
                            array.Add(tableClient.table.Rows[0][0].ToString());
                            array.Add(tableClient.table.Rows[0][1].ToString());
                            array.Add(tableClient.table.Rows[0][2].ToString());
                            DES indes = DES.Create();
                            byte[] inkey = Convert.FromBase64String("ybqAS+sVBLY=");
                            byte[] inIV = Convert.FromBase64String("1mbClpyz5bU=");
                            indes.Key = inkey;
                            indes.IV = inIV;
                            byte[] inlogin = Crypt_Class.SymmetricEncrypt(tbLogin.Text, indes);
                            byte[] inpasswd = Crypt_Class.SymmetricEncrypt(tbPassword.Text, indes);
                            array.Add(Convert.ToBase64String(inlogin));
                            array.Add(Convert.ToBase64String(inpasswd));
                            array.Add(tableClient.table.Rows[0][3].ToString());
                            array.Add("0");
                            Procedure_Class procedure = new Procedure_Class();
                            procedure.procedure_Execution("Client_Face_Update", array);
                            ClMainLoad();
                        }
                    }
                }
            };
            Invoke(action);
        }
        string SelectedOrder = "";
        private void DgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedOrder = dgOrder.Rows[dgOrder.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                SelectedOrder = "";
            }
            finally
            {
                OrderCompLoad();
            }
        }

        private void OrderCompLoad()
        {
            Action action = () =>
            {
                if (SelectedOrder != "")
                {
                    Table_Class tableOrderComp = new Table_Class(String.Format("SELECT dbo.Order_Comp.ID_Order_Comp AS 'Код', dbo.Order_Comp.Product_Amount AS 'Количество', dbo.Raw.Raw_Name AS 'Сырьё', dbo.Tecnology.Tec_Name AS 'Технология', dbo.[Order].Order_Start_Date AS 'Дата начала', dbo.[Order].Order_End_Date AS 'Дата конца проекта' FROM dbo.[Order] INNER JOIN dbo.Order_Comp ON dbo.[Order].ID_Order = dbo.Order_Comp.Order_ID INNER JOIN dbo.Product ON dbo.Order_Comp.Product_ID = dbo.Product.ID_Product INNER JOIN dbo.Raw ON dbo.Product.Raw_ID = dbo.Raw.ID_Raw INNER JOIN dbo.Tecnology ON dbo.Product.Tec_ID = dbo.Tecnology.ID_Tec WHERE [dbo].[Order_Comp].[Order_ID] = {0}", SelectedOrder));
                    dgOrderComp.DataSource = tableOrderComp.table;
                }
            };
            Invoke(action);
        }

        private void DgTec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedTec = dgTec.Rows[dgTec.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                SelectedTec = "";
            }
            finally
            {
                TecFieldLoad();
            }
        }

        private void BtTecAdd_Click(object sender, EventArgs e)
        {
            Thread tecAdd = new Thread(TecAdd);
            tecAdd.Start();
        }

        private void TecAdd()
        {
            Action action = () =>
            {
                if (tbTecName.Text.Length == 0)
                    tbTecName.BackColor = Color.Red;
                else
                {
                    tbTecName.BackColor = Color.White;
                    ArrayList Checkarray = new ArrayList();
                    Checkarray.Add("\'" + tbTecName.Text + "\'");
                    Function_class UQCheck = new Function_class("Tec_Name_UQ_Check", Function_class.Function_Result.scalar, Checkarray);
                    if (UQCheck.Regtable.Rows[0][0].ToString() == "False")
                        MessageBox.Show("Технология с таким названием уже существует!", "Arizona Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        ArrayList array = new ArrayList();
                        Procedure_Class tecInsert = new Procedure_Class();
                        array.Add(tbTecName.Text);
                        array.Add(nudTecEfficiency.Value.ToString());
                        array.Add(tbTecAbout.Text);
                        tecInsert.procedure_Execution("Tec_Insert", array);
                        TecLoad();
                    }
                }
            };
            Invoke(action);
        }

        private void BtOrderAdd_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            orderAdd.Owner = this;
            orderAdd.Show();
        }
    }
}
