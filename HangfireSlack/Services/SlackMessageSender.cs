using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HangfireSlack.Services
{
    public class SlackMessageSender : ISlackMessageSender
    {
        private readonly HttpClient _client;

        private const string _randomChannel = "/services/TTTSTTV6C/BU7SQBPN1/Fi1wAbmApOQG7BIheMIdeW61";

        public SlackMessageSender(HttpClient client)
        {
            _client = client;
        }

        public async Task SendMessageOnRandomAsync(string text)
        {
            var contentObject = new { text = text };
            var contentObjectJson = JsonSerializer.Serialize(contentObject);
            var content = new StringContent(contentObjectJson, Encoding.UTF8, "application/json");

            var result = await _client.PostAsync(_randomChannel, content);
            var resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Task failed.");
            }

        }
    }
}
