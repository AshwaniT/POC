using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class BST<T> where T : IComparable
    {
       public Node<T> Root { get; set; }
       public BST()
       {
           Root = null;
       }
       public bool Empty()
       {
           return Root == null;
       }
       public Node<T> Insert(Node<T> current, T data)
       {
           //Since in BST we add things at end
           if (current == null)
           {
               current = new Node<T>(data);
               if (Empty())
               {
                   Root = current;
               }
           }
           else if (data.CompareTo(current.Data) <= 0)
           {
            current.Left=  Insert(current.Left, data);
           }
           else
           {
             current.Right=  Insert(current.Right, data);
           }
           return current;
       }

       public Node<T> Search(Node<T> current, T data)
       {
           if (current == null)
               return null;
           if (data.CompareTo(current.Data) == 0)
           {
               return current;
           }
           else if (data.CompareTo(current.Data) <= 0)
           {
               return Search(current.Left, data);
           }
           else
               return Search(current.Right, data);
       }
       public int FindHeight(Node<T> current)
       {
           if (current == null)
               return -1;
           var lHeight = FindHeight(current.Left);
           var rHeight = FindHeight(current.Right);
           //here we are incrementing ecah time
           return Math.Max(lHeight, rHeight) + 1;
       }
       public Node<T> Min(Node<T> root)
       {
           if (root == null) return null;

           if (root.Left == null)
           {
               return root;
           }
           return Min(root.Left);

       }

       public Node<T> Max(Node<T> root)
       {
           if (root == null) return null;

           if (root.Right == null)
           {
               return root;
           }
           return Max(root.Right);
       }

       //public Node<T> InOrder(Node<T> root)
       //{
       //    if (root == null)
       //        return null;
       //    InOrder(root.Left);
       //   var current= root;
       //    InOrder(root.Right);
       //    return current;
       //}
       Node<T> pre { get; set; }
       public bool IsBst(Node<T> root)
       {
           if (root == null) return true;;
           
           var res = true;
           IsBst(root.Left);           
           if (pre != null)
           {
               res = pre.Data.CompareTo(root.Data) <= 0;
           }
           pre = root;
           IsBst(root.Right);
           return res;
       }

       public void BSF()
       {
           if (Empty()) return;
           var q = new Queue<Node<T>>();
           q.Enqueue(Root);
           while (q.Count>0)
           {
               var current = q.Peek();
               Console.WriteLine(current);
               if (current.Left != null) q.Enqueue(current.Left);
               if (current.Right != null) q.Enqueue(current.Right);
               q.Dequeue();
           }
       }
       public void InOrder(Node<T> root)
       {
           if (root == null) return;
           InOrder(root.Left);
           Console.WriteLine(root.Data);
           InOrder(root.Right);
       }
       public Node<T> Delete(Node<T> root, T data)
       {
           if (root == null) return null;
           else if (root.Data.CompareTo(data) > 0)
           {
               root.Left = Delete(root.Left, data);
           }
           else if (root.Data.CompareTo(data) < 0)
           {
               root.Right = Delete(root.Right, data);
           }
           else//we have node to delete, delete such a way tree remains BST 
           {
               if (root.Left == null && root.Right == null)
               {
                   return null;
               }
               else if (root.Left == null)
               {
                   return root.Right;
               }
               else if (root.Right == null)
               {
                   return root.Left;
               }
               else
               {
                   return Max(root.Left);
               }
           }
           return root;
       }

       public Node<T> GetSuccessor(Node<T> root, T data)
       {
           //if node has right subtree then node with min value would be sucessor 
           //or go to parent, if node in left subtree imidiate parent would be succ or grand parent
           //get noed has value
           var current = Search(root, data);
           if (current == null)
               return null;
           if (current.Right != null)
           {
               return Min(current.Right);
           }
           else
           {
               var anscetor = root;
               Node<T> suc = null;
               while (anscetor != current)
               {
                   if (anscetor.Data.CompareTo(data) > 0)
                   {
                       suc = anscetor;
                       anscetor = anscetor.Left;
                   }
                   else
                       anscetor = anscetor.Right;
               }
               return suc;


           }

       }
    }
}
