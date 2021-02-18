using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Bird
{
    class Pipe
    {
            // Random variable for Y-axis
        protected Random rand = new Random();
            // Return Point of Pipe
        public Point GetStartingPos
        {
            get { Point tmp = new Point(PositionX, PositionY); return tmp; }
        }
            // Properties 
        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }
        // Method to move pipes
        public Point MovePipe 
        {
            get
            {
                PositionX -= 10;
                Point tmp = new Point(PositionX, PositionY);
                return tmp;
            }
        }
    }
}
