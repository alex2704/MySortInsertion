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
using System.Drawing;

namespace SortInsertion
{
    public partial class SortComprasion : Form
    {
        public SortComprasion()
        {
            InitializeComponent();
        }

        private void SortComprasion_Load(object sender, EventArgs e)
        {
            //Инициализация DGV для ввода массива
            DataGridViewUtils.InitGridForArr(sourceArrayDGV, 70, false, true, false, true, false);
            sourceArrayDGV.RowCount = 1;
        }

        private void fillBtn_Click(object sender, EventArgs ev)
        {
            try
            {
                string elementsCountValue = MessagesUtils.Prompt("Укажите колисчетсво элементов массива", "Ввод массива");

                if (elementsCountValue == null)
                    return;

                int elementsCount = int.Parse(elementsCountValue);
                if (elementsCount <= 0) throw new Exception();
                int[] arr = ArrayUtils.GenerateRandomArray(elementsCount, -100, 100);

                DataGridViewHelper.ArrayToDGV(sourceArrayDGV, arr);
            }
            catch (Exception e)
            {
                MessagesUtils.ShowError("Укажите корректное значение");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.ClearDGV(sourceArrayDGV);
            sourceArrayDGV.RowCount = 1;
        }

        private void shuffleBtn_Click(object sender, EventArgs ev)
        {
            try
            {
                int[] arr = DataGridViewHelper.DGVToArray(sourceArrayDGV);
                ArrayUtils.ShuffleArray(arr);

                DataGridViewHelper.ArrayToDGV(sourceArrayDGV, arr);
            }
            catch (Exception e)
            {
                MessagesUtils.ShowError("Проверьте правильность введенных данных");
            }
        }

        private void mainMenu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenu_File_Open_Click(object sender, EventArgs ev)
        {
            try
            {
                if (OpenFileDlg.ShowDialog() != DialogResult.OK)
                    return;

                int[] arr = DataConverter.StrToArray<int>(DataIO.ReadFileToStr(OpenFileDlg.FileName));

                DataGridViewHelper.ArrayToDGV(sourceArrayDGV, arr);
            }
            catch(Exception e)
            {
                MessagesUtils.ShowError("Проверьте корректность ваших данных");
            }
        }

        private void demonstrateBtn_Click(object sender, EventArgs e)
        {
            int[] arr = DataGridViewHelper.DGVToArray(sourceArrayDGV);

            Bitmap bitmap = Renderer.DrawArrayToBitmap(demonstrarionCanvasPanel.Width, demonstrarionCanvasPanel.Height, arr, new HashSet<int>() {1,2 }, Renderer.HighlightType.Comparison);

            demonstrarionCanvasPanel.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void SortBtn_Click(object sender, EventArgs ev)
        {
            //try
            //{
                int[] arr = DataGridViewHelper.DGVToArray(sourceArrayDGV);

                Sorter.SortInsertion(arr, out SortReport report);

                DataGridViewHelper.ArrayToDGV(sourceArrayDGV, arr);
            //}
            //catch (Exception e)
            //{
            //    MessagesUtils.ShowError("Проверьте корректность ваших данных");
            //}
        }
    }
}
