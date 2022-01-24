using System;
using System.Windows.Forms;
using System.Drawing;
namespace Visualization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_Start = new Button();
            this.m_ListSize = new HScrollBar();
            this.m_QuickSort = new Button();
            this.m_HeapSort = new Button();
            this.SuspendLayout();
            // 
            // m_Start
            // 
            this.m_Start.Location = new System.Drawing.Point(1800, 25);
            this.m_Start.Name = "m_Start";
            this.m_Start.Size = new System.Drawing.Size(100, 50);
            this.m_Start.Text = "Start";
            this.m_Start.UseVisualStyleBackColor = true;
            this.m_Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // m_QuickSort
            // 
            this.m_QuickSort.Location = new System.Drawing.Point(200, 25);
            this.m_QuickSort.Name = "m_QuickSort";
            this.m_QuickSort.Size = new System.Drawing.Size(100, 50);
            this.m_QuickSort.Text = "QuickSort";
            this.m_QuickSort.UseVisualStyleBackColor = true;
            this.m_QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // m_HeapSort
            // 
            this.m_HeapSort.Location = new System.Drawing.Point(400, 25);
            this.m_HeapSort.Name = "m_HeapSort";
            this.m_HeapSort.Size = new System.Drawing.Size(100, 50);
            this.m_HeapSort.Text = "HeapSort";
            this.m_HeapSort.UseVisualStyleBackColor = true;
            this.m_HeapSort.Click += new System.EventHandler(this.HeapSort_Click);
            // 
            // m_ListSize
            // 
            this.m_ListSize.Location = new System.Drawing.Point(600, 35);
            this.m_ListSize.Name = "m_ListSize";
            this.m_ListSize.Size = new System.Drawing.Size(600, 30);
            this.m_ListSize.Scroll += new ScrollEventHandler(this.ListSize_Scroll);
            this.m_ListSize.Minimum = 0;
            this.m_ListSize.Maximum = 180;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_ListSize);
            this.Controls.Add(this.m_Start);
            this.Controls.Add(this.m_QuickSort);
            this.Controls.Add(this.m_HeapSort);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Button m_Start;
        private HScrollBar m_ListSize;
        private Button m_QuickSort;
        private Button m_HeapSort;

    }
}