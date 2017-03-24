using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lab_1
{
    class Figures
    {
        private static List<IShape> mainList;
        GeometryDrawing mainDrawing;

        public Figures(GeometryDrawing mainDrawing)
        {
            this.mainDrawing = mainDrawing;
            mainList = new List<IShape>();
        }

        public void Add(IShape shape)
        {
            mainList.Add(shape);
        }

        public void Drawing(GeometryDrawing mainDrawing)
        {
            mainDrawing.Brush = Brushes.Brown;
            mainDrawing.Pen = new Pen(mainDrawing.Brush, 2);
            foreach (IShape shape in mainList)
            {
                shape.Draw(mainDrawing);
            }
        }
    }
}
