using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace Sem2_Sort1
{
    public partial class SortForm : Form
    {
        static Graphics g;
        int[] arr;

        public SortForm()
        {
            InitializeComponent();
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            arr = ArraySort.RandomArray((int)numericUpDown.Value);  // создание массива случайных чисел 

        }
    }
}
