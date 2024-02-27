using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class NodeEnum<T> : IEnumerator<T>
    {
        private INode<T> head;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;
        List<INode<T>> Children;

        public NodeEnum(INode<T> input)
        {
            head = input;
            Children = (List<INode<T>>)head.Children;
        }


        public bool MoveNext()
        {

            position++;
            return position <= Children.Count;
        }

        

        public void Dispose()
        {
            
        }

        public void Reset()
        {
            int position = -1;
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
                    if(position < Children.Count)
                    {
                        return Children[position];
                    }
                    return head;
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
