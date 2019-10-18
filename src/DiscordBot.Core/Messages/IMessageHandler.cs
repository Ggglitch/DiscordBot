﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeaBagBot.Core.Messages
{
    public interface IMessageHandler<T>
    {
        Task HandleMessageAsync(T message);
        Task InitializeAsync();
    }
}
