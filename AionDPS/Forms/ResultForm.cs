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
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);

            int i = 0;
            foreach (KeyValuePair<string, Log> item in LogAnalyzer.Instance.userList)
            {
                //Console.WriteLine("[{0}:{1}|{2}|{3}|{4}|{5}]", item.Value.userClass, item.Key, item.Value.DPS, item.Value.accDamage, item.Value.newAtk, item.Value.time);
                dataGridView1.Rows.Add(++i, item.Value.userClass, item.Key, item.Value.DPS, item.Value.accDamage, item.Value.time+"초", item.Value.newAtk+"회", item.Value.atkTimes+"회", item.Value.skillTimes+"회");
            }
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
            dataGridView1.Rows.Clear();

            Button btn = (Button)sender;
            Thread thread = new Thread(new ThreadStart(delegate () {
                foreach (KeyValuePair<string, Log> item in LogAnalyzer.Instance.userList)
                {
                    if (btn.Text == "전체")
                        dataGridView1.Rows.Add(0, item.Value.userClass, item.Key, item.Value.DPS, item.Value.accDamage, item.Value.time + "초", item.Value.newAtk + "회", item.Value.atkTimes + "회", item.Value.skillTimes + "회");

                    else
                    {
                        if (item.Value.userClass == btn.Text)
                            dataGridView1.Rows.Add(0, item.Value.userClass, item.Key, item.Value.DPS, item.Value.accDamage, item.Value.time + "초", item.Value.newAtk + "회", item.Value.atkTimes + "회", item.Value.skillTimes + "회");
                    }
                }
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = ++i;
                }
                dataGridView1.ClearSelection();

                if(btn.Text != "전체")
                {
                    int DGVOriginalHeight = dataGridView1.Height;
                    dataGridView1.Height = (dataGridView1.RowCount * dataGridView1.RowTemplate.Height) +
                                            dataGridView1.ColumnHeadersHeight;

                    using (Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height))
                    {
                        dataGridView1.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.dataGridView1.Size));
                        string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        bitmap.Save(Path.Combine(DesktopFolder, btn.Text + ".png"), ImageFormat.Png);
                    }
                    dataGridView1.Height = DGVOriginalHeight;
                }
            }));

            thread.Start();
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
