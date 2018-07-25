﻿namespace DisplaySystem.Modify
{
    partial class ModifyPowerSupplyModel
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.ps_lv = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.otherTracks_lv = new System.Windows.Forms.ListView();
            this.trackID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.containTracks_lv = new System.Windows.Forms.ListView();
            this.trackID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.des2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTrack_btn = new System.Windows.Forms.Button();
            this.deleteTrack_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.otherPoints_lv = new System.Windows.Forms.ListView();
            this.ID3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.containPoints_lv = new System.Windows.Forms.ListView();
            this.ID4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addPoint_btn = new System.Windows.Forms.Button();
            this.deletePoint_btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.trackInWhere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(1216, 106);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(150, 56);
            this.delete_btn.TabIndex = 54;
            this.delete_btn.Text = "删除供电臂";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(1216, 37);
            this.save_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(150, 56);
            this.save_btn.TabIndex = 53;
            this.save_btn.Text = "保存供电臂";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(510, 29);
            this.id_tb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(196, 37);
            this.id_tb.TabIndex = 42;
            this.id_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_tb_KeyPress);
            // 
            // ps_lv
            // 
            this.ps_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name});
            this.ps_lv.FullRowSelect = true;
            this.ps_lv.Location = new System.Drawing.Point(24, 29);
            this.ps_lv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ps_lv.MultiSelect = false;
            this.ps_lv.Name = "ps_lv";
            this.ps_lv.Size = new System.Drawing.Size(368, 967);
            this.ps_lv.TabIndex = 41;
            this.ps_lv.UseCompatibleStateImageBehavior = false;
            this.ps_lv.View = System.Windows.Forms.View.Details;
            this.ps_lv.SelectedIndexChanged += new System.EventHandler(this.ps_lv_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "名称";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(510, 95);
            this.name_tb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(196, 37);
            this.name_tb.TabIndex = 58;
            // 
            // otherTracks_lv
            // 
            this.otherTracks_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackID,
            this.des});
            this.otherTracks_lv.FullRowSelect = true;
            this.otherTracks_lv.Location = new System.Drawing.Point(444, 220);
            this.otherTracks_lv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.otherTracks_lv.MultiSelect = false;
            this.otherTracks_lv.Name = "otherTracks_lv";
            this.otherTracks_lv.Size = new System.Drawing.Size(196, 596);
            this.otherTracks_lv.TabIndex = 60;
            this.otherTracks_lv.UseCompatibleStateImageBehavior = false;
            this.otherTracks_lv.View = System.Windows.Forms.View.Details;
            // 
            // trackID
            // 
            this.trackID.Text = "ID";
            this.trackID.Width = 45;
            // 
            // des
            // 
            this.des.Text = "描述";
            this.des.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "从剩余轨道中添加";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "已包含轨道";
            // 
            // containTracks_lv
            // 
            this.containTracks_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackID2,
            this.des2,
            this.trackInWhere});
            this.containTracks_lv.FullRowSelect = true;
            this.containTracks_lv.Location = new System.Drawing.Point(656, 220);
            this.containTracks_lv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.containTracks_lv.MultiSelect = false;
            this.containTracks_lv.Name = "containTracks_lv";
            this.containTracks_lv.Size = new System.Drawing.Size(196, 596);
            this.containTracks_lv.TabIndex = 62;
            this.containTracks_lv.UseCompatibleStateImageBehavior = false;
            this.containTracks_lv.View = System.Windows.Forms.View.Details;
            // 
            // trackID2
            // 
            this.trackID2.Text = "ID";
            this.trackID2.Width = 45;
            // 
            // des2
            // 
            this.des2.Text = "描述";
            // 
            // addTrack_btn
            // 
            this.addTrack_btn.Location = new System.Drawing.Point(468, 945);
            this.addTrack_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addTrack_btn.Name = "addTrack_btn";
            this.addTrack_btn.Size = new System.Drawing.Size(150, 56);
            this.addTrack_btn.TabIndex = 64;
            this.addTrack_btn.Text = "添加轨道";
            this.addTrack_btn.UseVisualStyleBackColor = true;
            this.addTrack_btn.Click += new System.EventHandler(this.addTrack_btn_Click);
            // 
            // deleteTrack_btn
            // 
            this.deleteTrack_btn.Location = new System.Drawing.Point(676, 945);
            this.deleteTrack_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.deleteTrack_btn.Name = "deleteTrack_btn";
            this.deleteTrack_btn.Size = new System.Drawing.Size(150, 56);
            this.deleteTrack_btn.TabIndex = 65;
            this.deleteTrack_btn.Text = "删除轨道";
            this.deleteTrack_btn.UseVisualStyleBackColor = true;
            this.deleteTrack_btn.Click += new System.EventHandler(this.deleteTrack_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "添加受影响的道岔";
            // 
            // otherPoints_lv
            // 
            this.otherPoints_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID3,
            this.point1});
            this.otherPoints_lv.FullRowSelect = true;
            this.otherPoints_lv.Location = new System.Drawing.Point(868, 220);
            this.otherPoints_lv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.otherPoints_lv.MultiSelect = false;
            this.otherPoints_lv.Name = "otherPoints_lv";
            this.otherPoints_lv.Size = new System.Drawing.Size(196, 596);
            this.otherPoints_lv.TabIndex = 66;
            this.otherPoints_lv.UseCompatibleStateImageBehavior = false;
            this.otherPoints_lv.View = System.Windows.Forms.View.Details;
            // 
            // ID3
            // 
            this.ID3.Text = "ID";
            this.ID3.Width = 45;
            // 
            // point1
            // 
            this.point1.Text = "坐标";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1076, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "已受影响的道岔";
            // 
            // containPoints_lv
            // 
            this.containPoints_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID4,
            this.point2,
            this.position});
            this.containPoints_lv.FullRowSelect = true;
            this.containPoints_lv.Location = new System.Drawing.Point(1080, 220);
            this.containPoints_lv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.containPoints_lv.MultiSelect = false;
            this.containPoints_lv.Name = "containPoints_lv";
            this.containPoints_lv.Size = new System.Drawing.Size(284, 596);
            this.containPoints_lv.TabIndex = 68;
            this.containPoints_lv.UseCompatibleStateImageBehavior = false;
            this.containPoints_lv.View = System.Windows.Forms.View.Details;
            // 
            // ID4
            // 
            this.ID4.Text = "ID";
            this.ID4.Width = 45;
            // 
            // point2
            // 
            this.point2.Text = "坐标";
            // 
            // position
            // 
            this.position.Text = "限制位置";
            this.position.Width = 80;
            // 
            // addPoint_btn
            // 
            this.addPoint_btn.Location = new System.Drawing.Point(896, 947);
            this.addPoint_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addPoint_btn.Name = "addPoint_btn";
            this.addPoint_btn.Size = new System.Drawing.Size(150, 56);
            this.addPoint_btn.TabIndex = 70;
            this.addPoint_btn.Text = "添加道岔";
            this.addPoint_btn.UseVisualStyleBackColor = true;
            this.addPoint_btn.Click += new System.EventHandler(this.addPoint_btn_Click);
            // 
            // deletePoint_btn
            // 
            this.deletePoint_btn.Location = new System.Drawing.Point(1071, 947);
            this.deletePoint_btn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.deletePoint_btn.Name = "deletePoint_btn";
            this.deletePoint_btn.Size = new System.Drawing.Size(150, 56);
            this.deletePoint_btn.TabIndex = 71;
            this.deletePoint_btn.Text = "删除道岔";
            this.deletePoint_btn.UseVisualStyleBackColor = true;
            this.deletePoint_btn.Click += new System.EventHandler(this.deletePoint_btn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 48);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 33);
            this.radioButton1.TabIndex = 72;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "定位";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 48);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 33);
            this.radioButton2.TabIndex = 73;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "反位";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(896, 835);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(322, 97);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "将道岔固定于";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(444, 835);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Size = new System.Drawing.Size(408, 97);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "该轨道在无电区的部分";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(154, 48);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 33);
            this.radioButton3.TabIndex = 72;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "全部";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(66, 48);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 33);
            this.radioButton4.TabIndex = 73;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "左半";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(246, 48);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(80, 33);
            this.radioButton5.TabIndex = 74;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "右半";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // trackInWhere
            // 
            this.trackInWhere.Text = "无电方向";
            // 
            // ModifyPowerSupplyModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 1029);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deletePoint_btn);
            this.Controls.Add(this.addPoint_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.containPoints_lv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.otherPoints_lv);
            this.Controls.Add(this.deleteTrack_btn);
            this.Controls.Add(this.addTrack_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.containTracks_lv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.otherTracks_lv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.ps_lv);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ModifyPowerSupplyModel";
            this.Text = "ModifyPowerSupplyModel";
            this.Load += new System.EventHandler(this.ModifyPowerSupplyModel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.ListView ps_lv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ListView otherTracks_lv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView containTracks_lv;
        private System.Windows.Forms.Button addTrack_btn;
        private System.Windows.Forms.Button deleteTrack_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView otherPoints_lv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView containPoints_lv;
        private System.Windows.Forms.Button addPoint_btn;
        private System.Windows.Forms.Button deletePoint_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader trackID;
        private System.Windows.Forms.ColumnHeader des;
        private System.Windows.Forms.ColumnHeader trackID2;
        private System.Windows.Forms.ColumnHeader des2;
        private System.Windows.Forms.ColumnHeader ID3;
        private System.Windows.Forms.ColumnHeader point1;
        private System.Windows.Forms.ColumnHeader ID4;
        private System.Windows.Forms.ColumnHeader point2;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ColumnHeader trackInWhere;
    }
}