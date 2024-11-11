using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer.DomainCode.Util
{
    public class ListObserver<T> : List<T>
    {
        public event Action<int> OnSizeChanged;
        
        public ListObserver() : base() {
        }

        public new void Add(T item)
        {
            base.Add(item);
            OnSizeChanged(Count);
        }

        public new void Clear()
        {
            base.Clear();
            OnSizeChanged(Count);
        }

        public new bool Remove(T item)
        {
            bool removed = base.Remove(item);
            OnSizeChanged(Count);
            return removed;
        }

    }
}
