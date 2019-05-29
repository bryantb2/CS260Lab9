using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NodeGraphLibrary;

namespace UnitTesting
{
    class GraphTest
    {
        WeightedGraph graph1;

        [SetUp]
        public void TestSetup()
        {
            graph1 = new WeightedGraph();
        }

        [Test]
        public void TestAddNode()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            string nodeList = graph1.ListNodes();
            Assert.AreEqual("node1 node2 node3 ", nodeList);
        }

        [Test]
        public void TestRemoveNode()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            graph1.RemoveNode("node2");
            string nodeList = graph1.ListNodes();
            Assert.AreEqual("node1 node3 ", nodeList);
        }

        [Test]
        public void TestAddEdge()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            Assert.AreEqual(true, graph1.AddEdge("node1", "node2"));
            Assert.AreEqual(true, graph1.AddEdge("node2", "node3"));
        }

        [Test]
        public void TestRemoveEdge()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");

            //adding edges
            graph1.AddEdge("node1", "node2");
            graph1.AddEdge("node2", "node3");

            //removing edges
            Assert.AreEqual(true, graph1.RemoveEdge("node1", "node2"));
            Assert.AreEqual(true, graph1.RemoveEdge("node2", "node3"));
        }

        [Test]
        public void TestDisplayMatrix()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            graph1.AddNode("node4");
            graph1.AddNode("node5");
            graph1.AddNode("node6");
            graph1.AddNode("node7");
            graph1.AddNode("node8");

            //adding edges
            graph1.AddEdge("node1", "node2");
            graph1.AddEdge("node2", "node3");
            graph1.AddEdge("node3", "node4");
            graph1.AddEdge("node4", "node8");
            graph1.AddEdge("node4", "node5");
            graph1.AddEdge("node4", "node6");
            graph1.AddEdge("node6", "node7");
            Console.WriteLine(graph1.DisplayMatrix());
        }

        [Test]
        public void TestDisplayEdges()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            graph1.AddNode("node4");
            graph1.AddNode("node5");
            graph1.AddNode("node6");
            graph1.AddNode("node7");
            graph1.AddNode("node8");

            //adding edges
            graph1.AddEdge("node1", "node2");
            graph1.AddEdge("node2", "node3");
            graph1.AddEdge("node3", "node4");
            graph1.AddEdge("node4", "node8");
            graph1.AddEdge("node4", "node5");
            graph1.AddEdge("node4", "node6");
            graph1.AddEdge("node6", "node7");
            Console.WriteLine(graph1.DisplayEdges());
        }

        [Test]
        public void TestBreadthTraversal()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            graph1.AddNode("node4");
            graph1.AddNode("node5");
            graph1.AddNode("node6");
            graph1.AddNode("node7");
            graph1.AddNode("node8");

            //adding edges
            graph1.AddEdge("node1", "node2");
            graph1.AddEdge("node2", "node3");
            graph1.AddEdge("node3", "node4");
            graph1.AddEdge("node4", "node8");
            graph1.AddEdge("node4", "node5");
            graph1.AddEdge("node4", "node6");
            graph1.AddEdge("node6", "node7");
            Console.WriteLine(graph1.BreadthTraverse("node4"));
        }

        [Test]
        public void TestDepthFirstTraversal()
        {
            graph1.AddNode("node1");
            graph1.AddNode("node2");
            graph1.AddNode("node3");
            graph1.AddNode("node4");
            graph1.AddNode("node5");
            graph1.AddNode("node6");
            graph1.AddNode("node7");
            graph1.AddNode("node8");

            //adding edges
            graph1.AddEdge("node1", "node2");
            graph1.AddEdge("node2", "node3");
            graph1.AddEdge("node3", "node4");
            graph1.AddEdge("node4", "node8");
            graph1.AddEdge("node4", "node5");
            graph1.AddEdge("node4", "node6");
            graph1.AddEdge("node6", "node7");
            Console.WriteLine(graph1.DepthFirst("node1"));
        }
    }
}
