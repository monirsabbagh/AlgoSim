using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSim
{
    public class Bars
    {
        const int BAR_MARGIN = 5; // space between bars
        const int BAR_WIDTH = 20;

        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private int numBars;

        public void Clear()
        {
            NumBars = 0;
            BarList = null;
        }
        public Font BarsFont { get; set; }
        public bool ShowRanks { get; set; }
        public int NumBars
        {
            get
            {
                return numBars;
            }
            set
            {
                numBars = value;
                Generate();
            }
        }
        public List<Bar> BarList { get; set; }

        public void UpdateRanks(bool rank)
        {
            ShowRanks = rank;
            foreach (var item in BarList)
            {
                item.ShowRank = rank;
            }
        }
        public void Generate()
        {
            BarList = new List<Bar>(NumBars);
            for (int i = 0; i < NumBars; i++)
            {
                BarList.Add(new Bar { Value = RandomNumber(5,100), Position = i, State = BarState.Unsorted, ShowRank = ShowRanks, BarFont = BarsFont });
            }
        }

        public void Paint(Graphics g, int view_height, int view_width)
        {
            int max_value = BarList.Max(t => t.Value); // for scaling vertically 
            if (NumBars > 0 && BarList != null)
            {
                int x_shift = (view_width - BarList.Count * (BAR_WIDTH + BAR_MARGIN)) /2;
                foreach (var item in BarList)
                {
                    item.Paint(g, max_value, view_height, x_shift, BAR_WIDTH, BAR_MARGIN);
                }
            }
        }
    }
}
