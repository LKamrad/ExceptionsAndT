using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    public interface INode<T> : IEnumerable<T>
    {
        T Value { get; }
        INode<T> Add(T nodeValue);
        IEnumerable<INode<T>> Children { get; }
        IEnumerable<T> ChildValues { get; }
        IEnumerable<T> PreOrderValues();
        IEnumerable<T> PostOrderValues();
    }
    
    public interface ITree<T>
        where T : IComparable
    {
        INode<T> AddToParent(T parentValue, T value);
        bool Contains(T Value);
        IEnumerable<T> PreOrderValues();
        IEnumerable<T> PostOrderValues();
    }

}
