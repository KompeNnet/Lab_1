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

        public Figures()
        {
            this.mainDrawing = new GeometryDrawing();
            mainList = new List<IShape>();
        }

        public void Add(IShape shape)
        {
            mainList.Add(shape);
        }

        public DrawingImage Drawing()
        {
            GeometryDrawing mainDrawing = new GeometryDrawing();
            GeometryGroup mainDrawingGroup = new GeometryGroup();
            mainDrawing.Brush = Brushes.Brown;
            mainDrawing.Pen = new Pen(mainDrawing.Brush, 0.5);
            foreach (IShape shape in mainList)
            {
                shape.Draw(mainDrawingGroup);
            }
            mainDrawing.Geometry = mainDrawingGroup;
            return new DrawingImage(mainDrawing);
        }
    }
}
