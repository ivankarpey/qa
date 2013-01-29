using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Core.Infrastructure
{
    public abstract class MessageBase
    {
        public String ID { get; set; }
        public String MessageBody { get; set; }
    }
}
