namespace WindowsFormsApplication2
{
    partial class CopyLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyLog));
            this.selectFolder_dia = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFile_dia = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spot_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.flyTime_num = new System.Windows.Forms.NumericUpDown();
            this.vehicleType_comb = new System.Windows.Forms.ComboBox();
            this.targetDirSelect_btn = new System.Windows.Forms.Button();
            this.targetDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newTargetDir_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fromFile_comb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyTime_num)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFile_dia
            // 
            this.selectFile_dia.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "log复制工具";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LogCoooooooooopy正在运行";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeApplication,
            this.aboutApplication});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // closeApplication
            // 
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(100, 22);
            this.closeApplication.Text = "退出";
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // aboutApplication
            // 
            this.aboutApplication.Name = "aboutApplication";
            this.aboutApplication.Size = new System.Drawing.Size(100, 22);
            this.aboutApplication.Text = "关于";
            this.aboutApplication.Click += new System.EventHandler(this.aboutApplication_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spot_cmb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comment_txt);
            this.groupBox1.Controls.Add(this.flyTime_num);
            this.groupBox1.Controls.Add(this.vehicleType_comb);
            this.groupBox1.Controls.Add(this.targetDirSelect_btn);
            this.groupBox1.Controls.Add(this.targetDir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newTargetDir_input);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fromFile_comb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // spot_cmb
            // 
            this.spot_cmb.FormattingEnabled = true;
            this.spot_cmb.Location = new System.Drawing.Point(184, 112);
            this.spot_cmb.Name = "spot_cmb";
            this.spot_cmb.Size = new System.Drawing.Size(371, 20);
            this.spot_cmb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "场地";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "创建文件夹";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(491, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "复制";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(184, 169);
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(371, 21);
            this.comment_txt.TabIndex = 4;
            // 
            // flyTime_num
            // 
            this.flyTime_num.Location = new System.Drawing.Point(184, 73);
            this.flyTime_num.Name = "flyTime_num";
            this.flyTime_num.Size = new System.Drawing.Size(104, 21);
            this.flyTime_num.TabIndex = 2;
            // 
            // vehicleType_comb
            // 
            this.vehicleType_comb.FormattingEnabled = true;
            this.vehicleType_comb.Location = new System.Drawing.Point(184, 44);
            this.vehicleType_comb.Name = "vehicleType_comb";
            this.vehicleType_comb.Size = new System.Drawing.Size(371, 20);
            this.vehicleType_comb.TabIndex = 1;
            // 
            // targetDirSelect_btn
            // 
            this.targetDirSelect_btn.Location = new System.Drawing.Point(561, 238);
            this.targetDirSelect_btn.Name = "targetDirSelect_btn";
            this.targetDirSelect_btn.Size = new System.Drawing.Size(22, 22);
            this.targetDirSelect_btn.TabIndex = 7;
            this.targetDirSelect_btn.Text = "button2";
            this.targetDirSelect_btn.UseVisualStyleBackColor = true;
            this.targetDirSelect_btn.Click += new System.EventHandler(this.targetDirSelect_btn_Click);
            // 
            // targetDir
            // 
            this.targetDir.Location = new System.Drawing.Point(184, 238);
            this.targetDir.Name = "targetDir";
            this.targetDir.Size = new System.Drawing.Size(371, 21);
            this.targetDir.TabIndex = 7;
            this.targetDir.TextChanged += new System.EventHandler(this.targetDir_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "目标目录";
            // 
            // newTargetDir_input
            // 
            this.newTargetDir_input.Enabled = false;
            this.newTargetDir_input.Location = new System.Drawing.Point(184, 204);
            this.newTargetDir_input.Name = "newTargetDir_input";
            this.newTargetDir_input.Size = new System.Drawing.Size(164, 21);
            this.newTargetDir_input.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "架次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "机型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fromFile_comb
            // 
            this.fromFile_comb.FormattingEnabled = true;
            this.fromFile_comb.Location = new System.Drawing.Point(184, 16);
            this.fromFile_comb.Name = "fromFile_comb";
            this.fromFile_comb.Size = new System.Drawing.Size(371, 20);
            this.fromFile_comb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "文件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(617, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "功能";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CopyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CopyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogCooooopy";
            this.Activated += new System.EventHandler(this.CopyLog_Activated);
            this.Deactivate += new System.EventHandler(this.CopyLog_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyLog_FormClosing);
            this.SizeChanged += new System.EventHandler(this.CopyLog_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.CopyLog_VisibleChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyTime_num)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog selectFolder_dia;
        private System.Windows.Forms.OpenFileDialog selectFile_dia;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox comment_txt;
        private System.Windows.Forms.NumericUpDown flyTime_num;
        private System.Windows.Forms.ComboBox vehicleType_comb;
        private System.Windows.Forms.Button targetDirSelect_btn;
        private System.Windows.Forms.TextBox targetDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newTargetDir_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fromFile_comb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeApplication;
        private System.Windows.Forms.ToolStripMenuItem aboutApplication;
        private System.Windows.Forms.ComboBox spot_cmb;
        private System.Windows.Forms.Label label6;
    }
}

