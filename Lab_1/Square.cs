﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Square : Line
    {
        private Point upperLeft, downRight;

        public Square(Point _start, Point _finish) : base(_start, _finish)
        {
            this.upperLeft = _start;
            this.downRight = _finish;
        }

        public void Draw(GeometryDrawing mainDrawing)
        {
            //TODO
        }
    }
}
