using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace TurtleTrainingGame
{
    class Program
    {
        static void WriteT(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;

            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);
        }

        static void WriteO(int x, int y, int size) {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;

            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void WriteP(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            WriteO(x, y - size / 2, size / 2);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            //int i = 0;
            //while(i < 4) { 
            //    Turtle.Move(10);
            //    Turtle.TurnRight();
            //    Turtle.Move(10);
            //    Turtle.TurnRight();
            //    Turtle.Move(10);
            //    Turtle.TurnLeft();
            //    Turtle.Move(10);
            //    Turtle.TurnLeft();
            //    i++;
            //}

            //for (i = 0; i < 6; i++)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(60);
            //}

            WriteT(200, 200, 60);
            WriteO(230, 200, 30);
            WriteP(280, 200, 30);
            WriteT(330, 200, 30);
        }
    }
}
