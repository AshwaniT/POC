using AdList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var gt = new Graph(true);
            gt.Add("1", "2");
            gt.Add("1", "4");
            gt.Add("1", "5");
            gt.Add("2", "3");
            gt.Add("2", "4");
            gt.Add("3", "6");
            gt.Add("5", "6");
            gt.Add("4", "6");
            //gt.Add("a", "b");
            //foreach (var x in gt.List)
            //{
            //    Console.WriteLine("From: {0}",x.Key);
            //    var ed = x.Value;
            //    while (ed != null)
            //    {
            //        Console.WriteLine(" To: {0} Cost{1}",ed.To,ed.Cost);
            //        ed = ed.Next;
            //    }
            //}
            //Console.WriteLine("BSF:");
            
            //foreach (var x in gt.BSF(new Node("1")))
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("DSF:");
            //gt.DFS(new Node("1"));
            //foreach (var x in gt.DFSNodes)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine("pre");
            //    Console.WriteLine(x.Prece);
            //}
            gt.FindAllPath(new Node("1"));
            foreach (var x in gt.AllPaths)
            {
                Console.WriteLine("==edge===");
                var z = x;
                while (z != null)
                {
                    Console.WriteLine(z);
                    z = z.Next;
                }

            }
            Console.Read();
        }
    }
}
