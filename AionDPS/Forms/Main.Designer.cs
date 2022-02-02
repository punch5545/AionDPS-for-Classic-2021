
namespace AionDPS
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guardianComboBox = new System.Windows.Forms.ComboBox();
            this.fortressComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.showMyNick = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이온폴더열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.부가기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유물계산기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemcfg편집ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.아이온옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개발자블로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개발자방명록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.소프트웨어정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "측정자 닉네임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "수호신장 구분";
            // 
            // guardianComboBox
            // 
            this.guardianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guardianComboBox.FormattingEnabled = true;
            this.guardianComboBox.Location = new System.Drawing.Point(99, 75);
            this.guardianComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardianComboBox.Name = "guardianComboBox";
            this.guardianComboBox.Size = new System.Drawing.Size(213, 20);
            this.guardianComboBox.TabIndex = 4;
            // 
            // fortressComboBox
            // 
            this.fortressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fortressComboBox.FormattingEnabled = true;
            this.fortressComboBox.Items.AddRange(new object[] {
            "용계",
            "어비스 상층",
            "신성의 요새"});
            this.fortressComboBox.Location = new System.Drawing.Point(99, 51);
            this.fortressComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fortressComboBox.Name = "fortressComboBox";
            this.fortressComboBox.Size = new System.Drawing.Size(213, 20);
            this.fortressComboBox.TabIndex = 6;
            this.fortressComboBox.SelectedIndexChanged += new System.EventHandler(this.fortressComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "요새전 구분";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "측정 시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 144);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(180, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "격노맞은 불쌍한 영혼들 보기";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Chat.log";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // showMyNick
            // 
            this.showMyNick.AutoSize = true;
            this.showMyNick.Checked = true;
            this.showMyNick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMyNick.Location = new System.Drawing.Point(12, 104);
            this.showMyNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showMyNick.Name = "showMyNick";
            this.showMyNick.Size = new System.Drawing.Size(88, 16);
            this.showMyNick.TabIndex = 9;
            this.showMyNick.Text = "측정자 표시";
            this.showMyNick.UseVisualStyleBackColor = true;
            this.showMyNick.MouseHover += new System.EventHandler(this.checkBox3_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 124);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "신속의 주문 횟수 집계";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아이온폴더열기ToolStripMenuItem,
            this.부가기능ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 아이온폴더열기ToolStripMenuItem
            // 
            this.아이온폴더열기ToolStripMenuItem.Name = "아이온폴더열기ToolStripMenuItem";
            this.아이온폴더열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.아이온폴더열기ToolStripMenuItem.Text = "아이온 폴더 열기";
            this.아이온폴더열기ToolStripMenuItem.Click += new System.EventHandler(this.아이온폴더열기ToolStripMenuItem_Click);
            // 
            // 부가기능ToolStripMenuItem
            // 
            this.부가기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유물계산기ToolStripMenuItem1,
            this.systemcfg편집ToolStripMenuItem1,
            this.아이온옵션ToolStripMenuItem});
            this.부가기능ToolStripMenuItem.Name = "부가기능ToolStripMenuItem";
            this.부가기능ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.부가기능ToolStripMenuItem.Text = "부가기능";
            // 
            // 유물계산기ToolStripMenuItem1
            // 
            this.유물계산기ToolStripMenuItem1.Name = "유물계산기ToolStripMenuItem1";
            this.유물계산기ToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.유물계산기ToolStripMenuItem1.Text = "유물계산기";
            // 
            // systemcfg편집ToolStripMenuItem1
            // 
            this.systemcfg편집ToolStripMenuItem1.Name = "systemcfg편집ToolStripMenuItem1";
            this.systemcfg편집ToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.systemcfg편집ToolStripMenuItem1.Text = "system.cfg 편집";
            // 
            // 아이온옵션ToolStripMenuItem
            // 
            this.아이온옵션ToolStripMenuItem.Name = "아이온옵션ToolStripMenuItem";
            this.아이온옵션ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.아이온옵션ToolStripMenuItem.Text = "아이온 옵션";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.개발자블로그ToolStripMenuItem,
            this.개발자방명록ToolStripMenuItem,
            this.toolStripSeparator2,
            this.소프트웨어정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 개발자블로그ToolStripMenuItem
            // 
            this.개발자블로그ToolStripMenuItem.Name = "개발자블로그ToolStripMenuItem";
            this.개발자블로그ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.개발자블로그ToolStripMenuItem.Text = "개발자 블로그";
            // 
            // 개발자방명록ToolStripMenuItem
            // 
            this.개발자방명록ToolStripMenuItem.Name = "개발자방명록ToolStripMenuItem";
            this.개발자방명록ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.개발자방명록ToolStripMenuItem.Text = "개발자 방명록";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // 소프트웨어정보ToolStripMenuItem
            // 
            this.소프트웨어정보ToolStripMenuItem.Name = "소프트웨어정보ToolStripMenuItem";
            this.소프트웨어정보ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.소프트웨어정보ToolStripMenuItem.Text = "소프트웨어 정보";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 225);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.showMyNick);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fortressComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guardianComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "요새전 DPS 측정기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guardianComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox showMyNick;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 부가기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유물계산기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemcfg편집ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 아이온옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개발자블로그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개발자방명록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 소프트웨어정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이온폴더열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        public System.Windows.Forms.ComboBox fortressComboBox;
    }
}

