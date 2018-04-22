using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortInsertion
{
    public class Sorter
    {
        public static void SortInsertion(int[] arr, out SortReport report)
        {
            SortInsertionImplementation(false, 0, 0, arr,out report);
        }



        public static void SortInsertionRender(int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            SortInsertionImplementation(true, canvasWidth, canvasHeight, arr, out report);
        }

        private static void SortInsertionImplementation(bool render, int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            report = (render) ? new SortReport(canvasWidth, canvasHeight) : new SortReport();
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int temp = arr[j];
                while(j>0 && temp < arr[j - 1])
                {
                    if (Compare(arr, j, j-1, report) == -1)
                    {
                        Swap(arr, j, j - 1, report);
                        //arr[j] = arr[j - 1];
                        //j--;
                    }
                }
                arr[j] = temp;
            }
        }

        private static int Compare(int[] arr, int index1, int index2, SortReport report)
        {
            report.ComparisonsCount++;
            if (report.Render)
            {
                RenderComparison(arr, index1, index2, report); 
            }
            return (arr[index1] == arr[index2]) ? 0 : (arr[index1] > arr[index2]) ? 1 : -1;
        }

        private static void Swap(int[] arr, int index1, int index2, SortReport report)
        {
            report.SwapsCount++;
            if (report.Render)
            {
                RenderSwap(arr, index1, index2, report);
            }
            arr[index2] = arr[index2-1];
            index2--;

            if (report.Render)
            {
                RenderComparison(arr, index1, index2, report);
            }

        }

        private static void RenderComparison(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Renderer.DrawArrayToBitmap(report.CanvasWidth, report.CanvasHeight, arr, new HashSet<int>() {index1,index2 }, Renderer.HighlightType.Comparison));
        }
        private static void RenderSwap(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Renderer.DrawArrayToBitmap(report.CanvasWidth, report.CanvasHeight, arr, new HashSet<int>() { index1, index2 }, Renderer.HighlightType.Swap));
        }
    }
}
