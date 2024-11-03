using StudyDrawer.DomainCode.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer.DomainCode.Notes
{
    public class NoteDrawingContent
    {
        public List<Image> Images { get; set; }
        public List<Node<IFigure>> Heads { get; set; }
        public List<Node<IFigure>> Tais { get; set; }
    }
}
