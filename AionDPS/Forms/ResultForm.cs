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
        private string currViewClass = "";
        public ResultForm()
        {
            InitializeComponent();

            data.Columns.Add("#", typeof(int));
            data.Columns.Add("직업", typeof(string));
            data.Columns.Add("이름", typeof(string));
            data.Columns.Add("DPS", typeof(int));
            data.Columns.Add("새공비", typeof(string));
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
            data.Columns.Add("격노", typeof(bool));
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);

            this.Text = $"전체 {LogAnalyzer.Instance.userList.Count}명";

            int i = 0;
            foreach (KeyValuePair<string, Log> item in LogAnalyzer.Instance.userList)
            {
                string newAtkRate = item.Value.time == 0 ? "-" : Math.Round((float)item.Value.newAtk / (float)item.Value.time, 2).ToString();

                data.Rows.Add(
                    ++i, 
                    item.Value.userClass, 
                    item.Key, 
                    item.Value.DPS,
                    newAtkRate,
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
                    item.Value.castSpeedCount+"회",
                    item.Value.rage
                );
            }

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 80;
            dataGridView1.Columns[11].Width = 80;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 80;
            dataGridView1.Columns[14].Width = 85;
            dataGridView1.Columns[15].Width = 80;
            dataGridView1.Columns[16].Width = 80;
            dataGridView1.Columns[17].Width = 80;
            dataGridView1.Columns[18].Width = 80;
            dataGridView1.Columns[19].Width = 0;

            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = ++i;
            }
            dataGridView1.CurrentCell = null;
        }

        private void button_Click(object sender, EventArgs e)
        {
            int i = 0;

            Button btn = (Button)sender;
            currViewClass = btn.Text;
            Thread thread = new Thread(new ThreadStart(delegate () {

                if (btn.Text == "전체")
                {
                    data.DefaultView.RowFilter = $"";
                    data.DefaultView.Sort = "#";
                }
                else
                {
                    this.Width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 50;

                    dataGridView1.CurrentCell = null;

                    data.DefaultView.RowFilter = $"[직업] LIKE '%{btn.Text}%'";
                    data.DefaultView.Sort = "누적딜 DESC";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Main.form.showMyNick.Checked)
                            if (row.Cells[2].Value.ToString() == Main.form.textBox1.Text)
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                        if ((bool)row.Cells[19].Value)
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                        row.Cells[0].Value = ++i;
                    }
                }

                dataGridView1.ClearSelection();

                if (checkBox1.Checked && btn.Text != "전체")
                {
                    Capture();
                }
            }));

            thread.Start();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }

                //contextMenuStrip1.Show();
            }
        }

        private void 검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void 현재화면캡쳐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capture();
        }

        private void Capture()
        {
            dataGridView1.CurrentCell = null;

            int DGVOriginalHeight = dataGridView1.Height;
            dataGridView1.Height = (dataGridView1.RowCount * dataGridView1.RowTemplate.Height) +
                                    dataGridView1.ColumnHeadersHeight;

            using (Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height))
            {
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.dataGridView1.Size));
                string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                bitmap.Save(Path.Combine(DesktopFolder, $"{Properties.Settings.Default[currViewClass]}. {currViewClass}_{dataGridView1.Rows.Count}명.png"), ImageFormat.Png);
            }
            dataGridView1.Height = DGVOriginalHeight;
        }

        private void 스킬보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
