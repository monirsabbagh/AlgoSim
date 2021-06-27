using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSim
{
    public enum BarState
    {
        Unsorted, Sorted, BeingSort
    }
    public class Bar
    {
        public Bar()
        {
            ShowRank = false;
            Value = 0;
        }
        public Font BarFont { get; set; }
        public BarState State { get; set; }
        public int Position { get; set; }
        public bool ShowRank { get; set; }
        public int Value { get; set; }
        public void Paint(Graphics g, int max_value, int view_height, int x_shift, int bar_width, int bar_margin)
        {
            Pen pen = null;
            switch (State)
            {
                case BarState.Unsorted:
                    pen = Pens.LightGray;
                    break;
                case BarState.Sorted:
                    pen = Pens.Black;
                    break;
                case BarState.BeingSort:
                    pen = Pens.Firebrick;
                    break;
                default:
                    break;
            }
            int barHeight = (view_height - bar_margin * 2) * Value / (max_value + bar_margin * 2);
            int x = Position * (bar_width + bar_margin) + x_shift;
            int y = view_height - bar_margin - barHeight;

            Rectangle rect = new Rectangle(x, y, bar_width, barHeight);
            g.FillRectangle(new SolidBrush(pen.Color), rect);
            g.DrawRectangle(Pens.Black, rect);
            if (ShowRank)
            {
                string txt = Value.ToString();
                SizeF size = g.MeasureString(txt, BarFont);
                int txtHeight = (int)Math.Round(size.Height);
                int txtWidth = (int)Math.Round(size.Width);
                g.DrawString(txt, BarFont, new SolidBrush(Pens.Black.Color), new Point(x + (bar_width -txtWidth) / 2, y - txtHeight));
            }
        }
    }
}
