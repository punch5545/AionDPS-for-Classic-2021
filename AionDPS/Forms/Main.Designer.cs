
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "측정자 닉네임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "수호신장 구분";
            // 
            // guardianComboBox
            // 
            this.guardianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guardianComboBox.FormattingEnabled = true;
            this.guardianComboBox.Location = new System.Drawing.Point(101, 62);
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
            this.fortressComboBox.Location = new System.Drawing.Point(101, 36);
            this.fortressComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fortressComboBox.Name = "fortressComboBox";
            this.fortressComboBox.Size = new System.Drawing.Size(213, 20);
            this.fortressComboBox.TabIndex = 6;
            this.fortressComboBox.SelectedIndexChanged += new System.EventHandler(this.fortressComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 38);
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
            this.button1.Location = new System.Drawing.Point(0, 125);
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
            this.checkBox2.Location = new System.Drawing.Point(12, 105);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(180, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "격노맞은 불쌍한 영혼들 보기";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Chat.log";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // showMyNick
            // 
            this.showMyNick.AutoSize = true;
            this.showMyNick.Location = new System.Drawing.Point(12, 85);
            this.showMyNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showMyNick.Name = "showMyNick";
            this.showMyNick.Size = new System.Drawing.Size(88, 16);
            this.showMyNick.TabIndex = 9;
            this.showMyNick.Text = "측정자 표시";
            this.showMyNick.UseVisualStyleBackColor = true;
            this.showMyNick.MouseHover += new System.EventHandler(this.checkBox3_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 181);
            this.Controls.Add(this.showMyNick);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fortressComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guardianComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "요새전 DPS 측정기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guardianComboBox;
        private System.Windows.Forms.ComboBox fortressComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox showMyNick;
        public System.Windows.Forms.TextBox textBox1;
    }
}

