using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireSlack.Services
{
    public class HangfireRecurringJobScheduler
    {
        private const string _randomFridayMessageTask = "RandomFridayMessage";

        public static void ScheduleRandomFridayMessage()
        {
            RecurringJob.RemoveIfExists(_randomFridayMessageTask);
            RecurringJob.AddOrUpdate<ISlackMessageSender>(
                _randomFridayMessageTask,
                job => job.SendMessageOnRandomAsync("Great job this week! Don't forget to have a beer before going home!"),
                Cron.Weekly(DayOfWeek.Thursday, 20));
        }
    }
}
