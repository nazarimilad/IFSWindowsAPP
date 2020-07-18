using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class MessagingService
    {
        private static readonly Lazy<MessagingService> lazy = new Lazy<MessagingService>(() => new MessagingService());

        public static MessagingService Instance { get { return lazy.Value; } }

        private MessagingService()
        {
        }
    }
}
