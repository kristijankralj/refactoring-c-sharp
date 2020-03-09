using System;

namespace MovingFeatures
{
    public class IntroduceForeignMethod
    {
        public bool CanScheduleEvent()
        {
            bool canSchedule = DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
            return canSchedule;
        }
    }
}
