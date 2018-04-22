using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            string[] a = StackBox1.Text.Split(new char[] { ',', ' ','/'});
            string[] b = StackBox2.Text.Split(new char[] { ',', ' ','/'});
            int s = 0;
            var stack1 = new MyStack();
            var stack2 = new MyStack();
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    stack1.Push(Convert.ToInt32(a[i]));
                }
                catch(Exception)
                {
                    ResBox.Text = "Стек(1) должен оканчиваться числом и состоять из чисел";
                }
            }
            for (int j = 0; j < b.Length; j++)
            {
                try
                {
                    stack2.Push(Convert.ToInt32(b[j]));
                }
                catch (Exception)
                {
                    ResBox.Text = "Стек(2) должен оканчиваться числом и состоять из чисел";
                }
            }
            ResBox.Text = Convert.ToString(ChangeData.CheckStack(stack1, stack2));

        }

        private void сохранитьэToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
