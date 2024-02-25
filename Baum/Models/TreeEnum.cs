using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class TreeEnum<T> : IEnumerator<T>
    {
        private List<INode<T>> _nodes;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public TreeEnum(List<INode<T>> list)
        {
            _nodes = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _nodes.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public INode<T> Current
        {
            get
            {
                try
                {
                    return _nodes[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        T IEnumerator<T>.Current => Current.Value;
    }
}
