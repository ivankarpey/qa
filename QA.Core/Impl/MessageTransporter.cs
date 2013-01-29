using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.Util;
using QA.Core.Infrastructure;
using QA.Core.Interfaces;

namespace QA.Core.Impl
{
    //TODO: Transfer all the setings to separate section in config file
    public class MessageTransporter : IMessageTransporter, IDisposable
    {
        private IConnectionFactory _connectionFactory;
        private IConnection _connection;
        private ISession _session;
        private IDestination _destination;
        private IMessageProducer _messageProducer;
        private IMessageConsumer _messageConsumer;
        
        #region Initialization and Disposing
        
        public MessageTransporter()
        {
            _connectionFactory = new Apache.NMS.Stomp.ConnectionFactory("tcp://0.0.0.0:61613");
            _connection = _connectionFactory.CreateConnection();
            _session = _connection.CreateSession();
            _destination = SessionUtil.GetDestination(_session, "queue://testingQueue");
            _messageProducer = _session.CreateProducer(_destination);
            _messageConsumer = _session.CreateConsumer(_destination);
        }

        ~MessageTransporter()
        {
            this.Dispose();    
        }

        public void Dispose()
        {
            _connection.Dispose();
            _session.Dispose();
        }

        #endregion

        public bool SendMessage(MessageBase message)
        {
            throw new NotImplementedException();
        }

        public bool ConsumeMessage()
        {
            throw new NotImplementedException();
        }

        public bool SetSynchronizationMode(SynchronizationModeEnum mode)
        {
            throw new NotImplementedException();
        }

    }
}
