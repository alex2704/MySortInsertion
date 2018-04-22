using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using System.Drawing;

namespace SortInsertion
{
    public class SortReport
    {
        public int ComparisonsCount;
        public int SwapsCount;

        public bool Render;

        public int CanvasWidth;
        public int CanvasHeight;

        public DoubleLinkedList<Bitmap> Frames;

        public SortReport()
        {
            Render = false;
            CanvasWidth = CanvasHeight = 0;
            Frames = null;
        }
        public SortReport(int canvasWidth, int canvasHeight)
        {
            Render = true;
            CanvasWidth = canvasWidth;
            CanvasHeight = canvasHeight;
            Frames = new DoubleLinkedList<Bitmap>();
        }
    }
}
