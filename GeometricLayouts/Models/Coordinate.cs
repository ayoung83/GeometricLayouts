using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometricLayouts.Models
{
    public class Coordinate
    {
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                isXSet = true;
            }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                isYSet = true;
            }
        }

        private bool isXSet;
        private bool isYSet;
        internal bool isSet { get { return isXSet && isYSet; } }

        public Coordinate()
        {
            isXSet = false;
            isYSet = false;
        }
        public Coordinate(int x, int y)
        {
            X = x;
            isXSet = true;
            Y = y;
            isYSet = true;
        }

    }
}