using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Drawing.Design;
using DisplaySystem.Modify;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DisplaySystem
{
    public partial class Main : Form
    {
        public List<PowerSupplyModel> psModel;
        public List<TrackLine> tLine;
        public List<TrackPoint> tPoint;
        public List<Button> allButtons;
        Graphics graphic;
        bool pointShown = false;
        bool shownSettings = true;
        public string shownPowerSupplyModelName = "";

        public Main()
        {
            loadData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkEmptyObject();
            createButtons();
            checkSettings();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void checkEmptyObject()
        {
            if(tLine == null)
            {
                tLine = new List<TrackLine>();
            }
            if(tPoint == null)
            {
                tPoint = new List<TrackPoint>();
            }
            if(psModel == null)
            {
                psModel = new List<PowerSupplyModel>();
            }
            for (int j = 0; j < tLine.Count; j++)
            {//检查线里面有没有无用点

                if (tLine[j].leftTrackPoint != null)
                {
                    bool hasGotIt = false;
                    for (int i = 0; i < tPoint.Count; i++)
                    {
                        if (tPoint[i].trackPointID.Equals(tLine[j].leftTrackPoint.trackPointID))
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        tLine[j].leftTrackPoint = null;
                    }
                }
                if (tLine[j].rightTrackPoint != null)
                {
                    bool hasGotIt = false;
                    for (int i = 0; i < tPoint.Count; i++)
                    {
                        if (tPoint[i].trackPointID.Equals(tLine[j].rightTrackPoint.trackPointID))
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        tLine[j].rightTrackPoint = null;
                    }
                }

            }
        
            //检查点里面有没有无用线
            for(int iPoint  = 0;iPoint <tPoint.Count; iPoint++)
            {
                bool firstGotIt = false;
                bool secondGotIt = false;
                bool thirdGotIt = false;
                foreach(TrackLine _tLine in tLine)
                {
                    if (_tLine.trackLineID == tPoint[iPoint].firstTrackLine)
                    {
                        firstGotIt = true;
                    }
                    if (_tLine.trackLineID  == tPoint[iPoint].secondTrackLine)
                    {
                        secondGotIt = true;
                    }
                    if (_tLine.trackLineID == tPoint[iPoint].thirdTrackLine)
                    {
                        thirdGotIt = true;
                    }
                    if(firstGotIt && secondGotIt && thirdGotIt)
                    {
                        break;
                    }
                }
                if (!firstGotIt)
                {
                    tPoint[iPoint].firstTrackLine = 0;
                }
                if (!secondGotIt)
                {
                    tPoint[iPoint].secondTrackLine =  0;
                }
                if (!thirdGotIt)
                {
                    tPoint[iPoint].thirdTrackLine = 0;
                }
            }


            for(int iPS = 0; iPS < psModel.Count; iPS++)
            {
                //检查供电臂内有没有无用线
                for (int iPSLine = 0; iPSLine < psModel[iPS].containedTrackLine.Count; iPSLine++)
                {
                    bool hasGotIt = false;
                    foreach (TrackLine _tl in tLine)
                    {
                        if(psModel[iPS].containedTrackLine[iPSLine].trackLineID == _tl.trackLineID)
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        psModel[iPS].containedTrackLine.RemoveAt(iPSLine);
                        iPSLine--;
                    }
                }

                //检查供电臂内有没有无用点
                for(int iPSPoint = 0;iPSPoint < psModel[iPS].containedTrackPoint.Count; iPSPoint++)
                {
                    bool hasGotIt = false;
                    foreach (TrackPoint _tp in tPoint)
                    {
                        if (psModel[iPS].containedTrackPoint[iPSPoint].trackPointID.Equals(_tp.trackPointID))
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        psModel[iPS].containedTrackPoint.RemoveAt(iPSPoint);
                        iPSPoint--;
                    }
                }
            }
        }

        private void checkSettings()
        {
            if (shownSettings)
            {
                modifyPowerSupplyModel_btn.Visible = true;
                modifyTrackLine_btn.Visible = true;
                modifyTrackPoint_btn.Visible = true;
                save_btn.Visible = true;
                showPoint_btn.Visible = true;
            }
            else
            {
                modifyPowerSupplyModel_btn.Visible = false;
                modifyTrackLine_btn.Visible = false;
                modifyTrackPoint_btn.Visible = false;
                save_btn.Visible = false;
                showPoint_btn.Visible = false;
            }
        }

        private void loadData()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream streamLine = new FileStream(Application.StartupPath + "\\Data\\tLine.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                tLine = (List<TrackLine>)formatter.Deserialize(streamLine);
                streamLine.Close();
                tLine.Sort();
            }catch(Exception e)
            {
                tLine = new List<TrackLine>();
            }
            try
            {
                Stream streamPoint = new FileStream(Application.StartupPath + "\\Data\\tPoint.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                tPoint = (List<TrackPoint>)formatter.Deserialize(streamPoint);
                streamPoint.Close();
                tPoint.Sort();
            }catch(Exception e1)
            {
                tPoint = new List<TrackPoint>();
            }
            try
            {
                Stream streamPS = new FileStream(Application.StartupPath + "\\Data\\psModel.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                psModel = (List<PowerSupplyModel>)formatter.Deserialize(streamPS);
                streamPS.Close();
            }catch(Exception e2)
            {
                psModel = new List<PowerSupplyModel>();
            }
        }
        
        private void createButtons()
        {
            allButtons = new List<Button>();
            int count = 0;
            foreach(PowerSupplyModel _ps in psModel)
            {
                Button btn = new Button();
                btn.Parent = buttons_pnl;
                btn.Size = new Size(150,80);
                btn.Location = new Point(400 + 170*count, this.Height - 200);
                btn.BackColor = Color.White;
                btn.Name = _ps.powerSupplyID.ToString();
                btn.Text = _ps.powerSupplyName;
                btn.Font = new Font("微软雅黑", 12.0f, FontStyle.Bold);
                btn.Click += new EventHandler(btn_Click);
                this.Controls.Add(btn);
                allButtons.Add(btn);
                count++;
            }

        }

        public void refreshButtons()
        {
            foreach(Control ctl in this.Controls)
            {
                if (ctl is Button)//挑选出是按钮类型的
                {
                   foreach(Button btn in allButtons)
                    {
                        if(ctl.Text.Equals(btn.Text))
                        {
                            this.Controls.Remove(ctl);
                        }
                    }
                }
            }
            createButtons();
        }

        void btn_Click(object sender, EventArgs e)
        {//点击相应供电臂后绘制相应内容
            //MessageBox.Show("" + ((Button)sender).Name);
            string name = ((Button)sender).Text;
            shownPowerSupplyModelName = name;
            this.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否关闭程序？已做的修改将被保存。", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                saveData();
                e.Cancel = false;  //点击OK   
            }
            else
            {
                e.Cancel = true;
            }
            base.OnClosing(e);
        }

        private bool saveData(string saveText = "")
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream streamLine = new FileStream(Application.StartupPath + "\\Data\\tLine.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                formatter.Serialize(streamLine, tLine);
                streamLine.Close();
                Stream streamPoint = new FileStream(Application.StartupPath + "\\Data\\tPoint.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                formatter.Serialize(streamPoint, tPoint);
                streamPoint.Close();
                Stream streamPS = new FileStream(Application.StartupPath + "\\Data\\psModel.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                formatter.Serialize(streamPS, psModel);
                streamPS.Close();
                return true;
            }catch(Exception e)
            {
                return false;
            }

        }

        private void paintLine(TrackLine _tl)
        {
            if(_tl == null)
            {
                return;
            }
            else if (_tl.selfLeftPoint == null ||
                        _tl.selfRightPoint == null)
            {
                    return;
            }
            Point point1 = _tl.selfLeftPoint;
            Point point2 = _tl.selfRightPoint;
            String pointText = _tl.trackLineID.ToString();
            Pen p = new Pen(Color.White, 3);
            graphic.DrawLine(p, point1, point2);
            Font font = new Font("微软雅黑", 10.0f, FontStyle.Bold);
            //graphic.DrawString(pointText, base.Font, Brushes.White, 0, 0, new StringFormat(StringFormatFlags.DirectionVertical));
            if(_tl.trackLineID <= 32 || true)
            {
                graphic.DrawString(pointText, font, Brushes.White, (point1.X + point2.X) / 2, ((point1.Y + point2.Y) / 2) - 20);
            }
            Font font1 = new Font("微软雅黑", 8.0f, FontStyle.Bold);
            //graphic.DrawString(_tl.selfLeftPoint.ToString(), font1, Brushes.Yellow, point1.X, point1.Y - 20, new StringFormat(StringFormatFlags.DirectionVertical));
            //graphic.DrawString(_tl.selfRightPoint.ToString(), font1, Brushes.Yellow, point2.X, point2.Y - 20, new StringFormat(StringFormatFlags.DirectionVertical));
             //graphic.DrawString("("+_tl.selfLeftPoint.X.ToString()+",\n"+ _tl.selfLeftPoint.Y.ToString()+")", font1, Brushes.Yellow, point1.X , point1.Y - 30);
            //graphic.DrawString("(" + _tl.selfRightPoint.X.ToString() + ",\n" + _tl.selfRightPoint.Y.ToString() + ")", font1, Brushes.Yellow, point2.X, point2.Y - 30);
        }

        private void paintPoint(TrackPoint _tp)
        {
            if(_tp == null)
            {
                return;
            }
            else if(_tp.trackPoint == null)
            {
                return;
            }
            Point point = _tp.trackPoint;
            int lineText = _tp.trackPointID;
            Pen p = new Pen(Color.Red, 8);
            graphic.DrawLine(p, new Point(point.X - 4, point.Y), new Point(point.X +4, point.Y));
            Font font = new Font("微软雅黑", 10.0f, FontStyle.Bold);
            Font fontPoint = new Font("微软雅黑", 7.0f, FontStyle.Bold);
            
            graphic.DrawString(lineText.ToString(), font, Brushes.White, point.X, point.Y - 20);
            if (pointShown)
            {
                graphic.DrawString("(" +point.X.ToString() + "," + point.Y.ToString() + ")", fontPoint, Brushes.Yellow, point.X, point.Y - 30);
            }
        }

        private void paintPowerSupply(PowerSupplyModel _ps)
        {
            if (_ps == null)
            {
                return;
            }
            else if (_ps.containedTrackLine == null)
            {
                return;
            }
            Pen p = new Pen(Color.Red, 8);
            foreach(TrackLine _tl in _ps.containedTrackLine)
            {
                Point[] sbxAll = new Point[]{
                new Point(_tl.selfLeftPoint.X, _tl.selfLeftPoint.Y + 15),
                new Point(_tl.selfRightPoint.X, _tl.selfRightPoint.Y + 15),
               new Point(_tl.selfRightPoint.X, _tl.selfRightPoint.Y - 15),
                new Point(_tl.selfLeftPoint.X, _tl.selfLeftPoint.Y - 15)
                };
                Point[] sbxLeftIn = new Point[]{
                new Point(_tl.selfLeftPoint.X, _tl.selfLeftPoint.Y + 15),
                new Point((_tl.selfRightPoint.X + _tl.selfLeftPoint.X)/2, (_tl.selfLeftPoint.Y+_tl.selfRightPoint.Y)/2 + 15),
                new Point((_tl.selfRightPoint.X + _tl.selfLeftPoint.X)/2, (_tl.selfLeftPoint.Y+_tl.selfRightPoint.Y)/2 - 15),
                new Point(_tl.selfLeftPoint.X, _tl.selfLeftPoint.Y - 15)
                };
                Point[] sbxRightIn = new Point[]{
                new Point((_tl.selfRightPoint.X + _tl.selfLeftPoint.X)/2, (_tl.selfLeftPoint.Y+_tl.selfRightPoint.Y)/2 + 15),
                new Point(_tl.selfRightPoint.X, _tl.selfRightPoint.Y + 15),
                new Point(_tl.selfRightPoint.X, _tl.selfRightPoint.Y - 15),
                new Point((_tl.selfRightPoint.X + _tl.selfLeftPoint.X)/2, (_tl.selfLeftPoint.Y+_tl.selfRightPoint.Y)/2 - 15)
                };
                if (_tl.containsInPS == 0)
                {//绘制全部区域(上15，下15)
                    graphic.FillPolygon(new SolidBrush(Color.FromArgb(125, Color.LightYellow)), sbxAll);
                }else if(_tl.containsInPS == 1)
                {//绘制左半在内
                    graphic.FillPolygon(new SolidBrush(Color.FromArgb(125, Color.LightYellow)), sbxLeftIn);
                }
                else if (_tl.containsInPS == 2)
                {//绘制右半在内
                    graphic.FillPolygon(new SolidBrush(Color.FromArgb(125, Color.LightYellow)), sbxRightIn);
                }

            }
            Font font = new Font("微软雅黑", 10.0f, FontStyle.Bold);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public void selfPaint(Graphics g = null)
        {

            if (graphic== null)
            {
                if(g == null)
                {
                    graphic = this.CreateGraphics();
                }
                else
                {
                    graphic = g;
                }

            }
            foreach (TrackLine _tl in tLine)
            {
                paintLine(_tl);
            }
            foreach (TrackPoint _tp in tPoint)
            {
                paintPoint(_tp);
            }
            foreach(PowerSupplyModel _ps in psModel)
            {
                if (_ps.powerSupplyName.Equals(shownPowerSupplyModelName))
                {
                    paintPowerSupply(_ps);
                }
            }
            
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            graphic = e.Graphics;
            selfPaint(e.Graphics);
        }
        

        public void updateTrackPoint(List<TrackPoint> _tPoint)
        {
            tPoint = _tPoint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyTrackLine form = new ModifyTrackLine(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyTrackPoint form = new ModifyTrackPoint(this);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifyPowerSupplyModel form = new ModifyPowerSupplyModel(this);
            form.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saveData("自动");
        }

        private void showPoint_btn_Click(object sender, EventArgs e)
        {
            if (!pointShown)
            {
                pointShown = true;
                this.Refresh();
            }
            else
            {
                pointShown = false;
                this.Refresh();
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int count = 0;
            if(allButtons == null)
            {
                return;
            }
            foreach(Button btn in allButtons)
            {
                btn.Location  = new Point(400 + 170 * count, this.Height - 200);
                count++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (shownSettings)
            {
                shownSettings = false;
                checkSettings();
            }
            else
            {
                shownSettings = true;
                checkSettings();
            }
        }
    }
}
