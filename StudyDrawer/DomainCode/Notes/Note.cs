using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer.DomainCode.Notes
{
    [Serializable]
    public class Note
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<INoteContent> Content { get; set; }
    }
}
