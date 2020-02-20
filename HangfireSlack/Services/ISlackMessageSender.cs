using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireSlack.Services
{
    public interface ISlackMessageSender
    {
        Task SendMessageOnRandomAsync(string text);
    }
}
