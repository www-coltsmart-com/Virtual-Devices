namespace Virtual_Devices
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxlocaliplist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDeviceCnt = new System.Windows.Forms.TextBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonPowerOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择本地网卡";
            // 
            // comboBoxlocaliplist
            // 
            this.comboBoxlocaliplist.FormattingEnabled = true;
            this.comboBoxlocaliplist.Location = new System.Drawing.Point(95, 6);
            this.comboBoxlocaliplist.Name = "comboBoxlocaliplist";
            this.comboBoxlocaliplist.Size = new System.Drawing.Size(121, 20);
            this.comboBoxlocaliplist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标主机";
            // 
            // textBoxDestIP
            // 
            this.textBoxDestIP.Location = new System.Drawing.Point(281, 6);
            this.textBoxDestIP.Name = "textBoxDestIP";
            this.textBoxDestIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxDestIP.TabIndex = 3;
            this.textBoxDestIP.Text = "101.132.97.241";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "目标端口";
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Location = new System.Drawing.Point(446, 6);
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxDestPort.TabIndex = 5;
            this.textBoxDestPort.Text = "1883";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "虚拟设备个数";
            // 
            // textBoxDeviceCnt
            // 
            this.textBoxDeviceCnt.Location = new System.Drawing.Point(635, 6);
            this.textBoxDeviceCnt.Name = "textBoxDeviceCnt";
            this.textBoxDeviceCnt.Size = new System.Drawing.Size(100, 21);
            this.textBoxDeviceCnt.TabIndex = 7;
            this.textBoxDeviceCnt.Text = "1";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(14, 33);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(894, 415);
            this.richTextBoxLog.TabIndex = 8;
            this.richTextBoxLog.Text = "";
            // 
            // buttonPowerOn
            // 
            this.buttonPowerOn.Location = new System.Drawing.Point(776, 4);
            this.buttonPowerOn.Name = "buttonPowerOn";
            this.buttonPowerOn.Size = new System.Drawing.Size(132, 23);
            this.buttonPowerOn.TabIndex = 9;
            this.buttonPowerOn.Text = "所有设备通电开机";
            this.buttonPowerOn.UseVisualStyleBackColor = true;
            this.buttonPowerOn.Click += new System.EventHandler(this.ButtonPowerOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.buttonPowerOn);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.textBoxDeviceCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDestPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxlocaliplist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Virtual Devices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxlocaliplist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDeviceCnt;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonPowerOn;
    }
}

