using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visualization
{
    public class HeapSort
    {
        public static void Sort(List<int> i_Numbers, List<Button> i_Buttons)
        {
            int n = i_Numbers.Count;

            for(int i = n/2 - 1; i >= 0; i--)
            {
                Heapify(i_Numbers, i_Buttons, n, i);
            }

            for(int i = n-1 ; i > 0; i--)
            {
                QuickSort.Swap(i_Numbers, i_Buttons, 0, i);
                Heapify(i_Numbers, i_Buttons, i, 0);
            }
        }

        public static void Heapify(List<int> i_Numbers, List<Button> i_Buttons, int i_N, int i_I)
        {
            int largest = i_I;
            int left = 2 * i_I + 1;
            int right = 2 * i_I + 2;

            if(left < i_N && i_Numbers[left] > i_Numbers[largest])
            {
                largest = left;
            }
            if (right < i_N && i_Numbers[right] > i_Numbers[largest])
            {
                largest = right;
            }

            if(largest != i_I)
            {
                QuickSort.Swap(i_Numbers, i_Buttons, i_I, largest);
                Heapify(i_Numbers, i_Buttons, i_N, largest);
            }
        }
    }
}
