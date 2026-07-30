using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependancyInversion.Violate
{
    internal class WeatherTracker
    {
        Emailer emailer;
        string currentWeather;
        public WeatherTracker()
        {
            emailer = new Emailer();
        }

        public void SetCurrentConditions(string weatherDescription)
        {
            currentWeather = weatherDescription;
            if (currentWeather == "Hot")
            {
                emailer.SendEmail("It's hot outside. Stay hydrated!");
            }
            
        }
    }
}
