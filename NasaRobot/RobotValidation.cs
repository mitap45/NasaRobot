using System;
using System.Text.RegularExpressions;

namespace NasaRobot
{
    //Contains validations of the robot class
    public static class RobotValidation
    {
        //Validating location to match the following '3 5 N' pattern
        public static bool isLocationValid(string location)
        {
            try
            {
                string[] locationArray = location.Split(' ');

                if (locationArray.Length != 3)
                    return false;

                //If can not parse then exception will be thrown and return false 
                int xLocation = Int32.Parse(locationArray[0]);
                int yLocation = Int32.Parse(locationArray[1]);

                Regex strPattern = new Regex("^[NESW]{1}$");

                //Checking if the third character is one of the [N E S W] if not return false
                if (!strPattern.IsMatch(locationArray[2]))
                    return false;

                return true;
                
            }
            catch (Exception e)
            {
                return false;
            }

        }

        //Validating command to match the following 'MMRLMLLR' pattern
        public static bool isCommandsValid(string commands)
        {
            Regex strPattern = new Regex("^[LRM]*$");

            if (!strPattern.IsMatch(commands))
            {
                return false;
            }

            return true;

        }

        //Validating boundary to match the following '4 5' pattern
        public static bool isBoundaryValid(string boundaries)
        {
            try
            {
                string[] boundariesArray = boundaries.Split(' ');

                if (boundariesArray.Length != 2)
                    return false;

                //If can not parse then exception will be catched and return false 
                int xBoundary = Int32.Parse(boundariesArray[0]);
                int yBoundary = Int32.Parse(boundariesArray[1]);

                //If one of the boundary is  negative then return false
                if (xBoundary < 0 || yBoundary < 0)
                    return false;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
