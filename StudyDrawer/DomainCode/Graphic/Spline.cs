using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer
{
    public class Spline : IFigure
    {
        private Pen _pen;
        private List<Point> _points;
        private Brush _brush;
        public Spline(Pen pen, List<Point> points) {
            _pen = new Pen(pen.Color, pen.Width);
            _points = new List<Point>(points);
            _brush = new SolidBrush(pen.Color);
        }
        public void Draw(Graphics g)
        {
            Draw(g, _pen.Color);
        }

        public void Draw(Graphics g, Color color)
        {
            for (int i = 0; i < _points.Count - 1; i++)
            {
                g.DrawLine(_pen, _points[i], _points[i + 1]);
                g.FillEllipse(new SolidBrush(color), _points[i].X - _pen.Width / 2, _points[i].Y - _pen.Width / 2, _pen.Width, _pen.Width);
            }
        }
    }
}
