using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Line : IShape
    {
        private Point start, end;

        public Line(Point _start, Point _finish)
        {
            this.start = _start;
            this.end = _finish;
        }

        public void Draw(GeometryDrawing mainDrawing)
        {
            LineGeometry line = new LineGeometry(start, end);
        }
    }
}