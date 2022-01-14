
namespace AionDPS.Forms
{
    partial class UsedSkillListForrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillName,
            this.accDamage,
            this.count,
            this.maxDamage,
            this.rate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(699, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(699, 334);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // skillName
            // 
            this.skillName.HeaderText = "스킬이름";
            this.skillName.Name = "skillName";
            this.skillName.Width = 250;
            // 
            // accDamage
            // 
            this.accDamage.HeaderText = "총대미지";
            this.accDamage.Name = "accDamage";
            // 
            // count
            // 
            this.count.HeaderText = "사용횟수";
            this.count.Name = "count";
            // 
            // maxDamage
            // 
            this.maxDamage.HeaderText = "최대대미지";
            this.maxDamage.Name = "maxDamage";
            // 
            // rate
            // 
            this.rate.HeaderText = "사용비율";
            this.rate.Name = "rate";
            // 
            // UsedSkillListForrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 577);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsedSkillListForrm";
            this.Text = "UsedSkillListForrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}