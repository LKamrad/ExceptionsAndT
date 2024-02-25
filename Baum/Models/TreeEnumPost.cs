using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class TreeEnumPost<T> : IEnumerator<T>
    {
        private List<INode<T>> _nodes;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;
        Stack<INode<T>> _stack = new Stack<INode<T>>();
        List<INode<T>> _list = new List<INode<T>>();

        INode<T> selectedNode = null;

        public TreeEnumPost(List<INode<T>> list)
        {
            _nodes = list;
        }

        public bool MoveNext()
        {
            position++;
            selectedNode = _nodes[position];

            return selectedNode != null;
        }

        public void Reset()
        {
            position = -1;
            _nodes = null;
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
                    return selectedNode;
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
