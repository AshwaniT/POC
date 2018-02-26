using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdList
{
    public class Node
    {
        public BSFState State { get; set; }
        public int Level { get; set; }
        public String Name { get; set; }
        public Node Prece { get; set; }
        public Node(string name)
        {
            Name = name;
            Level = int.MaxValue;
            State = BSFState.Undiscovered;
        }
        public override bool Equals(object obj)
        {
            var other = obj as Node;
            if (other == null)
                return false;
            return other.Name.Equals(Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, State: {1}, Level: {2}", Name, State, Level);
        }

    }
}
