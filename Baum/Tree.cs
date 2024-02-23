using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    class Tree<T> : ITree<T>
        where T : IComparable
    {



        public Tree()
        {


        }
        public INode<T> AddToParent(T parentValue, T value)
        {
            throw new NotImplementedException();
        }

        public bool Conatins(T Value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PostOrderValues()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PreOrderValues()
        {
            throw new NotImplementedException();
        }

    }

    class Node<T> : INode<T>
    {
        public Node() { }

        public T Value => throw new NotImplementedException();

        public IEnumerable<INode<T>> Children => throw new NotImplementedException();

        public IEnumerable<T> ChildValues => throw new NotImplementedException();

        public INode<T> Add(T nodeValue)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PostOrderValues()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PreOrderValues()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
