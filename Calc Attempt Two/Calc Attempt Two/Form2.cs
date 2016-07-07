using System;
using System.Windows.Forms;
using Calc_Attempt_Two.Sorting;

namespace Calc_Attempt_Two
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] stringArray = textBox2.Text.Split(',');
            int[] array = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = int.Parse(stringArray[i]);
            }
            ISortingSorter sorter = SortingFactory.SortArray(((Button) sender).Name);
            int[] result = sorter.Sort(array);
            foreach (int t in result)
            {
                textBox3.Text += t + " ";
            }
        }

    }
}
