using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Settings
{
    static public class RabbitMQSettings
    {
        public const string Stock_OrderCreatedEventQueue = "stock-order-created-queue";
        public const string Order_StockUpdatedEventQueue = "order-stock-updated-queue";
    }
}
