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

namespace ListApp
{
    public partial class MyAwesomeListForm : Form
    {
        public MyAwesomeListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        MyList list;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                list = new MyList();
                int[] arr = DataIO.ReadFromFile(path);
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    list.Add(arr[i]);
                }
                ResultBox.Text = list.Printer();
            }
        }
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                string[] arr = TextBox.Text.Split(new Char[] { ',', ' ' });
                DataIO.WriteToFile(arr, path);
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            TextBox.Text = Convert.ToString(list.CountMax());
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
