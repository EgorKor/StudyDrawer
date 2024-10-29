using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer
{
    public interface IFigure
    {
        public void Draw(Graphics g);
        public void Draw(Graphics g, Color color);
    }
}
