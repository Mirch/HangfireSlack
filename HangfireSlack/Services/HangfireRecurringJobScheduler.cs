using Hangfire;
using System;

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
                Cron.Weekly(DayOfWeek.Friday, 12));
        }
    }
}
