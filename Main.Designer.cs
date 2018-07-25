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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.save_btn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.showPoint_btn = new System.Windows.Forms.Button();
            this.buttons_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "编辑轨道";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "编辑道岔";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "编辑供电臂";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(24, 309);
            this.save_btn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(150, 56);
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
            this.showPoint_btn.Location = new System.Drawing.Point(24, 239);
            this.showPoint_btn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.showPoint_btn.Name = "showPoint_btn";
            this.showPoint_btn.Size = new System.Drawing.Size(150, 56);
            this.showPoint_btn.TabIndex = 4;
            this.showPoint_btn.Text = "显/隐坐标";
            this.showPoint_btn.UseVisualStyleBackColor = true;
            this.showPoint_btn.Click += new System.EventHandler(this.showPoint_btn_Click);
            // 
            // buttons_pnl
            // 
            this.buttons_pnl.Location = new System.Drawing.Point(210, 1856);
            this.buttons_pnl.Name = "buttons_pnl";
            this.buttons_pnl.Size = new System.Drawing.Size(3404, 415);
            this.buttons_pnl.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(3360, 1850);
            this.Controls.Add(this.buttons_pnl);
            this.Controls.Add(this.showPoint_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button showPoint_btn;
        private System.Windows.Forms.Panel buttons_pnl;
    }
}

