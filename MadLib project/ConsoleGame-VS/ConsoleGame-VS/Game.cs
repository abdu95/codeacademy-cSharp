using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_VS
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string keyPressed, out int xChange, out int yChange)
        {

            switch (keyPressed)
            {
                case "UpArrow":
                    xChange = 0;
                    yChange = -1;
                    break;
                case "DownArrow":
                    xChange = 0;
                    yChange = 1;
                    break;
                case "LeftArrow":
                    xChange = -1;
                    yChange = 0;
                    break;
                case "RightArrow":
                    xChange = 1;
                    yChange = 0;
                    break;
                default:
                    xChange = 0;
                    yChange = 0;
                    break;
            }

        }

        public new static char UpdateCursor(string keyPressed)
        {

            switch (keyPressed)
            {
                case "LeftArrow":
                    return '<';
                case "RightArrow":
                    return '>';
                case "UpArrow":
                    return '^';
                case "DownArrow":
                    return 'v';
                default:
                    return '<';
            }
        }
        //needs improvement
        public new static int KeepInBounds(int dimension, int max)
        {

            if (dimension < 0)
                return 0;
            else if (dimension >= max)
                return max - 1;
            else
                return dimension;
            // int result = 0;
            // if(coor <= 1)
            //   result = 1;
            // else if(coor < 0)
            //   result = 0;
            // else if(coor >= max)
            //   result = max-1;
            // return result;
        }
        public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit)
        {
            if (xChar == xFruit && yChar == yFruit)
                return true;
            else
                return false;
        }
    }
}
