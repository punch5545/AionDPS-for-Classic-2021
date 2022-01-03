using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            foreach(KeyValuePair<string, Log> item in LogAnalyzer.Instance.userList)
            {
                if(item.Value.userClass == btn.Text)
                    dataGridView1.Rows.Add(0, item.Value.userClass, item.Key, item.Value.DPS, item.Value.accDamage, item.Value.time + "초", item.Value.newAtk + "회", item.Value.atkTimes + "회", item.Value.skillTimes + "회");
            }
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = ++i;
            }
            dataGridView1.ClearSelection();
        }
    }
}
