using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baum
{
    class Tree<T> : ITree<T>
        where T : IComparable
    {
        public  INode<T> _parent;

        public Tree(T input)
        {

            Node<T> _temp = new Node<T>()
            {
                Value = input
            };

            _parent = _temp;

        }
        public INode<T> AddToParent(T parentValue, T value)
        {

            INode<T> temp = Search(parentValue);

            if(temp != null)
            {
                return temp.Add(value);
            }
            throw new InvalidOperationException();
        }

        public INode<T> Search(T value)
        {
            if(_parent.Value.CompareTo(value) == 0)
            {
                return _parent;
            }
            return SearchChild(_parent, value);
        }
        public INode<T> SearchChild(INode<T> node, T value)
        {
            INode<T> temp = null;
            foreach (var child in node.Children)
            {
                if (child.Children != null)
                {
                    temp = SearchChild(child, value);
                    if(temp != null)
                    {
                        return temp;
                    }
                }
                if (child.Value.CompareTo(value) == 0)
                {

                    temp = child;
                    return temp;
                }
            }

            return temp;
        }


        public bool Contains(T Value)
        {
            foreach(var pv in PostOrderValues())
            {
                if (pv.CompareTo(Value) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<T> PostOrderValues()
        {
            foreach (var pv in _parent.Children)
            {
                IEnumerable<T> toReturn = (pv as Node<T>).PostOrderValues();

                foreach (var node in toReturn)
                {
                    yield return node;
                }
            }
            yield return _parent.Value;
        }

        public IEnumerable<T> PreOrderValues()
        {
            yield return _parent.Value;
            foreach (var pv in _parent.Children)
            {
                IEnumerable<T> toReturn = (pv as Node<T>).PreOrderValues();

                foreach (var node in toReturn)
                {
                    yield return node;
                }
            }
            
        }


    }







}
