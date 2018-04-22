using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var queue1 = new MyQueue();
            var queue2 = new MyQueue();
            string[] arr1 = queueBox1.Text.Split(new char[] { ',', ' ', '/' });
            string[] arr2 = queueBox2.Text.Split(new char[] { ',', ' ', '/' });
            for(int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    queue1.Push(Convert.ToDouble(arr1[i]));
                }
                catch (Exception)
                {
                    throw new ArgumentException("Ошибка при считывании аргумента:{0} в очереди 1", arr1[i]);
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                try
                {;
                    queue2.Push(Convert.ToDouble(arr2[i]));
                }
                catch (Exception)
                {
                    throw new ArgumentException("Ошибка при считывании аргумента:{0} в очереди 1", arr1[i]);
                }
            }
            ResultBox.Text = Convert.ToString(ChangeData.CheckQueue(queue1, queue2));
        }
    }
}
