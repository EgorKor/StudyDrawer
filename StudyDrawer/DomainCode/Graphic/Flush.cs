using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer.DomainCode.Graphic
{
    public class Flush : IFigure
    {
        private List<Rectangle> _rectangles;
        private Color _color;

        public Flush(List<Rectangle> rectangles, Color color)
        {
            _rectangles = new List<Rectangle>(rectangles);
            _color = color;
        }

        public void Draw(Graphics g)
        {
            Draw(g, _color); 
        }

        public void Draw(Graphics g, Color color)
        {
            foreach (var rect in _rectangles)
            {
                g.FillRectangle(new SolidBrush(color), rect);
            }
        }


        
    }
}
