using LangChain.Providers;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace LangChain.Memory
{
    /// <summary>
    /// Chat message history that stores history in a local file.
    /// </summary>
    public class FileChatMessageHistory : BaseChatMessageHistory
    {
        private string MessagesFilePath { get; }

        private List<Message> _messages = new List<Message>();

        /// <inheritdoc/>
        public override IReadOnlyList<Message> Messages => _messages;

        private FileChatMessageHistory(string messagesFilePath)
        {
            MessagesFilePath = messagesFilePath ?? throw new ArgumentNullException(nameof(messagesFilePath));
        }

        public static async Task<FileChatMessageHistory> CreateAsync(string path, CancellationToken cancellationToken = default)
        {
            var chatHistory = new FileChatMessageHistory(path);
            await chatHistory.LoadMessages().ConfigureAwait(false);

            return chatHistory;
        }

        /// <inheritdoc/>
        public override async Task AddMessage(Message message)
        {
            _messages.Add(message);
            await SaveMessages().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override async Task Clear()
        {
            _messages.Clear();
            await SaveMessages().ConfigureAwait(false);
        }

        private async Task SaveMessages()
        {
            string json = JsonConvert.SerializeObject(_messages);
            await Task.Run(() => File.WriteAllText(MessagesFilePath, json)).ConfigureAwait(false);
        }

        private Task LoadMessages()
        {
            try
            {
                if (File.Exists(MessagesFilePath))
                {
                    string json = File.ReadAllText(MessagesFilePath);
                    _messages = JsonConvert.DeserializeObject<List<Message>>(json) ?? new List<Message>();
                }

                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }
    }
}
