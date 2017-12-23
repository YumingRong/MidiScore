namespace MidiInDemmo
{
    partial class MidiInPanel
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxMidiInDevices = new System.Windows.Forms.ComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.checkBoxFilterAutoSensing = new System.Windows.Forms.CheckBox();
            this.progressLog1 = new NAudio.Utils.ProgressLog();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMidiOutMessages = new System.Windows.Forms.CheckBox();
            this.comboBoxMidiOutDevices = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMidiInDevices
            // 
            this.comboBoxMidiInDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiInDevices.FormattingEnabled = true;
            this.comboBoxMidiInDevices.Location = new System.Drawing.Point(94, 11);
            this.comboBoxMidiInDevices.Name = "comboBoxMidiInDevices";
            this.comboBoxMidiInDevices.Size = new System.Drawing.Size(178, 20);
            this.comboBoxMidiInDevices.TabIndex = 0;
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(12, 15);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(41, 12);
            this.labelDevice.TabIndex = 1;
            this.labelDevice.Text = "Device";
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.Location = new System.Drawing.Point(12, 38);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(75, 21);
            this.buttonMonitor.TabIndex = 2;
            this.buttonMonitor.Text = "Monitor";
            this.buttonMonitor.UseVisualStyleBackColor = true;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // checkBoxFilterAutoSensing
            // 
            this.checkBoxFilterAutoSensing.AutoSize = true;
            this.checkBoxFilterAutoSensing.Checked = true;
            this.checkBoxFilterAutoSensing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilterAutoSensing.Location = new System.Drawing.Point(360, 41);
            this.checkBoxFilterAutoSensing.Name = "checkBoxFilterAutoSensing";
            this.checkBoxFilterAutoSensing.Size = new System.Drawing.Size(138, 16);
            this.checkBoxFilterAutoSensing.TabIndex = 4;
            this.checkBoxFilterAutoSensing.Text = "Filter Auto-Sensing";
            this.checkBoxFilterAutoSensing.UseVisualStyleBackColor = true;
            // 
            // progressLog1
            // 
            this.progressLog1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLog1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressLog1.Location = new System.Drawing.Point(12, 65);
            this.progressLog1.Name = "progressLog1";
            this.progressLog1.Padding = new System.Windows.Forms.Padding(1);
            this.progressLog1.Size = new System.Drawing.Size(486, 238);
            this.progressLog1.TabIndex = 3;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(94, 38);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(75, 21);
            this.buttonClearLog.TabIndex = 5;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxMidiOutMessages);
            this.groupBox1.Controls.Add(this.comboBoxMidiOutDevices);
            this.groupBox1.Location = new System.Drawing.Point(13, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MIDI Out";
            // 
            // checkBoxMidiOutMessages
            // 
            this.checkBoxMidiOutMessages.AutoSize = true;
            this.checkBoxMidiOutMessages.Location = new System.Drawing.Point(6, 18);
            this.checkBoxMidiOutMessages.Name = "checkBoxMidiOutMessages";
            this.checkBoxMidiOutMessages.Size = new System.Drawing.Size(186, 16);
            this.checkBoxMidiOutMessages.TabIndex = 0;
            this.checkBoxMidiOutMessages.Text = "Send Test MIDI Out Messages";
            this.checkBoxMidiOutMessages.UseVisualStyleBackColor = true;
            // 
            // comboBoxMidiOutDevices
            // 
            this.comboBoxMidiOutDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiOutDevices.FormattingEnabled = true;
            this.comboBoxMidiOutDevices.Location = new System.Drawing.Point(196, 16);
            this.comboBoxMidiOutDevices.Name = "comboBoxMidiOutDevices";
            this.comboBoxMidiOutDevices.Size = new System.Drawing.Size(178, 20);
            this.comboBoxMidiOutDevices.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MidiInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.checkBoxFilterAutoSensing);
            this.Controls.Add(this.progressLog1);
            this.Controls.Add(this.buttonMonitor);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxMidiInDevices);
            this.Name = "MidiInPanel";
            this.Text = "MIDI In Sample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MidiInPanel_FormClosed);
            this.Load += new System.EventHandler(this.MidiInPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMidiInDevices;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Button buttonMonitor;
        private NAudio.Utils.ProgressLog progressLog1;
        private System.Windows.Forms.CheckBox checkBoxFilterAutoSensing;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMidiOutMessages;
        private System.Windows.Forms.ComboBox comboBoxMidiOutDevices;
        private System.Windows.Forms.Timer timer1;
    }
}

