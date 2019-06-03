using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NodeGraphLibrary;

namespace UnitTesting
{
    [TestFixture]
    public class EdgeTest
    {
        Edge edge1;
        Edge edge2;
        Edge edge3;

        [SetUp]
        public void TestSetup()
        {
            edge1 = new Edge(1,2);
            edge2 = new Edge(4,3);
            edge3 = new Edge(3,4);
        }

        [Test]
        public void TestEdgeEndPoint()
        {
            Assert.AreEqual(2,edge1.EndPoint);
            Assert.AreEqual(3,edge2.EndPoint);
            Assert.AreEqual(4, edge3.EndPoint);
        }

        [Test]
        public void TestStartPoint()
        {
            Assert.AreEqual(1, edge1.StartIndex);
            Assert.AreEqual(4, edge2.StartIndex);
            Assert.AreEqual(3, edge3.StartIndex);
        }

        [Test]
        public void TestNextEdge()
        {
            edge1.Next = edge2;
            edge2.Next = edge3;
            Assert.AreEqual(edge2, edge1.Next);
            Assert.AreEqual(edge3, edge2.Next);
        }
    }
}