﻿using System;
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
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int i = 0;
            while(i < 4) { 
                Turtle.Move(10);
                Turtle.TurnRight();
                Turtle.Move(10);
                Turtle.TurnRight();
                Turtle.Move(10);
                Turtle.TurnLeft();
                Turtle.Move(10);
                Turtle.TurnLeft();
                i++;
            }

            i = 0;

            while (i < 2)
            {
                Turtle.Move(100);
                Turtle.Turn(45);
                Turtle.Move(100);
                Turtle.TurnRight();
                Turtle.Move(100);
                Turtle.Turn(45);
                i++;
            }
        }
    }
}
