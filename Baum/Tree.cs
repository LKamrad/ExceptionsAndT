using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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

            if (_parent.Value.CompareTo(parentValue) == 0)
            {
                return _parent.Add(value);
            }
            foreach(var child in _parent.Children)
            {
                if (child.Value.CompareTo(parentValue) == 0)
                {
                    return child.Add(value);
                }
            }
            throw new InvalidOperationException();
        }

        public bool Contains(T Value)
        {
            foreach(var pv in _parent.ChildValues)
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
            return _parent.PostOrderValues();
        }

        public IEnumerable<T> PreOrderValues()
        {
            return _parent.PreOrderValues();
        }



    }







}
