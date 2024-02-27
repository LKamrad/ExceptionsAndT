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
            return new NodeEnum<T>(this);
        }

        public IEnumerable<T> PostOrderValues()
        {
            List<T> ToReturn = new List<T>();
            foreach(var child in _children)
            {
                List<T> children = (List<T>)child.PostOrderValues();
                foreach (var c in children)
                {
                    ToReturn.Add(c);
                }
            }
            ToReturn.Add(Value);
            return ToReturn;
        }

        public IEnumerable<T> PreOrderValues()
        {
            List<T> ToReturn = new List<T>();
            ToReturn.Add(Value);
            foreach (var child in _children)
            {
                List<T> children = (List<T>)child.PreOrderValues();
                foreach (var c in children)
                {
                    ToReturn.Add(c);
                }
            }
            
            return ToReturn;
        }
        public IEnumerable<T> Test()
        {
            List<T> list = new List<T>();

            foreach(var child in Children)
            {

            }
            foreach (var child in this)
            {
                list.Add(child);
            }
            list.Add(Value);
            return list;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
