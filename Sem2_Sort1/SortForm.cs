﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_Sort1
{
    public partial class SortForm : Form
    {
        static Graphics g;
        int[] startArr;

        public SortForm()
        {
            InitializeComponent();
        }

        private void _pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

        // функция для того, чтобы не вводить одни и те же аргументы каждый раз при вызове Drawing.Draw
        private void DrawFrame(PictureBox pbox, int[]arr, int fillSmaller, int fillBigger, int showSelected) 
        {
            pbox.Image = Drawing.Draw(g, arr, 10, 10, 70, 60, 80, fillSmaller, fillBigger, showSelected);
            _pause(700);
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            startArr = ArraySort.RandomArray((int)numericUpDown.Value);  // создание массива случайных чисел 
            DrawFrame(BubblePictureBox, startArr, -1, -1, -2);
            DrawFrame(ShakerPictureBox, startArr, -1, -1, -2);
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown.Value];
            Array.Copy(startArr, arr,(int)numericUpDown.Value);

            for (int i = 1; i < arr.Length; i++)
                for (int j = arr.Length - 1; j >= i; j--)
                {
                    DrawFrame(BubblePictureBox, arr, - 1, -1, j - 1);
                    if (arr[j - 1] > arr[j])
                    {
                        DrawFrame(BubblePictureBox, arr, j, j - 1, -2);
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        DrawFrame(BubblePictureBox, arr, j - 1, j, -2);
                    }
                }
            DrawFrame(BubblePictureBox, arr, -1, -1, -2);
        }

        private void ShakerButton_Click(object sender, EventArgs e)  // не разобрался с этой сортировкой. Скорее всего, показывает неправильно. Посмотреть видео и разобраться.
        {
            int[] arr = new int[(int)numericUpDown.Value];
            Array.Copy(startArr, arr, (int)numericUpDown.Value);

            if(arr.Count() != 1)
            {
                int left = 1, right = arr.Length - 1, last = right;
                do
                {
                    for (int j = right; j >= left; j--)
                    {
                        DrawFrame(ShakerPictureBox, arr, -1, -1, j - 1);
                        if (arr[j - 1] > arr[j])
                        {
                            DrawFrame(ShakerPictureBox, arr, j, j - 1, -2);
                            int t = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = t;
                            last = j;
                            DrawFrame(ShakerPictureBox, arr, j - 1, j, -2);
                        }
                    }
                    left = last;
                    for (int j = left; j <= right; j++)
                    {
                        DrawFrame(ShakerPictureBox, arr, -1, -1, j - 1);
                        if (arr[j - 1] > arr[j])
                        {
                            DrawFrame(ShakerPictureBox, arr, j, j - 1, -2);
                            int t = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = t;
                            last = j;
                            DrawFrame(ShakerPictureBox, arr, j - 1, j, -2);
                        }
                    }
                    right = last - 1;

                }
                while (left < right);
            }
            DrawFrame(ShakerPictureBox, arr, -1, -1, -2);
        }

        private void ChartsButton_Click(object sender, EventArgs e)
        {
            ChartsForm chForm = new ChartsForm();
            for (int i = 100; i <= 2000; i+=100)
            {
                int[] bubble = ArraySort.RandomArray(i);
                int[] shaker = new int[i];
                Array.Copy(bubble, shaker, i);
                int compareCount, changeCount;
                ArraySort.BubbleSort(bubble, out compareCount, out changeCount);
                chForm.compareChart.Series[0].Points.AddXY(i, compareCount);
                chForm.changeChart.Series[0].Points.AddXY(i, changeCount);
                ArraySort.ShakerSort(shaker, out compareCount, out changeCount);
                chForm.compareChart.Series[1].Points.AddXY(i, compareCount);
                chForm.changeChart.Series[1].Points.AddXY(i, changeCount);
            }
            chForm.Show();
        }
    }
}
