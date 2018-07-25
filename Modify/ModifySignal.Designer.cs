namespace DisplaySystem.Modify
{
    partial class ModifySignal
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.y_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.TrackPointListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(326, 322);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(88, 33);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(231, 322);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 33);
            this.SaveBtn.TabIndex = 46;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Y";
            // 
            // y_tb
            // 
            this.y_tb.Location = new System.Drawing.Point(266, 166);
            this.y_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y_tb.Name = "y_tb";
            this.y_tb.Size = new System.Drawing.Size(62, 24);
            this.y_tb.TabIndex = 44;
            this.y_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "X";
            // 
            // x_tb
            // 
            this.x_tb.Location = new System.Drawing.Point(266, 128);
            this.x_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x_tb.Name = "x_tb";
            this.x_tb.Size = new System.Drawing.Size(62, 24);
            this.x_tb.TabIndex = 41;
            this.x_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "名称";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(279, 62);
            this.id_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(116, 24);
            this.id_tb.TabIndex = 39;
            // 
            // TrackPointListView
            // 
            this.TrackPointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.point,
            this.dir});
            this.TrackPointListView.FullRowSelect = true;
            this.TrackPointListView.Location = new System.Drawing.Point(14, 9);
            this.TrackPointListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrackPointListView.Name = "TrackPointListView";
            this.TrackPointListView.Size = new System.Drawing.Size(203, 353);
            this.TrackPointListView.TabIndex = 38;
            this.TrackPointListView.UseCompatibleStateImageBehavior = false;
            this.TrackPointListView.View = System.Windows.Forms.View.Details;
            this.TrackPointListView.SelectedIndexChanged += new System.EventHandler(this.TrackPointListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // point
            // 
            this.point.Text = "坐标";
            this.point.Width = 75;
            // 
            // dir
            // 
            this.dir.Text = "朝向";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(232, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "朝向";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "左";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(94, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "右";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ModifySignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.y_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.TrackPointListView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifySignal";
            this.Text = "ModifySignal";
            this.Load += new System.EventHandler(this.ModifySignal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.ListView TrackPointListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader point;
        private System.Windows.Forms.ColumnHeader dir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}