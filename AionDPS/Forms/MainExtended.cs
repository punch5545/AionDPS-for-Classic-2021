using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionDPS
{
    public partial class Main
    {
        private void getSettings()
        {
            try
            {
                RegistryKey reg = Environment.Is64BitOperatingSystem ? Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("WOW6432Node") : Registry.LocalMachine.OpenSubKey("SOFTWARE");
                var key = reg.OpenSubKey("plaync");
                if (key != null)
                {
                    Properties.Settings.Default.AionFolder = key.GetValue("AIONC_LIVE_dir").ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.showMyNick.Checked = Properties.Settings.Default.showMeYellow;
            this.checkBox1.Checked = Properties.Settings.Default.showRapidCast;
            this.checkBox2.Checked = Properties.Settings.Default.showRage;
            this.textBox1.Text = Properties.Settings.Default.userName;
        }

        private void setSettings()
        {
            Properties.Settings.Default.showMeYellow = this.showMyNick.Checked;
            Properties.Settings.Default.showRapidCast = this.checkBox1.Checked;
            Properties.Settings.Default.showRage = this.checkBox2.Checked;
            Properties.Settings.Default.userName = this.textBox1.Text == "<당신>" ? "" : this.textBox1.Text;
            
            Properties.Settings.Default.Save();
        }
    }
}
