using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometricLayouts.Models
{
    public class TriangleImage
    {

        //Row and Column variables could be re-written to allow the image to by dynamically sized but it wasn't
        //mentioned in the requirements so I just hardcoded this. 
        private List<char> rows;
        private Dictionary<int, int> columns;

        public TriangleImage()
        {
            rows = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F' };
            columns = new Dictionary<int, int>();

            int index = 0;//Should this start at 1?
            for (int i = 1; i <= 12; i = i + 2)
            {
                columns.Add(i, index);
                columns.Add(i + 1, index);
                index++;
            }
        }


        public Coordinates GetCoordinates(char row, int column)
        {
            try
            {
                var coordinates = new Coordinates();
                coordinates.Vertex2 = GetV2(Char.ToUpper(row), column);
                coordinates.Vertex3 = GetV3(coordinates.Vertex2);
                var columnKV = columns.FirstOrDefault(k => k.Key == column);
                coordinates.Vertex1 = GetV1(coordinates.Vertex2, columnKV);

                return coordinates;
            }
            catch (Exception)
            {//Simple exception handling, could be refined.
                throw new Exception("Invalid row or column value");
            }
        }

        public string GetRowAndColumn(Coordinates coordinates)
        {
            if (coordinates.Vertex2.X >= coordinates.Vertex3.X && coordinates.Vertex2.Y >= coordinates.Vertex3.Y)
            {//Vertex 2 should always be the top left vertex and Vertex 3 should always be bottom right
                var v = coordinates.Vertex3;
                coordinates.Vertex3 = coordinates.Vertex2;
                coordinates.Vertex2 = v;
            }
            var row = GetRow(coordinates.Vertex2);
            var col = GetColumn(coordinates);

            return $"{row}{col}";
        }

        private int GetColumn(Coordinates coordinates)
        {
            int column = 0;
            var index = (coordinates.Vertex2.X / 10);

            if (coordinates.Vertex1.X == coordinates.Vertex2.X)
            {//Column is odd number because V2.X and V1.X are on the same plane
                column = columns.First(k => k.Value == index && !IsEven(k)).Key;
            }
            else if(coordinates.Vertex1.Y == coordinates.Vertex2.Y)
            {//Column is even number because V2.Y and V1.Y are on the same plane
                column = columns.First(k => k.Value == index && IsEven(k)).Key;
            }
            return column;
        }

        private char GetRow(Coordinate v2)
        {
            var row = rows[v2.Y / 10];
            return row;
        }

        private Coordinate GetV2(char row, int column)
        {
            try
            {
                var v = new Coordinate();
                var rowIndex = rows.IndexOf(row);
                if (rowIndex == -1)
                    throw new Exception();
                v.Y = rowIndex * 10;
                var colIndex = columns.First(k => k.Key == column).Value;
                v.X = colIndex * 10;
                return v;
            }
            catch (Exception)
            {//Simple exception handling, could be refined.
                throw new Exception("Invalid row or column value");
            }
        }

        private Coordinate GetV3(Coordinate v2)
        {
            var v = new Coordinate();
            v.Y = v2.Y + 10;
            v.X = v2.X + 10;
            return v;
        }

        private Coordinate GetV1(Coordinate v2, KeyValuePair<int,int> column)
        {
            var v = new Coordinate();
            if (IsEven(column))
            {
                v.Y = v2.Y;
                v.X = v2.X + 10;
            }
            else
            {
                v.X = v2.X;
                v.Y = v2.Y + 10;
            }
            return v;
        }

        private bool IsEven(KeyValuePair<int, int> column)
        {
            return column.Key % 2 == 0;
        }
    }
}