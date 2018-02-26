using System.Collections.Generic;

namespace AdList
{
   public class Graph
    {
       public Dictionary<Node, Edge> List { get; set; }
       private bool _isDirected { get; set; }
       public Graph(bool isDirected)
       {
           _isDirected = isDirected;
           List = new Dictionary<Node, Edge>();
           DFSNodes = new List<Node>();
           AllPaths = new List<Edge>();
          
       }
       public List<Node> DFSNodes { get; set; }
       public Graph Add(string from, string to)
       {
           var source = new Node(from);
           var des = new Node(to);
           if (!List.ContainsKey(source))
           {
               List.Add(source, new Edge(to));
           }
           else
           {
               List[source].AddAtLast(to);

           }
           if (!_isDirected)
           {
               if (!List.ContainsKey(des))
               {
                   List.Add(des, new Edge(from));
               }
               else
               {
                   List[des].AddAtLast(from);
               }
           }

           return this;
       }

       public Graph Add(string from, string to, int cost)
       {
           var source = new Node(from);
          
           if (!List.ContainsKey(source))
           {
               List.Add(source, new Edge(to));
           }
           else
           {
               List[source].AddAtLast(to);

           }
           return this;
       }
      
       public List<Node> BSF(Node start)
       {
           if (List == null)
               return null;;
          var BSFNodes = new List<Node>();
           var queue = new Queue<Node>();
           start.Level = 0;
           start.State = BSFState.Discovered;
           queue.Enqueue(start);
           while (queue.Count > 0)
           {
               var poped = queue.Dequeue();
               poped.State = BSFState.Visisted;
               BSFNodes.Add(poped);
               
               if(List.ContainsKey(poped))
               {
                   var adj = List[poped];
                    while(adj!=null)
                   {
                        //only undiscovered 
                       if (!BSFNodes.Contains(adj.To) && !queue.Contains(adj.To))
                       {
                           var toadd = adj.To;
                           toadd.State = BSFState.Discovered;
                           toadd.Level = poped.Level + 1;
                           toadd.Prece = poped;
                           queue.Enqueue(toadd);
                       }
                       adj = adj.Next;

                   } 
               }
              
           }
           return BSFNodes;
       }

       public void DFS(Node current)
       {
           //if (current == null)
           //    return;
           DFSNodes.Add(current);
           if (!List.ContainsKey(current)) return;
           var z = List[current];
           while (z != null)
           {
               //if (!DFSNodes.Contains(z.To))
               //{
               z.To.Prece = current;
                   DFS(z.To);
               //}
                  
               z = z.Next;
               
           }
       }
      public List<Edge> AllPaths { get; set; }
      private Edge edge;
       public void FindAllPath(Node current)
       {
           //if (current == null)
           //    return;
          // DFSNodes.Add(current);

           if (current != null && edge == null)
           {
               edge = new Edge(current.Name, 0);
           }
           else
           {
               edge.AddAtLast(current.Name);
           }
           //AllPaths.Add(edge);
           if (!List.ContainsKey(current))
           {
               
               AllPaths.Add(Edge.Clone(edge));

               //edge = null;
               return;
           }
           var z = List[current];
           while (z != null)
           {
               
               FindAllPath(z.To);
               edge.Remove(z.To.Name);
               z = z.Next;
               
               

           }
           
          // edge = null;
       }
      

    }
}
