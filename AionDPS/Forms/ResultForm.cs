using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AionDPS
{
    public partial class ResultForm : Form
    {
        DataTable data = new DataTable();
        public ResultForm()
        {
            InitializeComponent();

            data.Columns.Add("#", typeof(int));
            data.Columns.Add("직업", typeof(string));
            data.Columns.Add("이름", typeof(string));
            data.Columns.Add("DPS", typeof(int));
            data.Columns.Add("누적딜", typeof(int));
            data.Columns.Add("시간", typeof(string));
            data.Columns.Add("새공격", typeof(string));
            data.Columns.Add("평타수", typeof(string));
            data.Columns.Add("스킬수", typeof(string));
            data.Columns.Add("평캔비율", typeof(string));
            data.Columns.Add("스킬치명", typeof(string));
            data.Columns.Add("평타평균", typeof(string));
            data.Columns.Add("스킬평균", typeof(string));
            data.Columns.Add("최대DMG", typeof(string));
            data.Columns.Add("연속평캔", typeof(string));
            data.Columns.Add("평타비율", typeof(string));
            data.Columns.Add("스킬비율", typeof(string));
            data.Columns.Add("신속", typeof(string));
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            

            int i = 0;
            foreach (KeyValuePair<string, Log> item in LogAnalyzer.Instance.userList)
            {
                data.Rows.Add(
                    ++i, 
                    item.Value.userClass, 
                    item.Key, 
                    item.Value.DPS, 
                    item.Value.accDamage, 
                    item.Value.time+"초", 
                    item.Value.newAtk+"회", 
                    item.Value.atkTimes+"회", 
                    item.Value.skillTimes+"회", 
                    item.Value.atkCancelPercentage+"%", 
                    item.Value.skillCriticalPercentage + "%", 
                    item.Value.avgAtkDamage, 
                    item.Value.avgSkillDamage, 
                    item.Value.MaxDamage, 
                    item.Value.maxContinuousAtkCancel+"회",
                    item.Value.atkPercentage+"%",
                    item.Value.skillPercentage + "%",
                    item.Value.castSpeedCount+"회"
                );
            }

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[10].Width = 80;
            dataGridView1.Columns[11].Width = 80;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 85;
            dataGridView1.Columns[14].Width = 80;
            dataGridView1.Columns[15].Width = 80;
            dataGridView1.Columns[16].Width = 80;
            dataGridView1.Columns[17].Width = 80;

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = ++i;
            }
            dataGridView1.ClearSelection();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int i = 0;

            Button btn = (Button)sender;
            Thread thread = new Thread(new ThreadStart(delegate () {
                if (btn.Text == "전체")
                {
                    data.DefaultView.RowFilter = $"";
                    data.DefaultView.Sort = "#";
                }
                else
                {
                    data.DefaultView.RowFilter = $"[직업] LIKE '%{btn.Text}%'";
                    data.DefaultView.Sort = "누적딜 DESC";
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Cells[0].Value = ++i;
                    }
                }

                dataGridView1.ClearSelection();

                if(checkBox1.Checked && btn.Text != "전체")
                {
                    int DGVOriginalHeight = dataGridView1.Height;
                    dataGridView1.Height = (dataGridView1.RowCount * dataGridView1.RowTemplate.Height) +
                                            dataGridView1.ColumnHeadersHeight;

                    using (Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height))
                    {
                        dataGridView1.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.dataGridView1.Size));
                        string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        bitmap.Save(Path.Combine(DesktopFolder, btn.Text + "_" + dataGridView1.Rows.Count + "명.png"), ImageFormat.Png);
                    }
                    dataGridView1.Height = DGVOriginalHeight;
                }
            }));

            thread.Start();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
