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
            this.命名规则细则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehicle_no_comb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fly_item_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.命名规则细则ToolStripMenuItem,
            this.aboutApplication,
            this.closeApplication});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // 命名规则细则ToolStripMenuItem
            // 
            this.命名规则细则ToolStripMenuItem.Name = "命名规则细则ToolStripMenuItem";
            this.命名规则细则ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.命名规则细则ToolStripMenuItem.Text = "命名规则细则";
            // 
            // aboutApplication
            // 
            this.aboutApplication.Name = "aboutApplication";
            this.aboutApplication.Size = new System.Drawing.Size(148, 22);
            this.aboutApplication.Text = "关于";
            this.aboutApplication.Click += new System.EventHandler(this.aboutApplication_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(148, 22);
            this.closeApplication.Text = "退出";
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vehicle_no_comb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fly_item_txt);
            this.groupBox1.Controls.Add(this.label7);
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
            // vehicle_no_comb
            // 
            this.vehicle_no_comb.FormattingEnabled = true;
            this.vehicle_no_comb.Location = new System.Drawing.Point(184, 47);
            this.vehicle_no_comb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.vehicle_no_comb.Name = "vehicle_no_comb";
            this.vehicle_no_comb.Size = new System.Drawing.Size(371, 20);
            this.vehicle_no_comb.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(94, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "飞行器编号";
            this.toolTip1.SetToolTip(this.label8, "电动01，油动02");
            // 
            // fly_item_txt
            // 
            this.fly_item_txt.Location = new System.Drawing.Point(184, 169);
            this.fly_item_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fly_item_txt.Name = "fly_item_txt";
            this.fly_item_txt.Size = new System.Drawing.Size(371, 21);
            this.fly_item_txt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(94, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "飞行科目";
            // 
            // spot_cmb
            // 
            this.spot_cmb.FormattingEnabled = true;
            this.spot_cmb.Location = new System.Drawing.Point(184, 136);
            this.spot_cmb.Name = "spot_cmb";
            this.spot_cmb.Size = new System.Drawing.Size(371, 20);
            this.spot_cmb.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(95, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "场地";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(98, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "创建文件夹";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
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
            this.comment_txt.Location = new System.Drawing.Point(184, 199);
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(371, 21);
            this.comment_txt.TabIndex = 6;
            // 
            // flyTime_num
            // 
            this.flyTime_num.Location = new System.Drawing.Point(184, 103);
            this.flyTime_num.Name = "flyTime_num";
            this.flyTime_num.Size = new System.Drawing.Size(104, 21);
            this.flyTime_num.TabIndex = 3;
            this.flyTime_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vehicleType_comb
            // 
            this.vehicleType_comb.FormattingEnabled = true;
            this.vehicleType_comb.Location = new System.Drawing.Point(184, 75);
            this.vehicleType_comb.Name = "vehicleType_comb";
            this.vehicleType_comb.Size = new System.Drawing.Size(371, 20);
            this.vehicleType_comb.TabIndex = 2;
            // 
            // targetDirSelect_btn
            // 
            this.targetDirSelect_btn.Location = new System.Drawing.Point(561, 257);
            this.targetDirSelect_btn.Name = "targetDirSelect_btn";
            this.targetDirSelect_btn.Size = new System.Drawing.Size(22, 23);
            this.targetDirSelect_btn.TabIndex = 7;
            this.targetDirSelect_btn.Text = "button2";
            this.targetDirSelect_btn.UseVisualStyleBackColor = true;
            this.targetDirSelect_btn.Click += new System.EventHandler(this.targetDirSelect_btn_Click);
            // 
            // targetDir
            // 
            this.targetDir.Location = new System.Drawing.Point(184, 257);
            this.targetDir.Name = "targetDir";
            this.targetDir.Size = new System.Drawing.Size(371, 21);
            this.targetDir.TabIndex = 9;
            this.targetDir.TextChanged += new System.EventHandler(this.targetDir_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(95, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "目标目录";
            this.toolTip1.SetToolTip(this.label5, "保存文件目录");
            // 
            // newTargetDir_input
            // 
            this.newTargetDir_input.Enabled = false;
            this.newTargetDir_input.Location = new System.Drawing.Point(184, 229);
            this.newTargetDir_input.Name = "newTargetDir_input";
            this.newTargetDir_input.Size = new System.Drawing.Size(164, 21);
            this.newTargetDir_input.TabIndex = 8;
            this.newTargetDir_input.TextChanged += new System.EventHandler(this.newTargetDir_input_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(96, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(95, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "架次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "机型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
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
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "文件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(567, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = "version";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "提示信息";
            // 
            // CopyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CopyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogCooooopy";
            this.Activated += new System.EventHandler(this.CopyLog_Activated);
            this.Deactivate += new System.EventHandler(this.CopyLog_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyLog_FormClosing);
            this.SizeChanged += new System.EventHandler(this.CopyLog_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.CopyLog_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CopyLog_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopyLog_KeyUp);
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
        private System.Windows.Forms.TextBox fly_item_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox vehicle_no_comb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 命名规则细则ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

