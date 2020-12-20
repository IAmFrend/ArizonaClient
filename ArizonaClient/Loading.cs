using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Deployment.Application;

namespace ArizonaClient
{
    public partial class Loading : Form
    {
        int Loader = new int();
        
        [DllImport("wininet.dll")] private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
        [DllImport("kernel32.dll")] [return: MarshalAs(UnmanagedType.Bool)] static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKylobytes);
        public Loading()
        {
            SystemCheck();
            if (Startup)
            {
                InstallUpdateSyncWithInfo();
                InitializeComponent();
            }
            else
            {
                Close();
                Application.ExitThread();
            }
        }

        Boolean Startup = true;

        private void SystemCheck()
        {
            int Major = Environment.OSVersion.Version.Major;
            int Minor = Environment.OSVersion.Version.Minor;
            if ((Major >= 6) && (Minor >= 0))
            {
                RegistryKey registrySQL =
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                RegistryKey registryNET =
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\.NETFramework");
                RegistryKey registryExcel =
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\Excel");
                RegistryKey registryWord =
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\16.0\Word");
                RegistryKey registryEdge =
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\MicrosoftEdge");
                RegistryKey registryChrome =
                Registry.CurrentUser.OpenSubKey(@"Software\Google\Chrome");
                RegistryKey registryExplorer =
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer");

                RegistryKey freckey = Registry.LocalMachine;
                freckey = freckey.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0", false);
                string str = freckey.GetValue("~MHz").ToString();
                if (Convert.ToInt32(str) <= 1400)
                {
                    MessageBox.Show(String.Format("Данное приложение не может запуститься с такой тактовой частотой: {0}", str));
                    Startup = false;
                }

                GetSystemInfo();

                if (registrySQL == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует Microsoft SQL Server", "Paladin manager");
                    Startup = false;
                }
                else if (registryNET == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует .NETFramework", "Paladin manager");
                    Startup = false;
                }
                else if (registryExcel == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует Microsoft Excel", "Paladin manager");
                    Startup = false;
                }

                else if (registryWord == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует Microsoft Word", "Paladin manager");
                    Startup = false;
                }
                else if (registryEdge == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует Microsoft Edge", "Paladin manager");
                    Startup = false;
                }
                else if (registryChrome == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует брауер Google Chrome", "Paladin manager");
                    Startup = false;
                }
                else if (registryExplorer == null)
                {
                    MessageBox.Show("Запуск системы невозможен, в системе отсутствует брауер Internet Explorer", "Paladin manager");
                    Startup = false;
                }
            }
            else
            {
                MessageBox.Show("Данная операционная система не предназначена для запуска приложения!", "Paladin manager");
            }
        }
        void GetSystemInfo()
        {
            long memKb;
            GetPhysicallyInstalledSystemMemory(out memKb);
            memKb = memKb / 1024 / 1024;
            if (memKb < 4)
            {
                MessageBox.Show(String.Format("Данное приложение не запустится с таким количеством памяти ОЗУ: {0} Гб", memKb.ToString()));
                Startup = false;
            }
            if (IsConnectedToInternet() == false)
            {
                MessageBox.Show(String.Format("Отсутствует подключение к интернету"));
                Startup = false;
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            LoadTimer.Enabled = true;
            Loader = 0;
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            switch (Loader == 200)
            {
                case (true):
                    LoadTimer.Stop();
                    Autorization_Form autorization_Form = new Autorization_Form();
                    autorization_Form.Show();
                    this.Hide();
                    break;
                case (false):
                    Loader += 1;
                    break;
            }

        }

        public void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("Невозможно установить новую версию приложения. \nОшибка: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Невозможно обновить приложение из-за повреждения файла ClickOnce. \nОшибка: " + ide.Message);
                    return;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Неизвестная ошибка установки:" + e.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Доступно обновление. Вы хотите его загрузить?", "ArizonaClient", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("Обновление установило различие между текущей и минимальной версией програмного обеспечения: " + info.MinimumRequiredVersion.ToString() +
                            ". Обновление будет принудительно загружено и переустановлено",
                            "ArizonaClient", MessageBoxButtons.OK);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("Приложение успешно обновлено и будет перезапущено.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Не удалось установить новую версию програмного обеспечения. \nОшибка: " + dde);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Новых версий приложения не обнуружено");
                }
            }
        }
    }
}