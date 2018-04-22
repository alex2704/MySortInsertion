using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortInsertion
{
    public class DataGridViewHelper
    {
        public static void ArrayToDGV(DataGridView dgv, int[] arr)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 1;
            dgv.RowCount = arr.Length;

            for(int i = 0; i<arr.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }

        public static int[] DGVToArray(DataGridView dgv)
        {
            int[] arr = new int[dgv.RowCount];

            for(int i=0; i<dgv.RowCount; i++)
            {
                arr[i] = (int)Convert.ChangeType(dgv.Rows[i].Cells[0].Value, typeof(int));
            }
            return arr;
        }

        public static void ClearDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
    }
}
