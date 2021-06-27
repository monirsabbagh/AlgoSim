using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cb_numItems.SelectedIndex = 2;
            cb_sort.SelectedIndex = 0;
            DoubleBuffered = true;
            ResizeRedraw = true;
            tb_speed.Value = tb_speed.Maximum / 2;
        }
       
        // Cache font instead of recreating font objects each time we paint.
        private Font fnt = new Font("Consolas", 10);
        private Sort currentSort;
        private Bars bars;
        private bool AutoSort;

        private void pb_board_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bars.Paint(e.Graphics, pb.Height, pb.Width);
        }

        private void pb_board_Resize(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Refresh();
        }

        private void ResetRort() 
        {
            switch (cb_sort.SelectedIndex)
            {
                case 0:
                    currentSort = new SortBubble(bars);
                    currentSort.InitSort();
                    break;
                default:
                    break;
            }
            pb_board.Refresh();
            AutoSort = false;
            timer_sort.Enabled = false;
            UpdateForm();
        }
        private void cb_numItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            bool ranks = ckb_showRanks.Checked;
            int numBars = 0;
            switch (cb.SelectedIndex)
            {
                case 0:
                    numBars = 5;
                    break;
                case 1:
                    numBars = 15;
                    break;
                case 2:
                    numBars = 35;
                    break;
                case 3:
                    numBars = 50;
                    break;
            }

            bars = new Bars() { ShowRanks = ranks, BarsFont = fnt, NumBars = numBars };
            pb_board.Refresh();
            ResetRort();
        }

        private void ckb_showRanks_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox ckb = sender as CheckBox;
            bars.UpdateRanks(ckb.Checked);
            pb_board.Refresh();
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sort.SelectedIndex != 0)
            {
                // only bubble sort currently is working
                cb_sort.SelectedIndex = 0;
            }
            ResetRort();
        }

        private void btn_rand_Click(object sender, EventArgs e)
        {
            bars = new Bars() { ShowRanks = bars.ShowRanks, BarsFont = fnt, NumBars = bars.NumBars };
            pb_board.Refresh();
            ResetRort();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            AutoSort = true;
            timer_sort.Enabled = true;
            UpdateForm();
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            currentSort.Step();
            pb_board.Refresh();
            UpdateForm();
        }

        private void UpdateForm()
        {
            if (currentSort == null || currentSort.Done)
            {
                btn_step.Enabled = false;
                btn_pause.Enabled = false;
                btn_run.Enabled = false;
            }
            else
            {
                btn_step.Enabled = !AutoSort;
                btn_run.Enabled = !AutoSort;
                btn_pause.Enabled = AutoSort;
            }

        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            AutoSort = false;
            timer_sort.Enabled = false;
            UpdateForm();
        }

        private void timer_sort_Tick(object sender, EventArgs e)
        {
            currentSort.Step();
            pb_board.Refresh();
            UpdateForm();
        }

        private void tb_speed_ValueChanged(object sender, EventArgs e)
        {
            timer_sort.Interval = tb_speed.Value * 50 + 1;
        }
    }
}
