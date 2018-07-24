using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisplaySystem.Modify
{
    public partial class ModifyPowerSupplyModel : Form
    {
        List<PowerSupplyModel> psModel;
        List<TrackLine> tLine;
        List<TrackPoint> tPoint;

        Main main;
        public ModifyPowerSupplyModel(Main _main)
        {
            main = _main;
            psModel = _main.psModel;
            tLine = _main.tLine;
            tPoint = _main.tPoint;
            InitializeComponent();
        }

        private void ModifyPowerSupplyModel_Load(object sender, EventArgs e)
        {
            initUI(false);
            radioButton1.Checked = true;
        }

        private void initUI(bool refreshMode)
        {//false为首次，true为后续增删后
            ps_lv.Items.Clear();
            foreach (PowerSupplyModel _psModel in psModel)
            {
                ListViewItem lvi = new ListViewItem(_psModel.powerSupplyID.ToString());
                lvi.SubItems.Add(_psModel.powerSupplyName.ToString());
                ps_lv.Items.Add(lvi);
            }
            ps_lv.Update();
            if (!refreshMode)
            {
                otherPoints_lv.Items.Clear();
                otherTracks_lv.Items.Clear();
                foreach (TrackLine _line in tLine)
                {
                    ListViewItem lvi = new ListViewItem(_line.trackLineID.ToString());
                    lvi.SubItems.Add(_line.trackText.ToString());
                    otherTracks_lv.Items.Add(lvi);
                }
                foreach (TrackPoint _point in tPoint)
                {
                    ListViewItem lvi = new ListViewItem(_point.trackPointID.ToString());
                    lvi.SubItems.Add(_point.trackPoint.ToString());
                    otherPoints_lv.Items.Add(lvi);
                }
                otherPoints_lv.Update();
                otherTracks_lv.Update();
            }

        }

        private void refreshListViews(PowerSupplyModel _psModel)
        {//传空为清空表格
            containPoints_lv.Items.Clear();
            containTracks_lv.Items.Clear();
            if(_psModel != null)
            {
                foreach (TrackPoint _tp in _psModel.containedTrackPoint)
                {
                    ListViewItem lvi_Point = new ListViewItem(_tp.trackPointID.ToString());
                    lvi_Point.SubItems.Add(_tp.trackPoint.ToString());
                    if(_tp.switchDirection == 1)
                    {
                        lvi_Point.SubItems.Add("定位");
                    }else if(_tp.switchDirection == 2)
                    {
                        lvi_Point.SubItems.Add("反位");
                    }
                    bool hasGotIt = false;
                    for(int ij = 0; ij < tPoint.Count; ij++)
                    {
                        if (tPoint[ij].trackPointID.Equals(_tp.trackPointID))
                        {
                            lvi_Point.SubItems.Add(ij.ToString());
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (hasGotIt)
                    {
                        containPoints_lv.Items.Add(lvi_Point);
                    }
                }
                foreach (TrackLine _tl in _psModel.containedTrackLine)
                {
                    ListViewItem lvi_Line = new ListViewItem(_tl.trackLineID.ToString());
                    lvi_Line.SubItems.Add(_tl.trackText.ToString());
                    bool hasGotIt = false;
                    for (int ij = 0; ij < tLine.Count; ij++)
                    {
                        if (tLine[ij].trackLineID.Equals(_tl.trackLineID))
                        {
                            lvi_Line.SubItems.Add(ij.ToString());
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (hasGotIt)
                    {
                        containTracks_lv.Items.Add(lvi_Line);
                    }
                }
                containPoints_lv.Update();
                containTracks_lv.Update();
            }
            else
            {
                return;
            }

        }

        private void id_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void ModifyPowerSupplyModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.psModel = this.psModel;
            main.Refresh();
        }

        private void removeText()
        {
            id_tb.Text = "";
            name_tb.Text = "";
            containPoints_lv.Items.Clear();
            containTracks_lv.Items.Clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(id_tb.Text.Length != 0 &&
                name_tb.Text.Length != 0)
            {
                try
                {
                    PowerSupplyModel _psModel = new PowerSupplyModel();
                    _psModel.powerSupplyID = int.Parse(id_tb.Text);
                    _psModel.powerSupplyName = name_tb.Text;
                    List<TrackPoint> _tpList = new List<TrackPoint>();
                    List<TrackLine> _tlList = new List<TrackLine>();
                    if (containPoints_lv.Items.Count != 0)
                    {
                        foreach(ListViewItem lvi in containPoints_lv.Items)
                        {
                            TrackPoint _tp = tPoint[int.Parse(lvi.SubItems[3].Text)];
                            if(lvi.SubItems[2] != null)
                            {
                                if (lvi.SubItems[2].Text.Contains("定"))
                                {
                                    _tp.switchDirection = 1;
                                }else if (lvi.SubItems[2].Text.Contains("反"))
                                {
                                    _tp.switchDirection = 2;
                                }
                            }
                            _tpList.Add(_tp);
                        }
                    }
                    if (containTracks_lv.Items.Count != 0)
                    {
                        foreach (ListViewItem lvi in containTracks_lv.Items)
                        {
                            TrackLine _tline = tLine[int.Parse(lvi.SubItems[2].Text)];
                            _tlList.Add(_tline);
                        }
                    }
                    _psModel.containedTrackLine = _tlList;
                    _psModel.containedTrackPoint = _tpList;
                    if(ps_lv.SelectedItems.Count  != 0)
                    {
                        psModel.RemoveAt(ps_lv.SelectedItems[0].Index);
                    }
                    psModel.Add(_psModel);
                    initUI(true);
                    removeText();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString().Split('。')[0] + "。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("请填写左边框内ID和名称","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void ps_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ps_lv.SelectedItems.Count == 0)
            {
                refreshListViews(null);
                removeText();
            }
            else
            {
                id_tb.Text = ps_lv.SelectedItems[0].SubItems[0].Text;
                name_tb.Text = ps_lv.SelectedItems[0].SubItems[1].Text;
                refreshListViews(psModel[ps_lv.SelectedItems[0].Index]);
            }
        }

        private void addTrack_btn_Click(object sender, EventArgs e)
        {
            if(otherTracks_lv.SelectedItems.Count != 0)
            {
                ListViewItem lvi = new ListViewItem(otherTracks_lv.SelectedItems[0].SubItems[0].Text);
                lvi.SubItems.Add(otherTracks_lv.SelectedItems[0].SubItems[1].Text);
                lvi.SubItems.Add(otherTracks_lv.SelectedItems[0].Index.ToString());
                containTracks_lv.Items.Add(lvi);
                containTracks_lv.Update();
            }
        }

        private void addPoint_btn_Click(object sender, EventArgs e)
        {
            if(otherPoints_lv.SelectedItems.Count != 0)
            {
                ListViewItem lvi = new ListViewItem(otherPoints_lv.SelectedItems[0].SubItems[0].Text);
                lvi.SubItems.Add(otherPoints_lv.SelectedItems[0].SubItems[1].Text);
                if (radioButton1.Checked)
                {
                    lvi.SubItems.Add("定位");
                }else if (radioButton2.Checked)
                {
                    lvi.SubItems.Add("反位");
                }
                lvi.SubItems.Add(otherPoints_lv.SelectedItems[0].Index.ToString());
                containPoints_lv.Items.Add(lvi);
                containPoints_lv.Update();
            }
        }

        private void deleteTrack_btn_Click(object sender, EventArgs e)
        {
            if(containTracks_lv.SelectedItems.Count != 0)
            {
                containTracks_lv.Items.RemoveAt(containTracks_lv.SelectedItems[0].Index);
                containTracks_lv.Update();
            }
        }

        private void deletePoint_btn_Click(object sender, EventArgs e)
        {
            if (containPoints_lv.SelectedItems.Count != 0)
            {
                containPoints_lv.Items.RemoveAt(containPoints_lv.SelectedItems[0].Index);
                containPoints_lv.Update();
            }
        }

        private void modifyPoint_btn_Click(object sender, EventArgs e)
        {
            if (containTracks_lv.SelectedItems.Count != 0)
            {

            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(ps_lv.SelectedItems.Count != 0)
            {
                psModel.RemoveAt(ps_lv.SelectedItems[0].Index);
                removeText();
                initUI(true);
            }
        }
    }
}
