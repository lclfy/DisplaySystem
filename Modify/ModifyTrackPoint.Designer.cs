namespace DisplaySystem.Modify
{
    partial class ModifyTrackPoint
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
            this.label9 = new System.Windows.Forms.Label();
            this.p2_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p1_tb = new System.Windows.Forms.TextBox();
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
            this.p1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.p3_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(497, 307);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(416, 307);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 36;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "节点2";
            // 
            // p2_tb
            // 
            this.p2_tb.Location = new System.Drawing.Point(459, 229);
            this.p2_tb.Name = "p2_tb";
            this.p2_tb.Size = new System.Drawing.Size(100, 21);
            this.p2_tb.TabIndex = 34;
            this.p2_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_tb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "节点1";
            // 
            // p1_tb
            // 
            this.p1_tb.Location = new System.Drawing.Point(459, 202);
            this.p1_tb.Name = "p1_tb";
            this.p1_tb.Size = new System.Drawing.Size(100, 21);
            this.p1_tb.TabIndex = 32;
            this.p1_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p1_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Y";
            // 
            // y_tb
            // 
            this.y_tb.Location = new System.Drawing.Point(445, 126);
            this.y_tb.Name = "y_tb";
            this.y_tb.Size = new System.Drawing.Size(54, 21);
            this.y_tb.TabIndex = 25;
            this.y_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "X";
            // 
            // x_tb
            // 
            this.x_tb.Location = new System.Drawing.Point(445, 99);
            this.x_tb.Name = "x_tb";
            this.x_tb.Size = new System.Drawing.Size(54, 21);
            this.x_tb.TabIndex = 22;
            this.x_tb.TextChanged += new System.EventHandler(this.x_tb_TextChanged);
            this.x_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(445, 37);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(100, 21);
            this.id_tb.TabIndex = 20;
            this.id_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_tb_KeyPress);
            // 
            // TrackPointListView
            // 
            this.TrackPointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.point,
            this.p1,
            this.p2,
            this.p3});
            this.TrackPointListView.FullRowSelect = true;
            this.TrackPointListView.Location = new System.Drawing.Point(12, 12);
            this.TrackPointListView.Name = "TrackPointListView";
            this.TrackPointListView.Size = new System.Drawing.Size(386, 337);
            this.TrackPointListView.TabIndex = 19;
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
            this.point.Width = 90;
            // 
            // p1
            // 
            this.p1.Text = "节点1";
            // 
            // p2
            // 
            this.p2.Text = "节点2";
            // 
            // p3
            // 
            this.p3.Text = "节点3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "节点3";
            // 
            // p3_tb
            // 
            this.p3_tb.Location = new System.Drawing.Point(459, 256);
            this.p3_tb.Name = "p3_tb";
            this.p3_tb.Size = new System.Drawing.Size(100, 21);
            this.p3_tb.TabIndex = 38;
            this.p3_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p3_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "//        ==3\r\n//  1===//==2";
            // 
            // ModifyTrackPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p3_tb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p2_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.p1_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.y_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.TrackPointListView);
            this.Name = "ModifyTrackPoint";
            this.Text = "ModifyTrackPoint";
            this.Load += new System.EventHandler(this.ModifyTrackPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox p2_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p1_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.ListView TrackPointListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p3_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader point;
        private System.Windows.Forms.ColumnHeader p1;
        private System.Windows.Forms.ColumnHeader p2;
        private System.Windows.Forms.ColumnHeader p3;
    }
}