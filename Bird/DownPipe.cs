using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Bird
{
    class DownPipe : Pipe
    {
        public DownPipe(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

            // Generate hole between pipes
        public void GenerateDownPipePoint(int positionY, int numberOfPipe)
        {
            PositionY = positionY;
            PositionY += 325;
            PositionY += 75;

            switch (numberOfPipe)
            {
                case 0:
                    PositionX = 800;
                    break;
                case 1:
                    PositionX = 1100;
                    break;
                case 2:
                    PositionX = 1400;
                    break;
            }
        }

    }
}
