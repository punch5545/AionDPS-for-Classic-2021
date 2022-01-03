
using System.Drawing;

namespace AionDPS
{
    partial class ResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newAtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atkTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atkCancelPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillCriticalPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgAtkDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgSkillDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continuousAtkCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atkPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "전체";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(57, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "검성";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(111, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "수호성";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(165, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "살성";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(219, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "궁성";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(275, 2);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "마도성";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(329, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "정령성";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(383, 2);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "치유성";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(437, 2);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = "호법성";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 32);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.playerClass,
            this.username,
            this.dps,
            this.accDamage,
            this.time,
            this.newAtk,
            this.atkTimes,
            this.skillTimes,
            this.atkCancelPercentage,
            this.skillCriticalPercentage,
            this.avgAtkDamage,
            this.avgSkillDamage,
            this.MaxDamage,
            this.continuousAtkCancel,
            this.atkPercentage,
            this.skillPercentage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 17;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 485);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // idx
            // 
            this.idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idx.HeaderText = "#";
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Width = 5;
            // 
            // playerClass
            // 
            this.playerClass.HeaderText = "직업";
            this.playerClass.Name = "playerClass";
            this.playerClass.ReadOnly = true;
            this.playerClass.Width = 60;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.username.HeaderText = "이름";
            this.username.MinimumWidth = 100;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // dps
            // 
            this.dps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dps.HeaderText = "DPS";
            this.dps.Name = "dps";
            this.dps.ReadOnly = true;
            this.dps.Width = 54;
            // 
            // accDamage
            // 
            this.accDamage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.accDamage.HeaderText = "누적딜";
            this.accDamage.Name = "accDamage";
            this.accDamage.ReadOnly = true;
            this.accDamage.Width = 66;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.time.HeaderText = "시간";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 54;
            // 
            // newAtk
            // 
            this.newAtk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.newAtk.HeaderText = "새공격";
            this.newAtk.Name = "newAtk";
            this.newAtk.ReadOnly = true;
            this.newAtk.Width = 66;
            // 
            // atkTimes
            // 
            this.atkTimes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.atkTimes.HeaderText = "공격수";
            this.atkTimes.Name = "atkTimes";
            this.atkTimes.ReadOnly = true;
            this.atkTimes.Width = 66;
            // 
            // skillTimes
            // 
            this.skillTimes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skillTimes.HeaderText = "스킬수";
            this.skillTimes.Name = "skillTimes";
            this.skillTimes.ReadOnly = true;
            this.skillTimes.Width = 66;
            // 
            // atkCancelPercentage
            // 
            this.atkCancelPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.atkCancelPercentage.HeaderText = "평캔비율";
            this.atkCancelPercentage.Name = "atkCancelPercentage";
            this.atkCancelPercentage.ReadOnly = true;
            this.atkCancelPercentage.Width = 78;
            // 
            // skillCriticalPercentage
            // 
            this.skillCriticalPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skillCriticalPercentage.HeaderText = "스킬치명률";
            this.skillCriticalPercentage.Name = "skillCriticalPercentage";
            this.skillCriticalPercentage.ReadOnly = true;
            this.skillCriticalPercentage.Width = 90;
            // 
            // avgAtkDamage
            // 
            this.avgAtkDamage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.avgAtkDamage.HeaderText = "평타평균";
            this.avgAtkDamage.Name = "avgAtkDamage";
            this.avgAtkDamage.ReadOnly = true;
            this.avgAtkDamage.Width = 78;
            // 
            // avgSkillDamage
            // 
            this.avgSkillDamage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.avgSkillDamage.HeaderText = "스킬평균";
            this.avgSkillDamage.Name = "avgSkillDamage";
            this.avgSkillDamage.ReadOnly = true;
            this.avgSkillDamage.Width = 78;
            // 
            // MaxDamage
            // 
            this.MaxDamage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaxDamage.HeaderText = "최대DMG";
            this.MaxDamage.Name = "MaxDamage";
            this.MaxDamage.ReadOnly = true;
            this.MaxDamage.Width = 82;
            // 
            // continuousAtkCancel
            // 
            this.continuousAtkCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.continuousAtkCancel.HeaderText = "연속평캔";
            this.continuousAtkCancel.Name = "continuousAtkCancel";
            this.continuousAtkCancel.ReadOnly = true;
            this.continuousAtkCancel.Width = 78;
            // 
            // atkPercentage
            // 
            this.atkPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.atkPercentage.HeaderText = "평타비율";
            this.atkPercentage.Name = "atkPercentage";
            this.atkPercentage.ReadOnly = true;
            this.atkPercentage.Width = 78;
            // 
            // skillPercentage
            // 
            this.skillPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skillPercentage.HeaderText = "스킬비율";
            this.skillPercentage.Name = "skillPercentage";
            this.skillPercentage.ReadOnly = true;
            this.skillPercentage.Width = 78;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dps;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn newAtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn atkTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn atkCancelPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillCriticalPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgAtkDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgSkillDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn continuousAtkCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn atkPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillPercentage;
    }
}