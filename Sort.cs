using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSim
{
    public abstract class Sort
    {
        public Sort(Bars data) {
            SortData = data;
        }
        protected Bars SortData;
        public bool Done { get; set; }

        protected void swap(int first, int second) 
        {
            int temp = SortData.BarList[first].Position;
            SortData.BarList[first].Position = SortData.BarList[second].Position;
            SortData.BarList[second].Position = temp;

            Bar tmpBar = SortData.BarList[first];
            SortData.BarList[first] = SortData.BarList[second];
            SortData.BarList[second] = tmpBar;
        }

        public abstract void InitSort();
        public abstract void Step();
    }
}
