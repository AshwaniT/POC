using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BST<int>();
            bst.Insert(bst.Root, 16);
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 18);
            bst.Insert(bst.Root, 14);
            bst.Insert(bst.Root, 19);
            bst.Insert(bst.Root, 21);
            bst.Insert(bst.Root, 17);
            //Console.WriteLine(bst.FindHeight(bst.Root));
            //Console.WriteLine(bst.Search(bst.Root,5));
            //Console.WriteLine(bst.Min(bst.Root));
            //Console.WriteLine(bst.Max(bst.Root));
            bst.InOrder(bst.Root);
            //Console.WriteLine(bst.IsBst(bst.Root));
            //bst.BSF();
            //Console.WriteLine(bst.Delete(bst.Root,19));
            //bst.InOrder(bst.Root);
            Console.WriteLine(bst.GetSuccessor(bst.Root,19));
            Console.WriteLine(bst.GetSuccessor(bst.Root, 21));
            Console.WriteLine(bst.IsBst(bst.Root));
            Console.Read();

        }
    }
}
