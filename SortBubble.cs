using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSim
{
    public class SortBubble : Sort
    {
        public int stepNum { get; set; }
        private bool swapped;
        private int last_unsorted;
        private int current_index;

        private bool prepare;

        public SortBubble(Bars data) : base(data)
        {
            InitSort();
        }
        public override void InitSort()
        {
            stepNum = 0;
            current_index = 0;
            swapped = false;
            prepare = true;
            last_unsorted = SortData.NumBars - 1;
            Done = false;
        }

        public override void Step()
        {
            stepNum++;
            if (current_index == last_unsorted)
            {
                SortData.BarList[last_unsorted].State = BarState.Sorted;
                if (!swapped)
                {
                    if (prepare)
                    {
                        prepare = false;
                    }
                    else
                    {
                        foreach (var item in SortData.BarList)
                        {
                            item.State = BarState.Sorted;
                        }
                        Done = true;
                    }
                }
                else
                {
                    last_unsorted--;
                    swapped = false;
                    current_index = 0;
                }
            }
            else
            {
                if (prepare)
                {
                    foreach (var item in SortData.BarList)
                    {
                        if(item.State==BarState.BeingSort)
                        {
                            item.State = BarState.Unsorted;
                        }
                    }
                    SortData.BarList[current_index].State = BarState.BeingSort;
                    SortData.BarList[current_index + 1].State = BarState.BeingSort;
                    prepare = false;
                }
                else
                {
                    if (SortData.BarList[current_index].Value > SortData.BarList[current_index + 1].Value)
                    {
                        swap(current_index, current_index + 1);
                        swapped = true;
                    }
                    current_index++;
                    prepare = true;
                }
            }
         }
    }
}
