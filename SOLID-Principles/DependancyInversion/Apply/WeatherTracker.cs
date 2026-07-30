using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependancyInversion.Apply
{
    internal class WeatherTracker 
    {
        private readonly INotifier notifier;
        private string currentWeather;
        public WeatherTracker(INotifier notifier)
        {
            this.notifier = notifier;
        }
        public void SetCurrentConditions(string weatherDescription)
        {
            currentWeather = weatherDescription;
            if (currentWeather == "Hot")
            {
                notifier.Send(weatherDescription);
            }
        }

    }
}
