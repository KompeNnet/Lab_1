using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Rombus : Line
    {
        private Point top, right;

        public Rombus(Point _start, Point _finish)
        {
            this.top = _start;
            this.right = _finish;
        }

        public void Draw(GeometryDrawing mainDrawing)
        {

        }
    }
}
