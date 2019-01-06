using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLayouts.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricLayouts.Models;
using System.Web.Http.Results;

namespace GeometricLayouts.Controllers
{
    [TestClass()]
    public class TriangleImageTests
    {

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_A1_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(0, 10);
            coor.Vertex2 = new Coordinate(0, 0);
            coor.Vertex3 = new Coordinate(10, 10);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "A1";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_A1_VertexFlipped_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(0, 10);
            coor.Vertex3 = new Coordinate(0, 0);
            coor.Vertex2 = new Coordinate(10, 10);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "A1";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_A8_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(40,0);
            coor.Vertex2 = new Coordinate(30, 0);
            coor.Vertex3 = new Coordinate(40, 10);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "A8";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_A3_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(10,10);
            coor.Vertex2 = new Coordinate(10, 0);
            coor.Vertex3 = new Coordinate(20, 10);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "A3";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_B6_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(30, 10);
            coor.Vertex2 = new Coordinate(20, 10);
            coor.Vertex3 = new Coordinate(30, 20);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "B6";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_B10_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(50, 10);
            coor.Vertex2 = new Coordinate(40, 10);
            coor.Vertex3 = new Coordinate(50, 20);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "B10";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_B10_VertexFlipped_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(50, 10);
            coor.Vertex3 = new Coordinate(40, 10);
            coor.Vertex2 = new Coordinate(50, 20);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "B10";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_C7_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(30, 30);
            coor.Vertex2 = new Coordinate(30, 20);
            coor.Vertex3 = new Coordinate(40, 30);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "C7";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_C12_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(60, 20);
            coor.Vertex2 = new Coordinate(50, 20);
            coor.Vertex3 = new Coordinate(60, 30);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "C12";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_D4_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(20, 30);
            coor.Vertex2 = new Coordinate(10, 30);
            coor.Vertex3 = new Coordinate(20, 40);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "D4";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_E9_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(40, 50);
            coor.Vertex2 = new Coordinate(40, 40);
            coor.Vertex3 = new Coordinate(50, 50);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "E9";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_F5_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(20, 60);
            coor.Vertex2 = new Coordinate(20, 50);
            coor.Vertex3 = new Coordinate(30, 60);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "F5";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }

        [TestMethod()]
        public void GetRowAndColumnFromCoordinatesTest_F8_AreEqual()
        {
            var triangle = new GeometricLayouts.Controllers.TriangleController();
            var coor = new Coordinates();
            coor.Vertex1 = new Coordinate(40, 50);
            coor.Vertex2 = new Coordinate(30, 50);
            coor.Vertex3 = new Coordinate(40, 60);
            var httpAR = triangle.GetRowAndColumnFromCoordinates(coor);

            var expectedRowCol = "F8";

            var rowCol = httpAR as OkNegotiatedContentResult<string>;
            Assert.IsInstanceOfType(httpAR, typeof(OkNegotiatedContentResult<string>));
            Assert.AreEqual(expectedRowCol, rowCol.Content);
        }
    }
}