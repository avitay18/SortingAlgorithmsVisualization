using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Timers;

namespace Visualization
{
    public class QuickSort
    {
        public static void Swap(List<int> i_Numbers, List<Button> i_Buttons, int i_I, int i_J)
        {
            
            int tempNumber = i_Numbers[i_I];
            int tempLeft = i_Buttons[i_I].Left;
            Button tempButton = i_Buttons[i_I];
            i_Numbers[i_I] = i_Numbers[i_J];
            i_Buttons[i_I].BackColor = Color.Green;
            i_Buttons[i_J].BackColor = Color.Red;
            wait(15);
            i_Buttons[i_I].Left = i_Buttons[i_J].Left;
            i_Buttons[i_I] = i_Buttons[i_J]; 
            i_Numbers[i_J] = tempNumber;
            i_Buttons[i_J].Left = tempLeft;
            i_Buttons[i_J] = tempButton;
            i_Buttons[i_I].BackColor = default(Color);
            i_Buttons[i_J].BackColor = default(Color);
        }

        public static void ColorButtons(List<Button> i_Buttons)
        {
            foreach(Button button in i_Buttons)
            {
                button.BackColor = Color.Blue;
                wait(1);
            }
        }
        public static int Partition(List<int> i_Numbers, List<Button> i_Buttons, int i_Low, int i_High)
        {
            int pivot = i_Numbers[i_High];
            int i = i_Low - 1;

            for(int j = i_Low; j <= i_High; j++)
            {
                if(i_Numbers[j] < pivot)
                {
                    i++;
                    Swap(i_Numbers, i_Buttons, i, j);
                }
            }
            Swap(i_Numbers, i_Buttons, i+1, i_High);
            return (i + 1);
        }
        private static void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public static void QuickSortAlgoritm(List<int> i_Numbers, List<Button> i_Buttons, int i_Low, int i_High)
        {
            if(i_Low < i_High)
            {
                int partitionIndex = Partition(i_Numbers, i_Buttons, i_Low, i_High);

                QuickSortAlgoritm(i_Numbers, i_Buttons, i_Low , partitionIndex - 1);
                QuickSortAlgoritm(i_Numbers, i_Buttons, partitionIndex + 1, i_High);
            }
        }
    }
}
