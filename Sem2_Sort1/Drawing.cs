using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Sort1
{
    public static class Drawing
    {
        public static Bitmap Draw(Graphics g, int[] arr, int x1, int y1, int x2, int y2, int dx, int fillSmaller, int fillBigger, int showSelected)
        {
            Bitmap bmp = new Bitmap(1000, 1000);
            g = Graphics.FromImage(bmp);
            DrawArray(g, arr, x1, y1, x2, y2, dx, fillSmaller, fillBigger, showSelected);
            return bmp;
        }

        private static void DrawArray(Graphics g, int[] arr, int x1, int y1, int x2, int y2, int dx, int fillSmaller, int fillBigger, int showSelected)
        {
            Font f = new Font("TimeNewRoman", 19F);
            Pen selectPen = new Pen(Color.Black, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == showSelected || i - 1 == showSelected)
                    g.DrawEllipse(selectPen, x1 + i * dx, y1, x2, y2);
                else
                {
                    if (i != fillSmaller && i != fillBigger)                  
                        g.DrawEllipse(Pens.Black, x1 + i * dx, y1, x2, y2);
                    else if (i == fillSmaller)
                    {
                        g.FillEllipse(Brushes.LightSkyBlue, x1 + i * dx, y1, x2, y2);
                        g.DrawEllipse(selectPen, x1 + i * dx, y1, x2, y2);
                    }
                        
                    else if (i == fillBigger)
                    {
                        g.FillEllipse(Brushes.DeepSkyBlue, x1 + i * dx, y1, x2, y2);
                        g.DrawEllipse(selectPen, x1 + i * dx, y1, x2, y2);
                    }
                        
                }

                g.DrawString(arr[i].ToString(), f, Brushes.Black, x1 + i * dx + x2 / 4, y1 + y2 / 4);

            }
        }
    }
}
