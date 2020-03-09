using System;
using System.Collections.Generic;

namespace MakingMethodCallsSimpler
{
    public class ReplaceParameterWithMethod
    {
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }
        public DateTime? PickedTime { get; set; }

        public void ShowTimeFromNow(List<string> items)
        {
            DateTime finalTime;
            if (items.Count > 0)
            {
                //User has picked event time
                if (PickedTime.HasValue)
                {
                    finalTime = PickedTime.Value;

                    if (PickedTime < DateTime.Now)
                    {
                        finalTime += TimeSpan.FromHours(24d);
                        Console.WriteLine("Time of events is: " + finalTime.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("You need to pick time for events.");
                }
            }
            else
            {
                int hours;
                int minutes;
                int seconds;
                hours = int.TryParse(Hours, out hours) ? hours : 0;
                minutes = int.TryParse(Minutes, out minutes) ? minutes : 0;
                seconds = int.TryParse(Seconds, out seconds) ? seconds : 0;
                finalTime = DateTime.Now + new TimeSpan(hours, minutes, seconds);
                //Replace parameter with method
                DisplayTimeInFuture(finalTime);
            }
        }

        private void DisplayTimeInFuture(DateTime finalTime)
        {
            Console.WriteLine(finalTime.ToString());
        }
    }
}
