using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.Sql;
using System.Data.SqlClient;
using ArizonaClient;
using System.Collections;
using ParawosoffCrypt;
using System.Security.Cryptography;

namespace ArizonaClient
{
    public partial class Autorization_Form : Form
    {
        public Autorization_Form()
        {
            InitializeComponent();
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            //Проверка
            switch (tbUserLogin.Text == "")
            {
                case true:
                    tbUserLogin.BackColor = Color.Red;
                    break;
                case false:
                    tbUserLogin.BackColor = Color.White;
                    switch (tbUserPassword.Text == "")
                    {
                        case true:
                            tbUserPassword.BackColor = Color.Red;
                            break;
                        case false:
                            //Авторизация
                            tbUserPassword.BackColor = Color.White;
                            ArrayList AutorizData = new ArrayList();
                            DES des = DES.Create();
                            byte[] key = Convert.FromBase64String("ybqAS+sVBLY=");
                            byte[] IV = Convert.FromBase64String("1mbClpyz5bU=");
                            des.Key = key;
                            des.IV = IV;
                            byte[] login = Crypt_Class.SymmetricEncrypt(tbUserLogin.Text, des);
                            byte[] passwd = Crypt_Class.SymmetricEncrypt(tbUserPassword.Text, des);
                            AutorizData.Add("\'"+Convert.ToBase64String(login)+ "\'" );
                            AutorizData.Add("\'" + Convert.ToBase64String(passwd)+ "\'" );
                            tbUserLogin.Clear();
                            tbUserPassword.Clear();
                            Function_class function = new Function_class("Authorization", Function_class.Function_Result.table, AutorizData);
                            if (function.Regtable.Rows.Count>0)
                            {
                                if ((function.Regtable.Rows[0][2].ToString() == "False") & (function.Regtable.Rows[0][3].ToString() == "False"))
                                {
                                    Program.intID = function.Regtable.Rows[0][0].ToString();
                                    Client_Interface client_Interface = new Client_Interface();
                                    client_Interface.Owner = this;
                                    client_Interface.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Данный пользователь не найден. Пожалуйста, зарегестрируйтесь или введите правильные данные для продолжения.", "Arizona Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Данный пользователь не найден. Пожалуйста, зарегестрируйтесь или введите правильные данные для продолжения.", "Arizona Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                    }
                    break;
            }
        }

        private void BtLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtReg_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Owner = this;
            registration_Form.Show();
            this.Hide();
        }

        private void Autorization_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите закрыть приложение?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    Application.ExitThread();
                    break;
            }
        }
    }
}
