using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Node<T> where T : IComparable
    {
       public T Data { get; set; }
       public Node<T> Left { get; set; }
       public Node<T> Right { get; set; }
       public Node(T data)
       {
           Data = data;
       }
       public override string ToString()
       {
           if (this == null) return "empty";
           return string.Format("Current {0} Left {1} Right {2}", Data, Left != null ? Left.Data : default(T), Right != null ? Right.Data : default(T));
       }
    }
}
