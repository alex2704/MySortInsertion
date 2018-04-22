using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SortInsertion
{
    public class Renderer
    {
        public enum HighlightType
        {
            Default, Comparison, Swap
        };

        private static Dictionary<HighlightType, Brush> _elementsColorDict = new Dictionary<HighlightType, Brush>()
        {
            {HighlightType.Default, Brushes.LightYellow },
            {HighlightType.Comparison, Brushes.LightGreen },
            {HighlightType.Swap, Brushes.LightPink },
        };
        private static Dictionary<HighlightType, Brush> _elementsBorderColorDict = new Dictionary<HighlightType, Brush>()
        {
            {HighlightType.Default, Brushes.Yellow },
            {HighlightType.Comparison, Brushes.DarkGreen },
            {HighlightType.Swap, Brushes.Red },
        };
        private static int INNER_RADIUS = 20;
        private static int SPACE_RADIUS = 10;
        private static int BORDER_RADIUS = 5;
        public static Bitmap DrawArrayToBitmap(int canvasWidth, int canvasHeight, int[] arr, HashSet<int> highlightedIndices = null, HighlightType highlightType = HighlightType.Default)
        {
            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);

            Graphics canvasGraphics = Graphics.FromImage(canvas);
            canvasGraphics.Clear(Color.White);

            StringFormat elementStringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Brush borderColor = Brushes.Red;

            for(int i=0;i<arr.Length; i++)
            {
                HighlightType currentElementHighlight = (highlightedIndices!=null && highlightedIndices.Contains(i)) ? highlightType : HighlightType.Default;

                Brush elementColor = _elementsColorDict[currentElementHighlight];
                Brush elementBorderColor = _elementsBorderColorDict[currentElementHighlight];

                Point position = CalculateElementPosition(canvasWidth, canvasHeight, i);

                Rectangle rectangle = new Rectangle(position.X - INNER_RADIUS, position.Y - INNER_RADIUS, INNER_RADIUS*2, INNER_RADIUS*2);

                canvasGraphics.FillEllipse(elementBorderColor, rectangle.Left - BORDER_RADIUS, rectangle.Top - BORDER_RADIUS, rectangle.Width + 2 * BORDER_RADIUS, rectangle.Height + 2 * BORDER_RADIUS);

                canvasGraphics.FillEllipse(Brushes.LightBlue, rectangle);
                canvasGraphics.DrawString(arr[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, rectangle, elementStringFormat);
            }
            return canvas;
        }

        private static Point CalculateElementPosition(int canvasWidth, int canvasHeight, int index)
        {
            int elementSize = INNER_RADIUS + SPACE_RADIUS;

            int elementsInRow = canvasWidth / (2*elementSize);

            int x = (2 * (index % elementsInRow) + 1) * elementSize;
            int y = (2 * (index / elementsInRow) + 1) * elementSize;
            return new Point(x, y);
        }
    }
}
