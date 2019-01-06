using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometricLayouts.Models
{
    public class Coordinates
    {
        public Coordinates()
        {
            vertex1 = new Coordinate();
            vertex2 = new Coordinate();
            vertex3 = new Coordinate();
        }

        private Coordinate vertex1;
        public Coordinate Vertex1
        {
            get { return vertex1; }
            set
            {
                if (IsValid(value))
                {
                    vertex1 = value;
                }
                else throw new ArgumentException("Invalid Vertex");
            }
        }

        private Coordinate vertex2;
        public Coordinate Vertex2
        {
            get { return vertex2; }
            set
            {
                if (IsValid(value))
                {
                    vertex2 = value;
                }
                else throw new ArgumentException("Invalid Vertex");
            }
        }

        private Coordinate vertex3;
        public Coordinate Vertex3
        {
            get { return vertex3; }
            set
            {
                if (IsValid(value))
                {
                    vertex3 = value;
                }
                else throw new ArgumentException("Invalid Vertex");
            }
        }

        private bool IsValid(Coordinate vertex)
        {//Need more validation logic?
            var isValid =  (vertex.X % 10 == 0 && vertex.Y % 10 == 0);
            if(vertex1.isSet && isValid)
            {
                isValid = IsWithinTolerances(vertex, vertex1);
            }
            if(vertex2.isSet && isValid)
            {
                isValid = IsWithinTolerances(vertex, vertex2);
            }
            if (vertex3.isSet && isValid)
            {
                isValid = IsWithinTolerances(vertex, vertex3);
            }
            return isValid;
        }

        private bool IsWithinTolerances(Coordinate incomingVertex, Coordinate existingVertex)
        {
            var xDiff = Math.Abs(incomingVertex.X - existingVertex.X);
            var yDiff = Math.Abs(incomingVertex.Y - existingVertex.Y);
            return (xDiff == 10 || xDiff == 0) && (yDiff == 10 || yDiff == 0);
        }
    }
}