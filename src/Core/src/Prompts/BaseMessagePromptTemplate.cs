using Newtonsoft.Json;
using LangChain.Providers;
using LangChain.Schema;

namespace LangChain.Prompts;

/// <summary>
/// 
/// </summary>
public abstract class BaseMessagePromptTemplate
{
    /// <summary>
    /// 
    /// </summary>
    public abstract IReadOnlyList<string> InputVariables { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public abstract Task<List<Message>> FormatMessages(InputValues values);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public SerializedMessagePromptTemplate Serialize()
    {
        var serialized = new SerializedMessagePromptTemplate
        {
            Type = this.GetType().Name,
            // You need to serialize 'this' to a JSON string, then deserialize it back to a dictionary
            // to mimic the JavaScript `JSON.parse(JSON.stringify(this))` behavior.
            AdditionalProperties = JsonConvert.DeserializeObject<Dictionary<string, object>>(
                JsonConvert.SerializeObject(this)) ?? new Dictionary<string, object>(),
        };
        return serialized;
    }
}