using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Message()
        {
            Timestamp = DateTime.Now;
        }
    }
}
