using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class Node
    {
        object element; //Data
        Node succesor; // Next

        public object Element { get => element; set => element = value; }
        public Node Succesor { get => succesor; set => succesor = value; }
        // Constructor with data
        public Node(object d)
        {
            Element = d;
        }
        // Constructor with data and the next node
        public Node(object d, Node n)
        {
            Element = d;
            Succesor = n;
        }
    }
}