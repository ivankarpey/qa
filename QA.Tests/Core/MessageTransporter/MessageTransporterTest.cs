using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.Core.Interfaces;

namespace QA.Tests.Core.MessageTransporter
{
    [TestClass]
    public class IMessageTransporterTests
    {
        [TestMethod]
        public void CreationAndInitialization()
        {
            IMessageTransporter transporter = new QA.Core.Impl.MessageTransporter();
            Assert.IsNotNull(transporter);
        }
    }
}
