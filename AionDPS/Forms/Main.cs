using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AionDPS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            LogAnalyzer.Initialize();
        }

        public static Main form;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cross Thread Control Exception 방지
            CheckForIllegalCrossThreadCalls = false;
            fortressComboBox.SelectedIndex = 0;

            form = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(guardianComboBox.Text == "")
            {
                return;
            }


            openFileDialog1.Filter = "Chat.log 파일|*.log";
            openFileDialog1.ShowDialog();

            string log;
            int i = 0;
            ResultForm resultForm = new ResultForm();

            try
            {
                this.button1.Text = "집계중입니다.";
                this.button1.Enabled = false;
                this.button1.BackColor = Color.White;

                using (StreamReader sr = new StreamReader(openFileDialog1.OpenFile(), Encoding.Default, true))
                {
                    while ((log = sr.ReadLine()) != null)
                    {
                        LogAnalyzer.Instance.Analyze(log, guardianComboBox.Text);
                    }

                }
                resultForm.Show();
                this.Hide();
            }
            catch
            {

            }

            //this.Hide();
        }

        private void FileOpened(Stream logFile)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //FileOpened(openFileDialog1.OpenFile());
        }

        private void checkBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "";
            toolTip1.SetToolTip(showMyNick, "측정자의 데이터를 다른 색상으로 표기합니다.");
        }

        private void fortressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            guardianComboBox.Items.Clear();

            if (fortressComboBox.Text == "용계")
            {
                guardianComboBox.Items.Add("천족 수호신장");
                guardianComboBox.Items.Add("마족 수호신장");
                guardianComboBox.Items.Add("용족 수호신장");
            }
            if (fortressComboBox.Text == "어비스 상층")
            {
                guardianComboBox.Items.Add("천족 중급 수호신장");
                guardianComboBox.Items.Add("천족 상급 수호신장");
                guardianComboBox.Items.Add("");
                guardianComboBox.Items.Add("마족 중급 수호신장");
                guardianComboBox.Items.Add("마족 상급 수호신장");
                guardianComboBox.Items.Add("");
                guardianComboBox.Items.Add("용족 중급 수호신장");
                guardianComboBox.Items.Add("용족 상급 수호신장");
            }
            if (fortressComboBox.Text == "신성의 요새")
            {
                guardianComboBox.Items.Add("에레슈키갈 제1 수호신장");
            }

            guardianComboBox.SelectedIndex = 0;
        }
    }
}
