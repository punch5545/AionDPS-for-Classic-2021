using Microsoft.Dism;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AionOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Console.WindowWidth = 60;
            InitializeComponent();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("Aion.bin");
            if (processes.Length != 0)
            {
                MessageBox.Show("아이온 클라이언트가 실행중입니다.\n게임 종료 후 다시 시도해 주세요.");
                Environment.Exit(0);
            }
            getMSMQState();
        }

        private void getMSMQState()
        {
            Console.WriteLine("MSMQ 활성화 여부를 검사중입니다. 잠시만 기다려주세요.");
            DismApi.Initialize(DismLogLevel.LogErrors);
            using (DismSession session = DismApi.OpenOnlineSession())
            {

                if (session.RebootRequired)
                {
                    var dResult = MessageBox.Show("작업이 완료되어 재부팅이 필요합니다.\n지금 재부팅 하시겠습니까?", "작업완료", MessageBoxButtons.YesNo);

                    if (dResult == DialogResult.Yes)
                        SystemReboot();
                    else
                        Environment.Exit(0);
                }

                foreach (DismFeature feature in DismApi.GetFeatures(session))
                {
                    
                    if (feature.FeatureName.Contains("MSMQ-Container") || feature.FeatureName.Contains("MSMQ-Server"))
                    {
                        if (feature.State != DismPackageFeatureState.Installed)
                        {
                            Console.WriteLine("MSMQ 활성화가 필요합니다.");
                            button1.Enabled = true;
                            break;
                        }
                    }
                }
                if (!button1.Enabled)
                {
                    Console.WriteLine("MSMQ 가 활성화 되어있습니다.\n");
                    button2.Enabled = true;
                }
                else
                {
                }
            }
            DismApi.Shutdown();
        }

        private void SystemReboot()
        {
            ManagementClass mc = new ManagementClass("Win32_OperatingSystem");

            mc.Scope.Options.EnablePrivileges = true;
            ManagementObjectCollection mOC = mc.GetInstances();



            foreach (ManagementObject mo in mOC)
            {
                mo.InvokeMethod("Reboot", null);
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MSMQ = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft");
            bool rebootRequired;
            try
            {
                MSMQ.DeleteSubKey("MSMQ");
            }
            catch
            {

            }

            Console.WriteLine($"MSMQ를 활성화합니다. 잠시만 기다려 주세요.");

            DismApi.Initialize(DismLogLevel.LogErrors);
            using (DismSession session = DismApi.OpenOnlineSession())
            {
                foreach (DismFeature feature in DismApi.GetFeatures(session))
                {
                    if (feature.FeatureName.Contains("MSMQ"))
                    {
                        Console.WriteLine($"{feature.FeatureName} : {feature.State}");
                        try
                        {
                            if (feature.State != DismPackageFeatureState.Installed)
                            {
                                DismApi.EnableFeature(session, feature.FeatureName, false, true);
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"{feature.FeatureName} : 작업 실패");
                        }

                    }
                }

            }
            DismApi.Shutdown();

            getMSMQState();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("gpedit.msc");

            Console.WriteLine("컴퓨터 구성 > 관리 템플릿 > 네트워크 > QoS 패킷 스케줄러 클릭\n");
            Console.WriteLine("예약 대역폭 제한 더블클릭 > \"구성되지 않음\" 을 \"사용\" 으로 변경\n");
            Console.WriteLine("하단 옵션 > 대역폭 제한(%) 값을 0으로 변겅\n");
            Console.WriteLine("적용 > 확인\n");

            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey Services = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces");
            var subKeys = Services.GetSubKeyNames();
            foreach(var subKey in subKeys)
            {
                Services.CreateSubKey(subKey).SetValue("TcpAckFrequency", 0x00000001);
                Services.CreateSubKey(subKey).SetValue("TCPNoDelay", 0x00000001);
            }
            var MSMQ = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\MSMQ\\Parameters");
            MSMQ.SetValue("TCPNoDelay", 0x00000001);

            var Sysprofile = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile");
            Sysprofile.SetValue("NetworkThrottlingIndex", 0x00000046);
            Console.WriteLine("네트워크 레지스트리 수정 완료");

            var Keyboard = Registry.CurrentUser.CreateSubKey("Control Panel\\Keyboard");
            Keyboard.SetValue("InitialKeyboardIndicators", 2);
            Keyboard.CreateSubKey("Control Panel\\Keyboard").SetValue("KeyboardDelay", 0);
            Keyboard.CreateSubKey("Control Panel\\Keyboard").SetValue("KeyboardSpeed", 31);

            var Accessibility = Registry.CurrentUser.CreateSubKey("Control Panel\\Accessibility\\Keyboard Response");
            Accessibility.SetValue("AutoRepeatDelay", 200);
            Accessibility.SetValue("AutoRepeatRate", 1);
            Accessibility.SetValue("BounceTime", 0);
            Accessibility.SetValue("DelayBeforeAcceptance", 0);
            Accessibility.SetValue("Flags", 126);
            Accessibility.SetValue("Last BounceKey Setting", 0x00000000);
            Accessibility.SetValue("Last Valid Delay", 0x00000001);
            Accessibility.SetValue("Last Valid Repeat", 0x00000001);
            Accessibility.SetValue("Last Valid Wait", 0x00000000);

            Console.WriteLine("키보드 레지스트리 수정 완료");

            button3.Enabled = false;

            var dResult = MessageBox.Show("모든 작업이 완료되어 재부팅이 필요합니다.\n지금 재부팅 하시겠습니까?", "작업완료", MessageBoxButtons.YesNo);

            if (dResult == DialogResult.Yes)
                SystemReboot();
            else
                Environment.Exit(0);
        }
    }
}
