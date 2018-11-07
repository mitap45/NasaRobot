using System;
using System.Collections.Generic;
using System.Text;

namespace NasaRobot
{
    class Robot
    {
        enum directionType
        {
            North = 'N',
            East = 'E',
            South = 'S',
            West = 'W'
        }

        enum commandType
        {
            Left = 'L',
            Right = 'R',
            Move = 'M'
        }

        public int x { get; set; }
        int xBoundary;
        public int y { get; set; }
        int yBoundary;
        public char direction { get; set; }

        public Robot(int xBound, int yBound)
        {
            this.xBoundary = xBound;
            this.yBoundary = yBound;
        }

        public void ExecuteCommands(string commands)
        {
            char[] commandArray = commands.ToCharArray();

            //Iterating  through commands
            for (int i = 0; i < commandArray.Length; i++)
            {
                char command = 'A';
                // Get character from array.
                if (Char.IsLetter(commandArray[i]))
                {
                    command = Char.ToUpperInvariant(commandArray[i]);
                }
                

                //If command is 'R' or 'L' then chancing the direction of robot
                if (command == 'L' || command == 'R')
                {
                    Rotate(command);
                }//If command is 'M' then moving the robot to towards its direction
                else if (char.ToUpperInvariant(command) == 'M')
                {
                    Move();
                }//If there is invalid command then informing the user
                else
                {
                    Console.WriteLine("You entered invalid command");
                }
            
            }

        }

        void Rotate (char rotateDirection)
        {
            char currentDirection = direction;

            switch (currentDirection)
            {
                case 'N':
                    if (rotateDirection == 'R')
                        this.direction = 'E';
                    else
                        this.direction = 'W';
                    break;
                case 'E':
                    if (rotateDirection == 'R')
                        this.direction = 'S';
                    else
                        this.direction = 'N';
                    break;
                case 'S':
                    if (rotateDirection == 'R')
                        this.direction = 'W';
                    else
                        this.direction = 'E';
                    break;
                case 'W':
                    if (rotateDirection == 'R')
                        this.direction = 'N';
                    else
                        this.direction = 'S';
                    break;
                default:
                    Console.WriteLine("Robot has no valid direction");
                    break;

            }

        }

        void Move()
        {
            char currentDirection = direction;

            switch (currentDirection)
            {
                case 'N':
                    if (this.y < this.yBoundary)
                        this.y++;
                    break;
                case 'E':
                    if (this.x < this.xBoundary)
                        this.x++;
                    break;
                case 'S':
                    if (this.y != 0)
                        this.y--;
                    break;
                case 'W':
                    if (this.x != 0)
                        this.x--;
                    break;
                default:
                    Console.WriteLine("Robot has no valid direction");
                    break;
            }
        }

        public string getLocation()
        {
            return this.x.ToString() + " " + this.y.ToString() + " " + this.direction.ToString();
        }

    }
}
