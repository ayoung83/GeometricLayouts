using GeometricLayouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace GeometricLayouts.Controllers
{
    [RoutePrefix("api/Triangle")]
    public class TriangleController : ApiController
    {
        [Route("GetCoordinates")]
        [HttpPost]
        [ResponseType(typeof(Coordinates))]
        public IHttpActionResult GetCoordinatesFromRowAndColumn(char row, int column)
        {
            var triangle = new TriangleImage();
            var coordinates = triangle.GetCoordinates(row, column);
            return Ok(coordinates);
        }


        //I'm assuming the coordinates will come in as arranged in the 1.B image.  So Vertex 1 will always be the right angle vertex.  
        [Route("GetRowColumn")]
        [HttpPost]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetRowAndColumnFromCoordinates([FromBody] Coordinates coordinates)
        {
            var triangle = new TriangleImage();
            

            var rowAndColumn = triangle.GetRowAndColumn(coordinates);
            return Ok(rowAndColumn);
        }
    }
}
