﻿using System.Globalization;
using LangChain.Serve.Interfaces;
using LangChain.Serve.Classes.Repository;

namespace LangChain.Serve.Services;

public class DateConversationNameProvider: IConversationNameProvider
{
    public Task<string> GetConversationName(List<StoredMessage> messages)
    {
        return Task.FromResult(DateTime.Now.ToString("yy-MM-dd HH:mm", CultureInfo.InvariantCulture));
    }
}