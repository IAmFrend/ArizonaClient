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
    class Update_Class
    {
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
            }
        }
    }
}
