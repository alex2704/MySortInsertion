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

namespace BinSort
{
    public partial class SortSolution : Form
    {
        public SortSolution()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string[] arr = ReadBox.Text.Split(new Char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                mas[i] = Convert.ToInt32(arr[i]);
            }
            foreach (var item in ChangeData.SortBinInsert(mas))
            {
                ResultBox.Text = ResultBox.Text + ' ' + Convert.ToString(item);
            }
        }

        private void SortButtonSimple_Click(object sender, EventArgs e)
        {

            string[] arr = ReadBox.Text.Split(new Char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                mas[i] = Convert.ToInt32(arr[i]);
            }
            foreach(var item in ChangeData.SortInsertion(mas))
            {
                ResultBox.Text = ResultBox.Text + ' ' + Convert.ToString(item);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                int[] arr = DataIO.ReadFromFile(path);
                for(int i = 0; i < arr.Length; i++)
                {
                    ReadBox.Text=ReadBox.Text+' '+ Convert.ToString(arr[i]);
                }
            }
        }

        private void LoadChart_Click(object sender, EventArgs e)
        {
            this.chart1.Series["SimplySortInsertion"].Points.AddXY("Max", 33);
            this.chart1.Series["SortBinInsertion"].Points.AddXY("Max", 90);

            this.chart1.Series["SimplySortInsertion"].Points.AddXY("Mark", 55);
            this.chart1.Series["SortBinInsertion"].Points.AddXY("Mark", 70);

            this.chart1.Series["SimplySortInsertion"].Points.AddXY("Alli", 50);
            this.chart1.Series["SortBinInsertion"].Points.AddXY("Alli", 43);

        }
    }
}
