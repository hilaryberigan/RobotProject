using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Location
    {
        List<string> locations = new List<string>();

        public string SetInitialLocation()
        {
            locations.Add("at home");
            locations.Add("under the sea");
            locations.Add("on the moon");


            Random randomLocation = new Random();
            string currentLocation = locations[randomLocation.Next(0, 2)];
            return currentLocation;
        }
    }
}
    //    public string GetNewLocation();
    //    {
        
    //}


