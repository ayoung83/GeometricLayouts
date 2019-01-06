using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLayouts.Models;
using System.Web.Http.Results;

namespace GeometricLayoutsTests.Controllers
{
    [TestClass]
    public class GetCoordinatesTest
    {
        [Ignore]
        private bool AreEqual(Coordinates coor, Coordinates expectedCoor)
        {
            bool areEqual = false;
            areEqual = coor.Vertex1.X == expectedCoor.Vertex1.X &&
                        coor.Vertex1.Y == expectedCoor.Vertex1.Y &&
                        coor.Vertex2.X == expectedCoor.Vertex2.X &&
                        coor.Vertex2.Y == expectedCoor.Vertex2.Y &&
                        coor.Vertex3.X == expectedCoor.Vertex3.X &&
                        coor.Vertex3.Y == expectedCoor.Vertex3.Y;
            return areEqual;
        }

        [TestMethod()]
        public void GetCoordinatesTest_A1_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('A', 1);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(0, 10);
            expectedCoor.Vertex2 = new Coordinate(0, 0);
            expectedCoor.Vertex3 = new Coordinate(10, 10);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        
        }


        [TestMethod()]
        public void GetCoordinatesTest_A8_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('A', 8);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(40, 0);
            expectedCoor.Vertex2 = new Coordinate(30, 0);
            expectedCoor.Vertex3 = new Coordinate(40, 10);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_A3_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('A', 3);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(10, 10);
            expectedCoor.Vertex2 = new Coordinate(10, 0);
            expectedCoor.Vertex3 = new Coordinate(20, 10);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_B6_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('B', 6);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(30, 10);
            expectedCoor.Vertex2 = new Coordinate(20, 10);
            expectedCoor.Vertex3 = new Coordinate(30, 20);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_B10_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('B', 10);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(50, 10);
            expectedCoor.Vertex2 = new Coordinate(40, 10);
            expectedCoor.Vertex3 = new Coordinate(50, 20);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_C7_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('C', 7);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(30, 30);
            expectedCoor.Vertex2 = new Coordinate(30, 20);
            expectedCoor.Vertex3 = new Coordinate(40, 30);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_C12_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('C', 12);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(60, 20);
            expectedCoor.Vertex2 = new Coordinate(50, 20);
            expectedCoor.Vertex3 = new Coordinate(60, 30);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_D4_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('D', 4);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(20, 30);
            expectedCoor.Vertex2 = new Coordinate(10, 30);
            expectedCoor.Vertex3 = new Coordinate(20, 40);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_E9_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('E', 9);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(40, 50);
            expectedCoor.Vertex2 = new Coordinate(40, 40);
            expectedCoor.Vertex3 = new Coordinate(50, 50);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }

        [TestMethod()]
        public void GetCoordinatesTest_F5_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var httpAR = triangle.GetCoordinatesFromRowAndColumn('f', 5);

            var expectedCoor = new Coordinates();
            expectedCoor.Vertex1 = new Coordinate(20, 60);
            expectedCoor.Vertex2 = new Coordinate(20, 50);
            expectedCoor.Vertex3 = new Coordinate(30, 60);

            var coor = httpAR as OkNegotiatedContentResult<Coordinates>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<Coordinates>));
            Assert.IsTrue(AreEqual(coor.Content, expectedCoor));
        }
    }
}
