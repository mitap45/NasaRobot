using System;
using System.Linq;

namespace NasaRobot
{
    class Program
    {
        static void Main(string[] args)
        {

            //Getting Trimmed Inputs
            Console.WriteLine("Boundaries : ");
            string boundaries = Console.ReadLine().Trim();
            Console.WriteLine("Location of First Robot : ");
            string location1 = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Commands of First Robot : ");
            string commands1 = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Location of Second Robot : ");
            string location2 = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Commands of Second Robot : ");
            string commands2 = Console.ReadLine().Trim().ToUpper();

            //Validation for inputs
            bool isBoundaryValid = RobotValidation.isBoundaryValid(boundaries);
            bool isLocation1Valid = RobotValidation.isLocationValid(location1);
            bool isCommands1Valid = RobotValidation.isCommandsValid(commands1);
            bool isLocation2Valid = RobotValidation.isLocationValid(location2);
            bool isCommands2Valid = RobotValidation.isCommandsValid(commands2);
            if(!isBoundaryValid)
            {
                Console.WriteLine("Invalid boundary");
                Environment.Exit(0);
            }
            if(!isLocation1Valid || !isLocation2Valid)
            {
                Console.WriteLine("Invalid location");
                Environment.Exit(0);

            }
            if (!isCommands1Valid || !isCommands2Valid)
            {
                Console.WriteLine("Invalid commands");
                Environment.Exit(0);

            }

            string[] boundariesArray = boundaries.Split(' ');
            string[] location1Array = location1.Split(' ');
            string[] location2Array = location2.Split(' ');

            //Generating robot 1 and robot 2 instances and executing commands
            Robot robot1 = new Robot(Int32.Parse(boundariesArray[0]), Int32.Parse(boundariesArray[1]));
            Robot robot2 = new Robot(Int32.Parse(boundariesArray[0]), Int32.Parse(boundariesArray[1]));
            robot1.x = Int32.Parse(location1Array[0]);
            robot1.y = Int32.Parse(location1Array[1]);
            robot1.direction = Convert.ToChar(location1Array[2]);
            robot1.ExecuteCommands(commands1);

            robot2.x = Int32.Parse(location2Array[0]);
            robot2.y = Int32.Parse(location2Array[1]);
            robot2.direction = Convert.ToChar(location2Array[2]);
            robot2.ExecuteCommands(commands2);


            Console.WriteLine(robot1.getLocation());
            Console.WriteLine(robot2.getLocation());

        }


    }
}
