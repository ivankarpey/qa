using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Core.Infrastructure;

namespace QA.Core.Interfaces
{
    public interface IMessageTransporter
    {
        bool SendMessage(MessageBase message);
        bool ConsumeMessage();
        bool SetSynchronizationMode(SynchronizationModeEnum mode);
    }
}
