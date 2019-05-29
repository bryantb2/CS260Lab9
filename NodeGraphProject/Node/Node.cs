using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGraphLibrary
{
    public class Node
    {
        //class fields
        private string name;
        private bool visited;
        private Edge edges;

        //constructor
        public Node(string name, bool visited, Edge edges)
        {
            this.name = name;
            this.visited = visited;
            this.edges = edges;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool Visited
        {
            get
            {
                return this.visited;
            }
            set
            {
                this.visited = value;
            }
        }

        public Edge GetEdges
        {
            get
            {
                return this.edges;
            }
        }

        public void AddEdge(Edge edge)
        {
            //set old head to temp
            //set new edge's next to temp
            //set local edge equal to class edge
            Edge temp = this.edges;
            edge.Next = temp;
            this.edges = edge;
        }

        public Edge RemoveEdge(Edge edge)
        {
            //iterate through the linked list of edges using ".Next"
                //add each edge to a stack
            //pop off stack
                //if the popped value is equal to key, set as return value
                //else add back to the list of edges
            Edge temp = this.edges;
            Stack<Edge> tempStack = new Stack<Edge>();
            Edge returnEdge = null;
            while (temp != null)
            {
                tempStack.Push(temp);
                temp = temp.Next;
            }
            temp = null;
            while (tempStack.Count != 0)
            {
                Edge poppedValue = tempStack.Pop();
                if(poppedValue == edge)
                {
                    returnEdge = edge;
                }
                else
                {
                    poppedValue.Next = temp;
                    temp = poppedValue;
                }
            }
            this.edges = temp;
            return returnEdge;
        }
    }
}
