namespace DisplaySystem
{
    partial class Main
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
            this.modifyTrackLine_btn = new System.Windows.Forms.Button();
            this.modifyTrackPoint_btn = new System.Windows.Forms.Button();
            this.modifyPowerSupplyModel_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.save_btn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.showPoint_btn = new System.Windows.Forms.Button();
            this.buttons_pnl = new System.Windows.Forms.Panel();
            this.setting_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifySignal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyTrackLine_btn
            // 
            this.modifyTrackLine_btn.Location = new System.Drawing.Point(29, 974);
            this.modifyTrackLine_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.modifyTrackLine_btn.Name = "modifyTrackLine_btn";
            this.modifyTrackLine_btn.Size = new System.Drawing.Size(174, 64);
            this.modifyTrackLine_btn.TabIndex = 0;
            this.modifyTrackLine_btn.Text = "轨道";
            this.modifyTrackLine_btn.UseVisualStyleBackColor = true;
            this.modifyTrackLine_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyTrackPoint_btn
            // 
            this.modifyTrackPoint_btn.Location = new System.Drawing.Point(29, 894);
            this.modifyTrackPoint_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.modifyTrackPoint_btn.Name = "modifyTrackPoint_btn";
            this.modifyTrackPoint_btn.Size = new System.Drawing.Size(174, 64);
            this.modifyTrackPoint_btn.TabIndex = 1;
            this.modifyTrackPoint_btn.Text = "道岔";
            this.modifyTrackPoint_btn.UseVisualStyleBackColor = true;
            this.modifyTrackPoint_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // modifyPowerSupplyModel_btn
            // 
            this.modifyPowerSupplyModel_btn.Location = new System.Drawing.Point(29, 735);
            this.modifyPowerSupplyModel_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.modifyPowerSupplyModel_btn.Name = "modifyPowerSupplyModel_btn";
            this.modifyPowerSupplyModel_btn.Size = new System.Drawing.Size(174, 64);
            this.modifyPowerSupplyModel_btn.TabIndex = 2;
            this.modifyPowerSupplyModel_btn.Text = "供电臂";
            this.modifyPowerSupplyModel_btn.UseVisualStyleBackColor = true;
            this.modifyPowerSupplyModel_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(29, 577);
            this.save_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(174, 64);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // showPoint_btn
            // 
            this.showPoint_btn.Location = new System.Drawing.Point(29, 656);
            this.showPoint_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.showPoint_btn.Name = "showPoint_btn";
            this.showPoint_btn.Size = new System.Drawing.Size(174, 64);
            this.showPoint_btn.TabIndex = 4;
            this.showPoint_btn.Text = "显/隐坐标";
            this.showPoint_btn.UseVisualStyleBackColor = true;
            this.showPoint_btn.Click += new System.EventHandler(this.showPoint_btn_Click);
            // 
            // buttons_pnl
            // 
            this.buttons_pnl.Location = new System.Drawing.Point(226, 2112);
            this.buttons_pnl.Name = "buttons_pnl";
            this.buttons_pnl.Size = new System.Drawing.Size(3689, 472);
            this.buttons_pnl.TabIndex = 5;
            // 
            // setting_btn
            // 
            this.setting_btn.Location = new System.Drawing.Point(29, 1054);
            this.setting_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(174, 64);
            this.setting_btn.TabIndex = 6;
            this.setting_btn.Text = "编辑模式";
            this.setting_btn.UseVisualStyleBackColor = true;
            this.setting_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title_lbl.Location = new System.Drawing.Point(1318, 47);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(0, 157);
            this.title_lbl.TabIndex = 7;
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_tb
            // 
            this.title_tb.Font = new System.Drawing.Font("微软雅黑", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_tb.Location = new System.Drawing.Point(29, 511);
            this.title_tb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(171, 41);
            this.title_tb.TabIndex = 8;
            this.title_tb.TextChanged += new System.EventHandler(this.title_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "标题";
            // 
            // modifySignal_btn
            // 
            this.modifySignal_btn.Location = new System.Drawing.Point(29, 814);
            this.modifySignal_btn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.modifySignal_btn.Name = "modifySignal_btn";
            this.modifySignal_btn.Size = new System.Drawing.Size(174, 64);
            this.modifySignal_btn.TabIndex = 10;
            this.modifySignal_btn.Text = "信号机";
            this.modifySignal_btn.UseVisualStyleBackColor = true;
            this.modifySignal_btn.Click += new System.EventHandler(this.modifySignal_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(3536, 1944);
            this.Controls.Add(this.modifySignal_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.buttons_pnl);
            this.Controls.Add(this.showPoint_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.modifyPowerSupplyModel_btn);
            this.Controls.Add(this.modifyTrackPoint_btn);
            this.Controls.Add(this.modifyTrackLine_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Main_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyTrackLine_btn;
        private System.Windows.Forms.Button modifyTrackPoint_btn;
        private System.Windows.Forms.Button modifyPowerSupplyModel_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button showPoint_btn;
        private System.Windows.Forms.Panel buttons_pnl;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifySignal_btn;
    }
}

