using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Bird
{
    class UpPipe : Pipe
    {

        public void GenerateRandomPoint(int numberOfPipe)
        {
            int y = rand.Next(1, 7);
            switch (y)
            {
                case 1:
                    y = -250;
                    break;
                case 2:
                    y = -225;
                    break;
                case 3:
                    y = -200;
                    break;
                case 4:
                    y = -175;
                    break;
                case 5:
                    y = -150;
                    break;
                case 6:
                    y = -125;
                    break;
            }
            PositionY = y;
            switch(numberOfPipe)
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
