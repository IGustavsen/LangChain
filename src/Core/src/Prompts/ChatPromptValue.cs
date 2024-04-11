using Newtonsoft.Json;
using LangChain.Providers;
using LangChain.Schema;

namespace LangChain.Prompts;

/// <inheritdoc/>
public class ChatPromptValue : BasePromptValue
{
    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyCollection<Message> Messages { get; set; }

    public ChatPromptValue(IReadOnlyCollection<Message> messages)
    {
        Messages = messages;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this.Messages);
    }

    /// <inheritdoc/>
    public override IReadOnlyCollection<Message> ToChatMessages()
    {
        return this.Messages;
    }
}