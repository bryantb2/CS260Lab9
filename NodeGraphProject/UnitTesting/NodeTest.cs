using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodeGraphLibrary;
using NUnit.Framework;

namespace UnitTesting
{
    [TestFixture]
    class NodeTest
    {
        Node node1;
        Node node2;
        Node node3;

        [SetUp]
        public void TestSetup()
        {
            node1 = new Node("node1", false, null);
            node2 = new Node("node2", false, null);
            node3 = new Node("node3", false, null);
        }

        [Test]
        public void TestNodeName()
        {
            Assert.AreEqual("node1",node1.Name);
            Assert.AreEqual("node2", node2.Name);
            Assert.AreEqual("node3", node3.Name);
            node1.Name = "hello there";
            Assert.AreEqual("hello there",node1.Name);
        }

        [Test]
        public void TestNodeVisited()
        {
            Assert.AreEqual(false, node1.Visited);
            Assert.AreEqual(false, node2.Visited);
            Assert.AreEqual(false, node3.Visited);
            node1.Visited = true;
            Assert.AreEqual(true, node1.Visited);
        }

        [Test]
        public void TestAddEdge()
        {
            //adding edges
            Edge edge1 = new Edge(2);
            Edge edge2 = new Edge(3);
            Edge edge3 = new Edge(4);
            node1.AddEdge(edge1);
            node1.AddEdge(edge2);
            node1.AddEdge(edge3);

            //this is to ensure that the edge variables are artifically linked for testing
            edge1.Next = null;
            edge2.Next = edge1;
            edge3.Next = edge2;

            Edge linkedList = node1.GetEdges;
            
            Assert.AreEqual(edge3, linkedList);
            linkedList = linkedList.Next;
            Assert.AreEqual(edge2, linkedList);
            linkedList = linkedList.Next;
            Assert.AreEqual(edge1, linkedList);
        }

        [Test]
        public void TestRemoveEdges()
        {
            //adding edges
            Edge edge1 = new Edge(2);
            Edge edge2 = new Edge(3);
            Edge edge3 = new Edge(4);
            node1.AddEdge(edge1);
            node1.AddEdge(edge2);
            node1.AddEdge(edge3);

            //removing center edge
            node1.RemoveEdge(edge2);

            //get list of edges
            Edge linkedList = node1.GetEdges;

            //this is to ensure that the edge variables are artifically linked for testing
            edge1.Next = null;
            edge3.Next = edge1;

            Assert.AreEqual(edge3, linkedList);
            linkedList = linkedList.Next;
            Assert.AreEqual(edge1, linkedList);
        }




    }
}
