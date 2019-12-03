using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event : IRequest<bool>
    {
        public String EventType { get; protected set; }

        protected Event()
        {
            EventType = this.GetType().Name;
        }
    }
}
