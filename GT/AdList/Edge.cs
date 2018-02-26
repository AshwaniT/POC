using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdList
{
    public class Edge
    {
        public Node To { get; set; }
        public int Cost { get; set; }
        public Edge Next { get; set; }
        public Edge(string to)
            : this(to, 0)
        {

        }
        public Edge(string to, int cost)
        {
            To = new Node(to);
            Cost = cost;
            Next = null;
        }

        public void AddAtLast(string to, int cost)
        {
            if (Next == null)
                Next = new Edge(to, cost);
            else
            {
                var head = Next;
                while (head.Next != null)
                {
                    head = head.Next;
                }
                head.Next = new Edge(to, cost);
            }
        }
        public void Remove(string to)
        {
            if (Next == null)
                return;
            if (Next.To.Equals(new Node(to)))
            {
                Next = null;
                return;
            }
            var head = Next;
            while (head.Next != null)
            {
                if (head.Next.To.Equals(new Node(to)))
                {
                    head.Next = null;
                    return;
                }
                head = head.Next;
            }
        }
        public static Edge Clone(Edge edge)
        {            
            if (edge == null )
                return null;            
            var res=new Edge(edge.To.Name,edge.Cost);            
            var head = edge.Next;
            while(head!=null)
            {
                res.AddAtLast(head.To.Name, head.Cost);
                head = head.Next;
            }
            return res; 
        }
        public bool HasEdgeTo(string to)
        {
            if (To.Equals(to))
                return true;
            return HasEdgeTo(Next, to);
        }

        public bool HasEdgeTo(Edge current, string to)
        {
            if (current == null)
                return false;
            if (current.To.Equals(to))
                return true;
            return HasEdgeTo(current.Next, to);

        }


        public override string ToString()
        {
            return string.Format("{0} {1}", To, Cost);
        }

        public void AddAtLast(string to)
        {
            if (Next == null)
                Next = new Edge(to, 0);
            else
            {
                var head = Next;
                while (head.Next != null)
                {
                    head = head.Next;
                }
                head.Next = new Edge(to, 0);
            }
        }


    }
}
