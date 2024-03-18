using Shared.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public class OrderCreatedEvent : IEvent
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }

    }
}
