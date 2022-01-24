using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public partial class MainForm : Form
    {
        private Random m_Rand = new Random();
        private List<int> m_RandomNumbersList = new List<int>();
        private int m_ListSizeToInt;
        private List<Button> m_Buttons = new List<Button>();
        private Button m_Button;
        private eAlgorithm m_CurrentAlgorith;
        private enum eAlgorithm
        {
            Quicksort = 1,
            Heapsort
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            switch(this.m_CurrentAlgorith)
            {
                case eAlgorithm.Quicksort:
                    QuickSort.QuickSortAlgoritm(this.m_RandomNumbersList, this.m_Buttons, 0, this.m_ListSizeToInt - 1);
                    QuickSort.ColorButtons(this.m_Buttons);
                    break;
                case eAlgorithm.Heapsort:
                    HeapSort.Sort(this.m_RandomNumbersList, this.m_Buttons);
                    QuickSort.ColorButtons(this.m_Buttons);
                    break;
            }
        }
        private void QuickSort_Click(object sender, EventArgs e)
        {
            this.m_CurrentAlgorith = eAlgorithm.Quicksort;
        }
        private void HeapSort_Click(object sender, EventArgs e)
        {
            this.m_CurrentAlgorith = eAlgorithm.Heapsort;
        }
        private void createListButtons()
        {
            int y = 1000;
            int x = 50;
            for(int i = 0; i < this.m_RandomNumbersList.Count; i++)
            {
                this.m_Button = new Button();
                this.m_Button.Size = new Size(10, 8 * m_RandomNumbersList[i]);
                this.m_Button.Location = new Point(x, y - 8 * m_RandomNumbersList[i]);
                this.m_Button.Tag = this.m_RandomNumbersList[i];
                x += 10;
                this.m_Button.Enabled = false;
                this.m_Buttons.Add(this.m_Button);
            }
        }
        public List<Button> Buttons
        {
            get
            {
                return this.m_Buttons;
            }
        }
        public List<int> RandomNumbersList
        {
            get
            {
                return this.m_RandomNumbersList;
            }
        }
        private void showListOfButtons()
        {
            foreach(Button button in this.m_Buttons)
            {
                this.Controls.Add(button);
            }
        }
        private void generateRandomList()
        {
            this.m_RandomNumbersList.Clear();
            for (int i = 0; i < this.m_ListSizeToInt; i++)
            {
                m_RandomNumbersList.Add(this.m_Rand.Next(1,100));
            }
        }
        private void removeListOfButtons()
        {
            foreach(Button button in this.m_Buttons)
            {
                this.Controls.Remove(button);
            }
            this.m_Buttons.Clear();
        }
        private void ListSize_Scroll(object sender, ScrollEventArgs e)
        {
            removeListOfButtons();
            this.m_ListSizeToInt = (sender as ScrollBar).Value;
            generateRandomList();
            createListButtons();
            showListOfButtons();
        }
    }
}
