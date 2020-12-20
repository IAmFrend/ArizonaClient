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
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
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
        char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] ruLetters = new char[66] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        private void BtReg_Click(object sender, EventArgs e)
        {
            Thread reg = new Thread(ClReg);
            reg.Start();
        }

        private void ClReg()
        {
            Action action = () =>
            {
                if (tbFirstname.Text.Length == 0)
                    tbFirstname.BackColor = Color.Red;
                else
                {
                    tbFirstname.BackColor = Color.White;
                    if (tbName.Text.Length == 0)
                        tbName.BackColor = Color.Red;
                    else
                    {
                        tbName.BackColor = Color.White;
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
                            if (UQCheck.Regtable.Rows[0][0].ToString() == "False")
                                tbLogin.BackColor = Color.Red;
                            else
                            {
                                tbLogin.BackColor = Color.White;
                                if ((tbPassword.Text.Length < 6) | (tbPassword.Text.IndexOfAny(numbers) == -1) | (tbPassword.Text.IndexOfAny(ruLetters) != -1) | (tbPassword.Text != tbConfirm.Text))
                                    tbPassword.BackColor = Color.Red;
                                else
                                {
                                    tbPassword.BackColor = Color.Red;
                                    ArrayList array = new ArrayList();
                                    array.Add(tbName.Text);
                                    array.Add(tbFirstname.Text);
                                    array.Add(tbPatronymic.Text);
                                    DES indes = DES.Create();
                                    byte[] inkey = Convert.FromBase64String("ybqAS+sVBLY=");
                                    byte[] inIV = Convert.FromBase64String("1mbClpyz5bU=");
                                    indes.Key = inkey;
                                    indes.IV = inIV;
                                    byte[] inlogin = Crypt_Class.SymmetricEncrypt(tbLogin.Text, indes);
                                    byte[] inpasswd = Crypt_Class.SymmetricEncrypt(tbPassword.Text, indes);
                                    array.Add(Convert.ToBase64String(inlogin));
                                    array.Add(Convert.ToBase64String(inpasswd));
                                    array.Add(cbClient.SelectedValue);
                                    array.Add("0");
                                    Procedure_Class procedure = new Procedure_Class();
                                    procedure.procedure_Execution("Client_Face_Insert", array);
                                    this.Hide();
                                    this.Owner.Show();
                                }
                            }
                        }
                    }
                }
            };
            Invoke(action);
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            Thread startup = new Thread(ClLoad);
            startup.Start();
        }

        private void ClLoad()
        {
            Action action = () =>
            {
                Table_Class tableClient = new Table_Class("SELECT [ID_Client],[Client_Name] FROM [dbo].[Client] WHERE [Client_Logical_Delete] = 0");
                tableClient.Dependency.OnChange += Dependency_OnChange;
                cbClient.DataSource = tableClient.table;
                cbClient.ValueMember = "ID_Client";
                cbClient.DisplayMember = "Client_Name";
            };
            Invoke(action);
        }

        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                ClLoad();
        }
    }
}
