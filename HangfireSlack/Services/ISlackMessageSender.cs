using System.Threading.Tasks;

namespace HangfireSlack.Services
{
    public interface ISlackMessageSender
    {
        Task SendMessageOnRandomAsync(string text);
    }
}
