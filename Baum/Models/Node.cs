using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public class Node<T> : INode<T>
        where T : IComparable
    {
        private List<INode<T>> _children = new List<INode<T>>();
        private List<T> _childValues = new List<T>();
        public Node()
        {

        }

        public T Value { get; set; }

        public IEnumerable<INode<T>> Children { get { return _children; } }

        public IEnumerable<T> ChildValues { get { return _childValues; } }

        public INode<T> Add(T nodeValue)
        {
            if (_children == null)
            {
                _children = new List<INode<T>>();
            }

            foreach (INode<T> child in Children)
            {
                if (nodeValue.CompareTo(child.Value) == 0)
                {
                    return child;
                }
            }

            Node<T> newNode = new Node<T>() { Value = nodeValue };
            _children.Add(newNode);
            _childValues.Add(nodeValue);

            return newNode;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NodeEnum<T>(_children);
        }

        public IEnumerable<T> PostOrderValues()
        {
            foreach (var kind in Children)
            {
                IEnumerable<T> toReturn = (kind as Node<T>).PostOrderValues();

                foreach (var node in toReturn)
                {
                    yield return node;
                }
            }
            yield return Value;
        }

        public IEnumerable<T> PreOrderValues()
        {
            yield return Value;
            foreach (var kind in Children)
            {
                IEnumerable<T> toReturn = (kind as Node<T>).PreOrderValues();

                foreach (var node in toReturn)
                {
                    yield return node;
                }
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
